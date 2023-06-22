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

namespace LoL_Forms
{
    public partial class CreateAdmin : Form
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Username.Text == null || Password.Text == null)
            {
                MessageBox.Show("Please enter both your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string result = null;
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.CreateAdmin", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Username", Username.Text);
                        command.Parameters.AddWithValue("@Password", Password.Text);


                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = reader.GetString(0); // Retrieve the result from the first column
                                if (result == "Success")
                                {
                                    MessageBox.Show("Admin created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Admin admin_page = new Admin();
                                    admin_page.Show();
                                    this.Hide();
                                }
                                else if(result == "Username already taken. Please choose another username.")
                                {
                                    MessageBox.Show("Username already taken. Please choose another username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
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

        private void CreateAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
