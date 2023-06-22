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
using static System.Windows.Forms.LinkLabel;

namespace LoL_Forms
{
    public partial class ManageUniverse : Form
    {
        public ManageUniverse()
        {
            InitializeComponent();
        }

        private void comboBoxUniverses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ManageUniverse_Load(object sender, EventArgs e)
        {
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

        private void Edit_Click(object sender, EventArgs e)
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

                    ArtLink.Text = reader["art"].ToString();
                    Name.Text = reader["name"].ToString();
                    SkinLine.Text = reader["skinLine"].ToString();
                    YearCreated.Text = reader["yearCreated"].ToString();


                }

                reader.Close();


               
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page = new Admin();
            admin_page.Show();
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (comboBoxUniverses.SelectedItem != null && Name.Text != null && SkinLine.Text != null && ArtLink.Text != null && YearCreated.Text != null )
            {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateUniverse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@name", Name.Text);
                        command.Parameters.AddWithValue("@skinLine", SkinLine.Text);
                        command.Parameters.AddWithValue("@art", ArtLink.Text);
                        command.Parameters.AddWithValue("@yearCreated", YearCreated.Text);
                        

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Success")
                                {
                                    MessageBox.Show("Universe altered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ManageUniverse manageChampios_page = new ManageUniverse();
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
            else
            {
                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (comboBoxUniverses.SelectedItem != null)
            {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.DeleteUniverse", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UniverseName", comboBoxUniverses.SelectedItem.ToString());
                        


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
                                    MessageBox.Show("Universe deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ManageUniverse manageChampios_page = new ManageUniverse();
                                    manageChampios_page.Show();
                                    this.Hide();
                                }
                                
                            }
                            reader.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a universe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            comboBoxUniverses.SelectedItem= null;
            Name.Text = null;
            YearCreated.Text = null;
            SkinLine.Text = null;
            ArtLink.Text = null;
        }
    }
}
