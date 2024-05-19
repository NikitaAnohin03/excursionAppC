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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            UpdateUserCountLabel();
        }

        private void UpdateUserCountLabel()
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                string query = "SELECT COUNT(*) FROM Users";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    int userCount = (int)command.ExecuteScalar();
                    labelCountUsers.Text = $"Пользователей зарегестрировано: {userCount}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            FormAddCity formAddCity = new FormAddCity();
            formAddCity.Show();
        }

        private void buttonAddAttractions_Click(object sender, EventArgs e)
        {
            FormAddAttractions form = new FormAddAttractions();
            form.Show();
        }

        private void buttonDeleteCity_Click(object sender, EventArgs e)
        {
            FormDeleteCity formDeleteCity = new FormDeleteCity();
            formDeleteCity.Show();
        }

        private void buttonDeleteAAttractions_Click(object sender, EventArgs e)
        {
            FormDeleteAttractions form = new FormDeleteAttractions();
            form.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
