using System;
using System.Collections;
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
    public partial class AddStory : Form
    {
        public AddStory()
        {
            InitializeComponent();
        }

        private void AddStory_Load(object sender, EventArgs e)
        {
            string query = "SELECT name FROM Alternate_Universe";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            Universe.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                Universe.Items.Add(reader["name"].ToString());
                

            }
            List<string> list = new List<string>();

            query = "Select name from Champion";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader["name"].ToString());
            }
            reader.Close();
            checkedListBox1.Items.AddRange(list.ToArray());

            
            


        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(Universe.SelectedItem!= null && Title.Text!=null && Author.Text!=null && Type.Text!= null && Link.Text!=null) {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.AddStory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@title", Title.Text);
                        command.Parameters.AddWithValue("@author", Author.Text);
                        command.Parameters.AddWithValue("@link", Link.Text);
                        command.Parameters.AddWithValue("@type", Type.Text);
                        command.Parameters.AddWithValue("@universe_name", Universe.SelectedItem.ToString());
                        



                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                 if (result == "Success")
                                {
                                    MessageBox.Show("Story added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AddStory manageChampios_page = new AddStory();
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
                    foreach (var item in checkedListBox1.CheckedItems)
                    {
                        using (SqlCommand command = new SqlCommand("dbo.AddParticipates", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@champion_name", item.ToString());
                            command.Parameters.AddWithValue("@stories_title", Title.Text);
                            

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
            }
            else
            {
                MessageBox.Show("Please fill out all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page = new Admin();
            admin_page.Show();
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Title.Text = null;
            Universe.SelectedItem = null;
            Author.Text = null;
            Type.Text = null;
            Link.Text = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
