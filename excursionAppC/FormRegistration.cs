using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace excursionAppC
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            genderComboBox.Items.AddRange(new string[] { "Мужской", "Женский", "Другой" });
            genderComboBox.SelectedIndex = 0;  // Установка значения по умолчанию
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string gender = genderComboBox.SelectedItem.ToString();
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            if (UserExists(username))
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }
            if (RegisterUser(username, password, gender))
            {
               
                MessageBox.Show("Регистрация успешно завершена.");
                Form1 form = new Form1();
                this.Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации. Пожалуйста, попробуйте позже.");
            }
        }
        private bool UserExists(string username)
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                int userCount = (int)command.ExecuteScalar();
                return userCount > 0;
            }
        }
        private bool RegisterUser(string username, string password, string gender)
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "INSERT INTO Users (Username, PasswordHash, Gender) VALUES (@Username, @PasswordHash, @Gender)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", ComputeSha256Hash(password));
                command.Parameters.AddWithValue("@Gender", gender);
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException)
                {
                    // Обработка исключения, например, если пользователь с таким именем уже существует
                    return false;
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
