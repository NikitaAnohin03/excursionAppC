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
    public partial class AttractionsForm : Form
    {
        private string cityName;
        public AttractionsForm(String cityName)
        {
            InitializeComponent();
            this.cityName = cityName;
            loadAttractions();
        
        }
        private void loadAttractions()
        {
            Db db = new Db();
            int placeId = GetPlaceIdByCityName(cityName);
            if (placeId == -1)
            {
                MessageBox.Show("Город не найден в базе данных.");
                return;
            }

            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "SELECT Name, Description, ImageURL, Location FROM Attractions WHERE PlaceID = @PlaceID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@PlaceID", placeId);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    FlowLayoutPanel panel = new FlowLayoutPanel
                    {
                        
                        Dock = DockStyle.Fill,
                        AutoScroll = true,
                        FlowDirection = FlowDirection.TopDown,
                        WrapContents = false,
                        Padding = new Padding(10)
                    };
                    Image backgroundImage = Properties.Resources._1612769042_20_p_goluboi_fon_dlya_pisma_22;

                    // Установка изображения как фона
                    panel.BackgroundImage = backgroundImage;
                    panel.BackgroundImageLayout = ImageLayout.Stretch;
                    this.Controls.Add(panel);

                    while (reader.Read())
                    {
                        TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
                        {
                            ColumnCount = 2,
                            RowCount = 1,
                            Size = new Size(780, 200),
                            Padding = new Padding(5),
                             BackColor = Color.Transparent
                        };

                        PictureBox pictureBox = new PictureBox
                        {
                            ImageLocation = reader["ImageURL"].ToString(),
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Size = new Size(150, 150),
                            Margin = new Padding(0, 0, 10, 0)
                        };
                        tableLayoutPanel.Controls.Add(pictureBox, 0, 0);

                        Panel infoPanel = new Panel
                        {
                            Size = new Size(600, 150),
                            Padding = new Padding(5),
                            Dock = DockStyle.Fill
                        };

                        Label nameLabel = new Label
                        {
                            Text = reader["Name"].ToString(),
                            AutoSize = false,
                            Size = new Size(540, 30),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Font = new Font("Arial", 10, FontStyle.Bold)
                        };
                        infoPanel.Controls.Add(nameLabel);

                        Label descriptionLabel = new Label
                        {
                            Text = reader["Description"].ToString(),
                            AutoSize = false,
                            Size = new Size(540, 70),
                            TextAlign = ContentAlignment.MiddleLeft,
                            Font = new Font("Arial", 9)
                        };
                        infoPanel.Controls.Add(descriptionLabel);

                        Button mapButton = new Button
                        {
                            Text = "Показать на карте",
                            AutoSize = true,
                            AutoSizeMode = AutoSizeMode.GrowAndShrink,
                            Dock = DockStyle.Bottom,
                            Margin = new Padding(0, 10, 0, 10),
                            FlatStyle = FlatStyle.Popup,
                            BackColor = SystemColors.ActiveCaption
                        };
                        mapButton.Click += MapButton_Click;
                        infoPanel.Controls.Add(mapButton);

                        tableLayoutPanel.Controls.Add(infoPanel, 1, 0);
                        panel.Controls.Add(tableLayoutPanel);
                    }
                }
            }
        }
        private void MapButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null && button.Tag != null)
            {
                string url = button.Tag.ToString();
                System.Diagnostics.Process.Start("explorer.exe", url);
            }
        }
        private int GetPlaceIdByCityName(string cityName)
        {
            Db db = new Db();
            using (SqlConnection connection = db.getConnection())
            {
                connection.Open();
                string sql = "SELECT PlaceID FROM Places WHERE Name = @CityName";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CityName", cityName);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return -1; // Возвращаем -1 если город не найден
                }
            }
        }
        private void AttractionsForm_Load(object sender, EventArgs e)
        {

        }
        void MapLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
          {
                LinkLabel linkLabel = sender as LinkLabel;
                if (linkLabel != null && linkLabel.Tag != null)
                {
                    string url = linkLabel.Tag.ToString();
                    System.Diagnostics.Process.Start("explorer.exe", url);
                }
          }

        }
    }

