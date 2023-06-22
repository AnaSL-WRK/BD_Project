using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace LoL_Forms
{
    public partial class Universes : Form
    {
        public Universes()
        {
            InitializeComponent();
        }

        private void Universes_Load(object sender, EventArgs e)
        {
            Name.ReadOnly = true;
            SkinLine.ReadOnly = true;
            YearCreated.ReadOnly = true;
            Champions.ReadOnly = true;
            // Query the database to retrieve the champion data
            string query = "SELECT name FROM Alternate_Universe";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxUniverses.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {

                comboBoxUniverses.Items.Add(reader["name"].ToString());
                

            }

            reader.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBoxUniverses.SelectedItem == null)
            {
                MessageBox.Show("Please choose a universe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string query = "SELECT * FROM Alternate_Universe WHERE name = @ChampionName";
                SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
                command.Parameters.AddWithValue("@ChampionName", comboBoxUniverses.SelectedItem.ToString());
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    string splashArtLink = reader["art"].ToString();
                    Art.SizeMode = PictureBoxSizeMode.StretchImage;
                    Art.ImageLocation = splashArtLink;
                    Name.Text = reader["name"].ToString();
           
                    SkinLine.Text = reader["skinLine"].ToString();
                    YearCreated.Text = reader["yearCreated"].ToString();
                    

                }
                
                reader.Close();


                query = "SELECT * FROM EXISTS_ON WHERE universe_name = @UniverseName";
                command = new SqlCommand(query, DatabaseConnection.GetConnection());
                command.Parameters.AddWithValue("@UniverseName", comboBoxUniverses.SelectedItem.ToString());
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Champions.AppendText(reader["champion_name"].ToString() + Environment.NewLine);
                      
                    
                }
                reader.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }
    }
}
