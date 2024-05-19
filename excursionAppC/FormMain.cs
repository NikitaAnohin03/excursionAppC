using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excursionAppC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadCities();
        }
        private void LoadCities()
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "SELECT Name, ImageURL FROM Places";
                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string cityName = reader["Name"].ToString();
                        string imageUrl = reader["ImageURL"].ToString();
                        PictureBox pictureBox = new PictureBox
                        {
                            ImageLocation = imageUrl,
                            Size = new Size(200, 100),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            BorderStyle = BorderStyle.Fixed3D,
                            Cursor = Cursors.Hand
                        };
                        pictureBox.Click += (sender, e) => ShowDetailsForm(cityName);

                        Label label = new Label
                        {
                            Text = cityName,
                            TextAlign = ContentAlignment.TopCenter,
                            Dock = DockStyle.Bottom
                        };

                        Panel panel = new Panel
                        {
                            Size = new Size(200, 150),
                            Margin = new Padding(5)
                        };
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(label);

                        flowLayoutPanel.Controls.Add(panel);
                    }
                }
            }
        }

        private void ShowDetailsForm(string cityName)
        {
            DetailsForm detailsForm = new DetailsForm(cityName);
            detailsForm.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAllList formAllList = new FormAllList("Places"); 
            formAllList.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAllList formAllList = new FormAllList("Attractions");
            formAllList.ShowDialog();
        }
    }
}
