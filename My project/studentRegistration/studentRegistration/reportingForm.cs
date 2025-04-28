using System.Data;
using System.Data.SQLite;

namespace studentRegistration
{
    public partial class reportingForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);

        public reportingForm()
        {
            InitializeComponent();
            DB.Open();
        }

        private void reportingForm_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
            LoadGroups();
            LoadSubjects();
        }

        private void LoadStudentsData()
        {
            try
            {
                string query = "SELECT * FROM Оценки";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, DB);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                studentsDataGridView.DataSource = dataTable;
                studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void LoadGroups()
        {
            string query = "SELECT DISTINCT Группа FROM Студенты";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            groupComboBox.Items.Add(reader["Группа"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке групп: " + ex.Message);
            }
        }

        private void LoadStudents(string group)
        {
            fullNameComboBox.Items.Clear();
            string query = "SELECT ФИО FROM Студенты WHERE Группа = @group";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@group", group);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fullNameComboBox.Items.Add(reader["ФИО"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке студентов: " + ex.Message);
            }
        }

        private void LoadSubjects()
        {
            string query = "SELECT Наименование_предмета FROM Предметы";
            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itemComboBox.Items.Add(reader["Наименование_предмета"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке предметов: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenMainForm);
            thread.Start();
        }

        public void OpenMainForm()
        {
            Application.Run(new mainForm());
        }

        private void groupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = groupComboBox.SelectedItem.ToString();
            LoadStudents(selectedGroup);
        }

        private void reportingBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(groupComboBox.Text) ||
                    string.IsNullOrWhiteSpace(fullNameComboBox.Text) ||
                    string.IsNullOrWhiteSpace(itemComboBox.Text) ||
                    string.IsNullOrWhiteSpace(dateTxt.Text) ||
                    string.IsNullOrWhiteSpace(gradeTxt.Text) ||
                    string.IsNullOrWhiteSpace(missedHoursTxt.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                string query = "INSERT INTO Оценки (Номер_студента, ФИО, Группа, Предмет, Дата, Оценка, Пропущенные_часы) " +
                               "VALUES ((SELECT Номер FROM Студенты WHERE ФИО = @fullName), @fullName, @group, @subject, @date, @grade, @missedHours)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@fullName", fullNameComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@group", groupComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@subject", itemComboBox.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@date", dateTxt.Text);
                    cmd.Parameters.AddWithValue("@grade", Convert.ToInt32(gradeTxt.Text));
                    cmd.Parameters.AddWithValue("@missedHours", Convert.ToDouble(missedHoursTxt.Text));

                    cmd.ExecuteNonQuery();
                }
                UpdateStudentAverageAndMissedHours(fullNameComboBox.SelectedItem.ToString());
                LoadGrades();
                messageLab.Text = "Данные успешно добавлены";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении данных: " + ex.Message);
            }
        }

        private void LoadGrades()
        {
            try
            {
                string query = "SELECT Номер_студента, ФИО, Группа, Предмет, Дата, Оценка, Пропущенные_часы FROM Оценки";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        studentsDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void UpdateStudentAverageAndMissedHours(string fullName)
        {
            try
            {
                int studentId;
                string query = "SELECT Номер FROM Студенты WHERE ФИО = @fullName";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@fullName", fullName);
                    studentId = Convert.ToInt32(cmd.ExecuteScalar());
                }
                double averageGrade;
                query = "SELECT AVG(Оценка) FROM Оценки WHERE Номер_студента = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    averageGrade = Convert.ToDouble(cmd.ExecuteScalar());
                }
                double totalMissedHours;
                query = "SELECT SUM(Пропущенные_часы) FROM Оценки WHERE Номер_студента = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    totalMissedHours = Convert.ToDouble(cmd.ExecuteScalar());
                }

                query = "UPDATE Студенты SET Средний_балл = @averageGrade, Пропущенные_часы = @totalMissedHours WHERE Номер = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@averageGrade", averageGrade);
                    cmd.Parameters.AddWithValue("@totalMissedHours", totalMissedHours);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении данных студента: " + ex.Message);
            }
        }

        private void searchStudentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idTxt.Text))
                {
                    MessageBox.Show("Пожалуйста, введите ID студента.");
                    return;
                }
                int studentId = Convert.ToInt32(idTxt.Text);
                string query = "SELECT Номер_студента, ФИО, Группа, Предмет, Дата, Оценка, Пропущенные_часы FROM Оценки WHERE Номер_студента = @studentId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, DB))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            studentsDataGridView.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Студент с указанным ID не найден.");
                            studentsDataGridView.DataSource = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при поиске студента: " + ex.Message);
            }
        }
    }
}
