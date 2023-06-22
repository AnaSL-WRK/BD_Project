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

namespace LoL_Forms
{
    public partial class ManageStories : Form
    {
        public ManageStories()
        {
            InitializeComponent();
        }

        private void ManageStories_Load(object sender, EventArgs e)
        {
            string query = "SELECT title FROM Stories";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();

            // Clear existing items in the dropdown (if any)
            comboBoxStories.Items.Clear();

            // Add retrieved champion names to the dropdown
            while (reader.Read())
            {
                string storieName = reader["title"].ToString();
                comboBoxStories.Items.Add(storieName);

            }

            reader.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (comboBoxStories.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Please choose a story", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedStory = comboBoxStories.SelectedItem.ToString();
                string query = "SELECT author, link, type,universe_name FROM Stories WHERE title = @StoryName";
                SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
                command.Parameters.AddWithValue("@StoryName", selectedStory);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Title.Text = selectedStory;
                    Author.Text = reader["author"].ToString();
                    Type.Text = reader["type"].ToString();
                    UniverseName.Text = reader["universe_name"].ToString();
                    Link.Text = reader["link"].ToString();
                    Link.SelectAll();
                    Link.SelectionFont = new Font(Link.Font, FontStyle.Underline);
                    Link.SelectionColor = Color.Blue;

                }
                else
                {
                    MessageBox.Show("Story not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (comboBoxStories.SelectedItem!=null &&  Title.Text != null && Type.Text != null && UniverseName.Text!=null && Author.Text!=null && Link.Text !=null)
            {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateStory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@title", Title.Text);
                        command.Parameters.AddWithValue("@author", Author.Text);
                        command.Parameters.AddWithValue("@link", Link.Text);
                        command.Parameters.AddWithValue("@type", Type.Text);
                        command.Parameters.AddWithValue("@universe_name", UniverseName.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Success")
                                {
                                    MessageBox.Show("Story altered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ManageStories manageChampios_page = new ManageStories();
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
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(comboBoxStories.SelectedItem!= null)
            {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.DeleteStory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@StoryName", comboBoxStories.SelectedItem);
                        //command.Parameters.AddWithValue("@Password", Password.Text);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Story not found, rollbacking transaction.")
                                {
                                    MessageBox.Show("Story not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }
                                else if (result == "Success")
                                {
                                    MessageBox.Show("Story deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ManageStories manageChampios_page = new ManageStories();
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
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin_page = new Admin();
            admin_page.Show();
            this.Hide();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            comboBoxStories.SelectedItem= null;
            Title.Text = null;
            Author.Text = null;
            Link.Text = null;
            UniverseName.Text = null;
            Type.Text = null;  
        }
    }
}
