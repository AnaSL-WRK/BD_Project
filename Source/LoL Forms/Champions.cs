using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoL_Forms
{
    

    public partial class Champions : Form
    {
        private List<RadioButton> radioButtons = new List<RadioButton>();
        public Champions()
        {
            InitializeComponent();
            // Set the form border style to FixedSingle
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable the maximize button
            this.MaximizeBox = false;
            // Disable the minimize button
            //this.MinimizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 14); // Set the font size to 14

            champDescription.ReadOnly = true;

            

            // Set the background image layout
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            radioButtons.Add(Noxus);
            radioButtons.Add(Demacia);
            radioButtons.Add(Piltover);
            radioButtons.Add(Targon);
            radioButtons.Add(Shurima);
            radioButtons.Add(Freljord);
            radioButtons.Add(BandleCity);
            radioButtons.Add(Ixtal);
            radioButtons.Add(Ionia);
            radioButtons.Add(Void);
            radioButtons.Add(Bilgewater);
            radioButtons.Add(Zaun);
            radioButtons.Add(ShadowIsles);

            champName.ReadOnly = true;
            champDescription.ReadOnly = true;
            champGender.ReadOnly = true;
            champQuote.ReadOnly = true;
            champRegion.ReadOnly = true;
            champRelease.ReadOnly = true;
            champSpecies.ReadOnly = true;
            QDesc.ReadOnly = true;
            QName.ReadOnly = true;
            WName.ReadOnly = true;
            WDesc.ReadOnly = true;
            EName.ReadOnly = true;
            EDesc.ReadOnly = true;
            RName.ReadOnly = true;
            RDesc.ReadOnly = true;
            PDesc.ReadOnly = true;
            PName.ReadOnly = true;

            // 
            LoadChampions();
        }

        private void LoadChampions()
        {
            
            // Query the database to retrieve the champions
            string query = "SELECT Name FROM Champion";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxChampions.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                string championName = reader["Name"].ToString();
                comboBoxChampions.Items.Add(championName);
                //Champion champ = new Champion(championName, reader["Gender"].ToString(), reader["region_name"].ToString());
                
            }

            reader.Close();
        }

       

        private void runButton_Click(object sender, EventArgs e)
        {
            if(searchChampName.Text == null && comboBoxChampions.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a champion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!string.IsNullOrEmpty(searchChampName.Text) && comboBoxChampions.SelectedItem != null)
            {
                MessageBox.Show("Please select only 1 champion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(!string.IsNullOrEmpty(searchChampName.Text))
            {
                fillFields(searchChampName.Text);
            }
            else if(comboBoxChampions.SelectedItem != null)
            {
                fillFields(comboBoxChampions.SelectedItem.ToString());

            }
            // Retrieve the selected champion from the dropdown
            

            
        }

        private void fillFields(String selectedChampion)
        {


            // Query the database to fetch additional information about the selected champion
            string query = "SELECT * FROM Champion WHERE Name = @ChampionName";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("@ChampionName", selectedChampion);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                string splashArtLink = reader["splashArt"].ToString();
                champImage.SizeMode = PictureBoxSizeMode.StretchImage;
                champImage.ImageLocation = splashArtLink;
                champDescription.Text = reader["description"].ToString();
                champName.Text = selectedChampion;
                champGender.Text = reader["Gender"].ToString();
                champSpecies.Text = reader["Species"].ToString();
                champRegion.Text = reader["region_name"].ToString();
                champQuote.Text = reader["quote"].ToString();
                champRelease.Text = reader["releaseDate"].ToString();

            }
            else
            {
                MessageBox.Show("Champion not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();

            
            query = $"SELECT * FROM Abilities WHERE champion_name = @ChampionName";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("@ChampionName", selectedChampion);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                QDesc.Text = reader["Q_description"].ToString();
                WDesc.Text = reader["W_description"].ToString();
                EDesc.Text = reader["E_description"].ToString();
                RDesc.Text = reader["R_description"].ToString();
                PDesc.Text = reader["P_description"].ToString();
                QName.Text = reader["Q_name"].ToString();
                WName.Text = reader["W_name"].ToString();
                EName.Text = reader["E_name"].ToString();
                RName.Text = reader["R_name"].ToString();
                PName.Text = reader["P_name"].ToString();
            }
            reader.Close();
        }

        

        private void resetButton_Click(object sender, EventArgs e)
        {
            champImage.ImageLocation = string.Empty;
            champDescription.Text = string.Empty;
            champGender.Text = string.Empty;
            champName.Text = string.Empty;
            champQuote.Text = string.Empty;
            champRegion.Text = string.Empty;
            champRelease.Text = string.Empty;
            champSpecies.Text = string.Empty;
            comboBoxChampions.SelectedItem = null;
            QDesc.Text = string.Empty; 
            QName.Text = string.Empty;
            WDesc.Text = string.Empty;
            WName.Text = string.Empty;
            WDesc.Text = string.Empty;
            EDesc.Text = string.Empty;
            EName.Text = string.Empty;
            RName.Text = string.Empty;
            RDesc.Text = string.Empty;
            PName.Text = string.Empty;
            PDesc.Text = string.Empty;
            foreach(RadioButton r in radioButtons)
            {
                r.Checked = false;
            }
            Male.Checked= false;
            Female.Checked= false;
        }

     
        private void applyFilters()
        {
            string genderFilter = null; // Set the gender filter value based on the selected radio button
            string regionFilter = null; // Set the region filter value based on the selected radio button
            
            foreach(RadioButton r in radioButtons)
            {
                if (r.Checked)
                {
                    regionFilter = r.Text;
                    break;
                }
            }

            if (Male.Checked)
            {
                genderFilter = "Male";
            }else if (Female.Checked)
            {
                genderFilter= "Female";
            }

            
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                

                // Create a command for the stored procedure
                using (SqlCommand command = new ("dbo.FilterChampions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    command.Parameters.Add("@GenderFilter", SqlDbType.VarChar, 6).Value = genderFilter ?? (object)DBNull.Value;
                    command.Parameters.Add("@RegionFilter", SqlDbType.VarChar, 50).Value = regionFilter ?? (object)DBNull.Value;

                    // Execute the command and retrieve the filtered results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear the items in the comboBoxChampions
                        comboBoxChampions.Items.Clear();

                        // Iterate through the filtered results and add them to the comboBoxChampions
                        while (reader.Read())
                        {
                            string championName = reader["Name"].ToString();
                            comboBoxChampions.Items.Add(championName);
                        }
                    }
                }
            }

        }

        private void Demacia_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
           
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Piltover_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Targon_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Shurima_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Freljord_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void BandleCity_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Ixtal_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Ionia_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Void_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Bilgewater_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Zaun_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Noxus_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void ShadowIsles_CheckedChanged(object sender, EventArgs e)
        {
            applyFilters();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }
    }




   

}
