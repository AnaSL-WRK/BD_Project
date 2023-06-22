using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace LoL_Forms
{
    public partial class ManageRegion : Form
    {
        public ManageRegion()
        {
            InitializeComponent();
        }

        private void ManageRegion_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT name FROM Region";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxRegions.Items.Add(reader["name"].ToString());
            }

            reader.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(comboBoxRegions.SelectedItem!=null)
            {
                string query = $"SELECT emblem FROM Region WHERE NAME = '{comboBoxRegions.SelectedItem.ToString()}' ";
                SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    //Name.Text = comboBoxRegions.SelectedItem.ToString();
                    EmblemLink.Text = reader["emblem"].ToString();
                }
                reader.Close();
                
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(EmblemLink.Text!= null ) {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.UpdateRegion", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@name", comboBoxRegions.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@emblem", EmblemLink.Text);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                 if (result == "Success")
                                {
                                    MessageBox.Show("Region altered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ManageRegion manageChampios_page = new ManageRegion();
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
    }
}
