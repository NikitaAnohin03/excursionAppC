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

namespace excursionAppC
{
    public partial class FormAddCity : Form
    {
        public FormAddCity()
        {
            InitializeComponent();
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            Db db = new Db();
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            string imageURL = imageURLTextBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Заполните поля.");
                return;
            }

            using (SqlConnection connection = db.getConnection())
            {
                string query = "INSERT INTO Places (Name, Description, ImageURL) VALUES (@Name, @Description, @ImageURL)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@ImageURL", imageURL);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Город успешно добавлен.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка: " + ex.Message);
                }
            }
        }
        private void ClearFields()
        {
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            imageURLTextBox.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
