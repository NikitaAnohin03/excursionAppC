using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace excursionAppC
{
    public partial class DetailsForm : Form
    {
        string cityName;
        public DetailsForm(string cityName)
        {
            this.cityName = cityName;
            InitializeComponent();
            cityPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            LoadDetails(cityName);
            cityPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void LoadDetails(string cityName)
        {
            Db db = new Db();

            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "SELECT Name, Description, ImageURL FROM Places WHERE Name = @CityName";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CityName", cityName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Предполагаем, что на форме есть Label и PictureBox для отображения данных
                        nameLabel.Text = reader["Name"].ToString();
                        descriptionLabel.Text = reader["Description"].ToString();
                        cityPictureBox.ImageLocation = reader["ImageURL"].ToString();
                    }
                }
            }
        }
        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
        private void AttractionButton_Click(object sender, EventArgs e)
        {
            AttractionsForm attractionsForm = new AttractionsForm(cityName);
            attractionsForm.ShowDialog();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
