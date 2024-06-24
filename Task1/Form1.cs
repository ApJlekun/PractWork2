namespace Task1
{
    public partial class Form1 : Form
    {
        private const string loginsFile = "logins.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (CheckIfUserExists(login))
            {
                MessageBox.Show("Данный логин уже занят.");
            }
            else
            {
                string registrationDate = DateTime.Now.ToString("yyyy-MM-dd");
                string userData = $"{login};{password};{registrationDate}";

                using (StreamWriter writer = File.AppendText(loginsFile))
                {
                    writer.WriteLine(userData);
                }

                MessageBox.Show("Пользователь зарегистрирован.");
            }
        }
        private bool CheckIfUserExists(string login)
        {
            if (File.Exists(loginsFile))
            {
                string[] lines = File.ReadAllLines(loginsFile);

                foreach (var line in lines)
                {
                    string[] userData = line.Split(';');
                    if (userData.Length > 0 && userData[0] == login)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
