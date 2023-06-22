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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoL_Forms
{
    public partial class ManageChampions : Form
    {
        public ManageChampions()
        {
            InitializeComponent();
        }

        private void ManageChampions_Load_1(object sender, EventArgs e)
        {
            // Query the database to retrieve the champion data
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteChamp(string champ)
        {
            string result = null;
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("dbo.DeleteChampion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ChampName", champ);
                    //command.Parameters.AddWithValue("@Password", Password.Text);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader.GetString(0); // Retrieve the result from the first column
                            if (result == "Champion not found, rollbacking transaction.")
                            {
                                MessageBox.Show("Champion not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (result == "Success")
                            {
                                MessageBox.Show("Champion deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ManageChampions manageChampios_page = new ManageChampions();
                                manageChampios_page.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        reader.Close();
                    }

                }
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (searchChampName.Text == null && comboBoxChampions.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a champion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!string.IsNullOrEmpty(searchChampName.Text) && comboBoxChampions.SelectedItem != null)
            {
                MessageBox.Show("Please select only 1 champion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!string.IsNullOrEmpty(searchChampName.Text))
            {
                deleteChamp(searchChampName.Text);
            }
            else if (comboBoxChampions.SelectedItem != null)
            {
                deleteChamp(comboBoxChampions.SelectedItem.ToString());

            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (searchChampName.Text == null && comboBoxChampions.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a champion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!string.IsNullOrEmpty(searchChampName.Text) && comboBoxChampions.SelectedItem != null)
            {
                MessageBox.Show("Please select only 1 champion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!string.IsNullOrEmpty(searchChampName.Text))
            {
                fillFields(searchChampName.Text);
            }
            else if (comboBoxChampions.SelectedItem != null)
            {
                fillFields(comboBoxChampions.SelectedItem.ToString());

            }
        }

        private void fillFields(String selectedChampion)
        {
            string query = "SELECT name FROM Region";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Region.Items.Add(reader["name"].ToString());
            }
            Region.Items.Add("Runeterra (Unknown)");
            reader.Close();
            Gender.Items.Add("Male");
            Gender.Items.Add("Female");
            Gender.Items.Add("Other");

            // Query the database to fetch additional information about the selected champion
            query = "SELECT * FROM Champion WHERE Name = @ChampionName";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            command.Parameters.AddWithValue("@ChampionName", selectedChampion);
            reader = command.ExecuteReader();

            if (reader.Read())
            {

                SplashArt.Text = reader["splashArt"].ToString();
               
                Description.Text = reader["description"].ToString();
                Name.Text = selectedChampion;
                Gender.Text= reader["Gender"].ToString();
                Species.Text = reader["Species"].ToString();
                Region.Text = reader["region_name"].ToString();
                Quote.Text = reader["quote"].ToString();
                ReleaseDate.Text = reader["releaseDate"].ToString();

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

        private void Save_Click(object sender, EventArgs e)
        {
            string result = null;
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("dbo.UpdateChampion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@name", Name.Text);
                    command.Parameters.AddWithValue("@gender", Gender.SelectedItem);
                    command.Parameters.AddWithValue("@description", Description.Text);
                    command.Parameters.AddWithValue("@species", Species.Text);
                    command.Parameters.AddWithValue("@region_name", Region.SelectedItem);
                    command.Parameters.AddWithValue("@splashArt", SplashArt.Text);
                    command.Parameters.AddWithValue("@quote", Quote.Text);
                    command.Parameters.AddWithValue("@releaseDate", ReleaseDate.Value);
                    command.Parameters.AddWithValue("@P_name", PName.Text);
                    command.Parameters.AddWithValue("@P_description", PDesc.Text);
                    command.Parameters.AddWithValue("@Q_name", QName.Text);
                    command.Parameters.AddWithValue("@Q_description", QDesc.Text);
                    command.Parameters.AddWithValue("@W_name", WName.Text);
                    command.Parameters.AddWithValue("@W_description", WDesc.Text);
                    command.Parameters.AddWithValue("@E_name", EName.Text);
                    command.Parameters.AddWithValue("@E_description", EDesc.Text);
                    command.Parameters.AddWithValue("@R_name", RName.Text);
                    command.Parameters.AddWithValue("@R_description", RDesc.Text);
                   

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result = reader.GetString(0); // Retrieve the result from the first column
                            if (result != "Success")
                            {
                                MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (result == "Success")
                            {
                                MessageBox.Show("Champion Altered Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ManageChampions manageChampios_page = new ManageChampions();
                                manageChampios_page.Show();
                                this.Hide();
                            }
                            
                        }
                        reader.Close();
                    }

                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page= new Admin();
            admin_page.Show();
            this.Hide();
        }
    }
}
