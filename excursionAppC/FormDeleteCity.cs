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
    public partial class FormDeleteCity : Form
    {
        public FormDeleteCity()
        {
            InitializeComponent();
            LoadCities();
        }

        private void LoadCities()
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                string query = "SELECT Name FROM Places";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cityListBox.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string cityName = cityListBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Выберите город для удаления.");
                return;
            }

            if (MessageBox.Show($"Вы уверенны что хотите удалить город '{cityName}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Db db = new Db();
                using (SqlConnection connection = db.getConnection())
                {
                    connection.Open();

                    // Step 1: Delete attractions related to the city
                    string deleteAttractionsQuery = "DELETE FROM Attractions WHERE PlaceID = (SELECT PlaceID FROM Places WHERE Name = @CityName)";
                    SqlCommand deleteAttractionsCommand = new SqlCommand(deleteAttractionsQuery, connection);
                    deleteAttractionsCommand.Parameters.AddWithValue("@CityName", cityName);
                    deleteAttractionsCommand.ExecuteNonQuery();

                    // Step 2: Delete the city
                    string deleteCityQuery = "DELETE FROM Places WHERE Name = @CityName";
                    SqlCommand deleteCityCommand = new SqlCommand(deleteCityQuery, connection);
                    deleteCityCommand.Parameters.AddWithValue("@CityName", cityName);

                    try
                    {
                        int attractionsDeleted = deleteAttractionsCommand.ExecuteNonQuery();
                        int cityDeleted = deleteCityCommand.ExecuteNonQuery();

                        if (cityDeleted > 0)
                        {
                            MessageBox.Show($"Город '{cityName}' и достопримечательности {attractionsDeleted}  успешно удалены.");
                            cityListBox.Items.Remove(cityName);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка удаления города.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
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
