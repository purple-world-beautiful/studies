using System.Data.SQLite;

namespace studentRegistration
{
    public partial class loginForm : Form
    {
        public static SQLiteConnection DB = new SQLiteConnection(DataBase.connection);
        public loginForm()
        {
            InitializeComponent();
            DB.Open();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            string login = logTxt.Text;
            string password = passTxt.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Имя пользователя и пароль не могут быть пустыми.");
                return;
            }

            using (var command = new SQLiteCommand("SELECT COUNT(*) FROM Пользователи WHERE Логин = @login AND Пароль = @password", DB))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                int userCount = Convert.ToInt32(command.ExecuteScalar());

                if (userCount > 0)
                {
                    DB.Close();
                    Application.Exit();
                    var thread = new Thread(OpenMainForm);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль.");
                }
            }
        }

        public void OpenMainForm()
        {
            Application.Run(new mainForm());
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string login = logTxt.Text;
            string password = passTxt.Text;

            if (login.Length < 5 || password.Length < 5)
            {
                MessageBox.Show("Имя пользователя и пароль должны содержать не менее 5 символов.");
                return;
            }

            using (var command = new SQLiteCommand("INSERT INTO Пользователи (Логин, Пароль) VALUES (@login, @password)", DB))
            {
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                    logTxt.Text = "";
                    passTxt.Text = "";
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DB.Close();
            Application.Exit();
        }
    }
}
