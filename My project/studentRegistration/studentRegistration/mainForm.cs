using System.Data;
using System.Data.SQLite;

namespace studentRegistration
{
    public partial class mainForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);

        public mainForm()
        {
            InitializeComponent();
            DB.Open();
        }

        private void searchStudentBtn_Click(object sender, EventArgs e)
        {
            string idText = idTxt.Text.Trim();
            string fullNameText = fullNameTxt.Text.Trim();

            if (string.IsNullOrEmpty(idText) && string.IsNullOrEmpty(fullNameText))
            {
                MessageBox.Show("Пожалуйста, введите номер или ФИО студента для поиска.");
                return;
            }

            if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(fullNameText))
            {
                MessageBox.Show("Пожалуйста, выберите только одно поле для поиска: Номер или ФИО.");
                idTxt.Clear();
                fullNameTxt.Clear();
                return;
            }

            string query = "SELECT * FROM Студенты WHERE ";
            if (!string.IsNullOrEmpty(idText))
            {
                query += "Номер = @id";
            }
            else if (!string.IsNullOrEmpty(fullNameText))
            {
                query += "ФИО LIKE @fullName";
            }

            try
            {
                using (SQLiteCommand command = new SQLiteCommand(query, DB))
                {
                    if (!string.IsNullOrEmpty(idText))
                    {
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(idText));
                    }
                    else if (!string.IsNullOrEmpty(fullNameText))
                    {
                        command.Parameters.AddWithValue("@fullName", "%" + fullNameText + "%");
                    }
                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    studentsDataGridView.DataSource = dataTable;
                    studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Студенты не найдены.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadStudentsData();
            LoadGroups();
        }

        private void LoadStudentsData()
        {
            try
            {
                string query = "SELECT * FROM Студенты";
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
            try
            {
                string query = "SELECT DISTINCT Группа FROM Студенты";
                SQLiteCommand command = new SQLiteCommand(query, DB);

                if (DB.State != ConnectionState.Open)
                {
                    DB.Open();
                }

                SQLiteDataReader reader = command.ExecuteReader();
                groupComboBox.Items.Clear();
                while (reader.Read())
                {
                    string groupName = reader["Группа"].ToString();
                    groupComboBox.Items.Add(groupName);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке групп: " + ex.Message);
            }
        }

        private void resetTableBtn_Click(object sender, EventArgs e)
        {
            LoadStudentsData();
        }

        private void deleteStudentBtn_Click_1(object sender, EventArgs e)
        {
            string idText = idTxt.Text.Trim();

            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Пожалуйста, введите номер студента для удаления.");
                return;
            }

            try
            {
                string query = "DELETE FROM Студенты WHERE Номер = @id";
                using (SQLiteCommand command = new SQLiteCommand(query, DB))
                {
                    command.Parameters.AddWithValue("@id", Convert.ToInt32(idText));
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Студент успешно удален.");
                    }
                    else
                    {
                        MessageBox.Show("Студент с таким номером не найден.");
                    }
                }

                LoadStudentsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении студента: " + ex.Message);
            }
        }

        private void searchGroupBtn_Click(object sender, EventArgs e)
        {
            string selectedGroup = groupComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedGroup))
            {
                MessageBox.Show("Пожалуйста, выберите группу для поиска.");
                groupComboBox.Text = "";
                return;
            }

            try
            {
                string query = "SELECT * FROM Студенты WHERE Группа = @group";
                using (SQLiteCommand command = new SQLiteCommand(query, DB))
                {
                    command.Parameters.AddWithValue("@group", selectedGroup);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    studentsDataGridView.DataSource = dataTable;
                    studentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Студенты не найдены в выбранной группе.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении поиска: " + ex.Message);
            }
        }

        private void reportingBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenReportingForm);
            thread.Start();
        }

        public void OpenReportingForm()
        {
            Application.Run(new reportingForm());
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
            var thread = new Thread(OpenAddStudentForm);
            thread.Start();
        }

        public void OpenAddStudentForm()
        {
            Application.Run(new addStudentForm());
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
        }
    }
}
