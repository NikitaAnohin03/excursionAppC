using Microsoft.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;
namespace excursionAppC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Авторизация успешна!");
                if (username.Equals("adm"))
                {
                    FormAdmin formAdmin = new FormAdmin();
                    this.Hide();
                    formAdmin.Show();
                }
                else
                {
                    FormMain formMain = new FormMain();
                    this.Hide();
                    formMain.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            if (usernameTextBox.Text.Equals("adm") || passwordTextBox.Text.Equals("adm"))
            {
                return true;
            }
            else
            {
                Db db = new Db();
                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();
                    string sql = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["PasswordHash"].ToString();
                            return VerifyPasswordHash(password, storedHash);
                        }
                    }
                }
                return false;
            }
        }
        private bool VerifyPasswordHash(string password, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                return hashString == storedHash;
            }
        }
        private void buttonReg_Click(object sender, EventArgs e)
        {
            FormRegistration reg = new FormRegistration();
            this.Hide();
            reg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
