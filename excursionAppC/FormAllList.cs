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
    public partial class FormAllList : Form
    {
        string tableName;
        public FormAllList(string tableName)
        {
            InitializeComponent();
            this.tableName = tableName;

            if (tableName == "Attractions")
            {
                LoadAttractions();
            }
            else if (tableName == "Places")
            {
                LoadCities();
            }
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
                    listBox.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
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
                    listBox.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
        }
    

    private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
