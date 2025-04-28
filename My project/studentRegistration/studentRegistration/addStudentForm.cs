using System.Data;
using System.Data.SQLite;

namespace studentRegistration
{
    public partial class addStudentForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);

        public addStudentForm()
        {
            InitializeComponent();
            DB.Open();
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

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTxt.Text;
            string group = groupComboBox.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(group))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                fullNameTxt.Text = "";
                groupComboBox.Text = "";
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO Студенты (ФИО, Группа, Пропущенные_часы, Средний_балл) VALUES (@fullName, @group, @missedHours, @averageGrade)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, DB))
                {
                    command.Parameters.AddWithValue("@fullName", fullName);
                    command.Parameters.AddWithValue("@group", group);
                    command.Parameters.AddWithValue("@missedHours", 0);
                    command.Parameters.AddWithValue("@averageGrade", 0);
                    command.ExecuteNonQuery();
                }

                fullNameTxt.Clear();
                groupComboBox.SelectedIndex = -1;
                messageLab.Text = $"Студент {fullName} добавлен!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении студента: " + ex.Message);
            }
        }

        private void addStudentForm_Load(object sender, EventArgs e)
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
    }
}
