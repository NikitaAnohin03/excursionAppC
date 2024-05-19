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
    public partial class FormAddAttractions : Form
    {
        public FormAddAttractions()
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
                    cityComboBox.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }

        private int GetCityID(string cityName)
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                string query = "SELECT PlaceID FROM Places WHERE Name = @CityName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CityName", cityName);
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                return -1; // Return -1 if city is not found
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string cityName = cityComboBox.SelectedItem.ToString();
            string location = locationTextBox.Text; 
            string attractionName = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            string imageURL = imageURLTextBox.Text;

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Выберите город.");
                return;
            }

            if (string.IsNullOrWhiteSpace(attractionName))
            {
                MessageBox.Show("Введите название.");
                return;
            }

            int cityID = GetCityID(cityName);
            if (cityID == -1)
            {
                MessageBox.Show("Выбранный город не найдет.");
                return;
            }
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                string query = "INSERT INTO Attractions (PlaceID, Name, Description, Location, ImageURL) VALUES (@PlaceID, @Name, @Description, @Location, @ImageURL)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PlaceID", cityID);
                command.Parameters.AddWithValue("@Name", attractionName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Location", location); 
                command.Parameters.AddWithValue("@ImageURL", imageURL);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Успешно добавлена.");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при добавлении.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
        private void ClearFields()
        {
            cityComboBox.SelectedIndex = -1;
            nameTextBox.Text = "";
            descriptionTextBox.Text = "";
            locationTextBox.Text = ""; 
            imageURLTextBox.Text = "";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
