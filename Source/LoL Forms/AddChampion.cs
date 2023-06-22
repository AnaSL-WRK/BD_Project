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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoL_Forms
{
    public partial class AddChampion : Form
    {
        public AddChampion()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddChampion_Load(object sender, EventArgs e)
        {
            Gender.Items.Add("Male");
            Gender.Items.Add("Female");
            Gender.Items.Add("Other");
            string query = "SELECT name FROM Region";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Region.Items.Add(reader["name"].ToString());
            }
            Region.Items.Add("Runeterra (Unknown)");
            reader.Close();

            query = "SELECT title FROM Stories";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            Story.Items.Clear();

            
            while (reader.Read())
            {
                string storieName = reader["title"].ToString();
                Story.Items.Add(storieName);

            }

            reader.Close();

             query = "SELECT name FROM Alternate_Universe";
             command = new SqlCommand(query, DatabaseConnection.GetConnection());
             reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            Universe.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {

                Universe.Items.Add(reader["name"].ToString());


            }

            reader.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(Name.Text!=null && Gender.SelectedItem!=null && Region.SelectedItem!=null && Description.Text!=null && Species.Text!= null && ReleaseDate.Value!=null && Quote.Text!=null && SplashArt.Text!=null ) {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddChampion", connection))
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
                        command.Parameters.AddWithValue("@stories_title", Story.Text);
                        command.Parameters.AddWithValue("@universe_name", Universe.Text);
                        


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Champion name already exists")
                                {
                                    MessageBox.Show("Champion name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                else if (result == "Success")
                                {
                                    MessageBox.Show("Champion Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AddChampion manageChampios_page = new AddChampion();
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
                    using (SqlCommand command = new SqlCommand("dbo.AddExistsOn", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@champion_name", Name.Text);
                        command.Parameters.AddWithValue("@universe_name", Universe.SelectedItem.ToString());


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column

                            }
                            reader.Close();
                        }

                    }
                    using (SqlCommand command = new SqlCommand("dbo.AddParticipates", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@champion_name", Name.Text);
                        command.Parameters.AddWithValue("@stories_title", Story.SelectedItem.ToString());


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column

                            }
                            reader.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page = new Admin();
            admin_page.Show();
            this.Hide();
        }
    }
}
