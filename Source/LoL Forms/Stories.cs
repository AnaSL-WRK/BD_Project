using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class Stories : Form
    {
        public Stories()
        {
            InitializeComponent();
            // Set the form border style to FixedSingle
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // Disable the maximize button
            this.MaximizeBox = false;
            // Disable the minimize button
            //this.MinimizeBox = false;
        }

        private void Stories_Load(object sender, EventArgs e)
        {
            Title.ReadOnly = true;
            Author.ReadOnly = true;
            Type.ReadOnly = true;
            Link.ReadOnly = true;
            UniverseName.ReadOnly = true;
            Champion.ReadOnly = true;

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
            Link.LinkClicked += Link_LinkClicked;
            
        }

        private void Link_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process myProcess = new Process();
            // Open the link in the default browser
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = e.LinkText;
            myProcess.Start();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Champion.Text = null;
            if(comboBoxStories.SelectedItem.ToString() == null)
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

                query = "SELECT champion_name FROM Participates WHERE stories_title = @StoryName";
                command = new SqlCommand(query, DatabaseConnection.GetConnection());
                command.Parameters.AddWithValue("@StoryName", selectedStory);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Champion.AppendText(reader["champion_name"].ToString() + Environment.NewLine);
                }
                reader.Close();
            }
        }

        private void Link_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Title.Text = string.Empty;
            Author.Text = string.Empty;
            Type.Text = string.Empty;
            UniverseName.Text = string.Empty;
            Link.Text = string.Empty;
            comboBoxStories.SelectedItem= null;
            Champion.Text = string.Empty;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
