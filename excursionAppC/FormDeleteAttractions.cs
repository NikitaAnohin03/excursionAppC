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
    public partial class FormDeleteAttractions : Form
    {
        public FormDeleteAttractions()
        {
            InitializeComponent();
            LoadAttractions();
        }
        private void LoadAttractions()
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                string query = "SELECT Name FROM Attractions";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    attractionListBox.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string attractionName = attractionListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(attractionName))
            {
                MessageBox.Show("Выберите достопримечательность");
                return;
            }

            if (MessageBox.Show($"Вы уверенны что хотети удалить '{attractionName}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Db db = new Db();
                using (SqlConnection connection = db.getConnection())
                {
                    string query = "DELETE FROM Attractions WHERE Name = @AttractionName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AttractionName", attractionName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Успешно удалено.");
                            attractionListBox.Items.Remove(attractionName);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка удаления.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
