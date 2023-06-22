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
    public partial class Regions : Form
    {
        public Regions()
        {
            InitializeComponent();
        }

        private void Regions_Load(object sender, EventArgs e)
        {
            string query = $"SELECT emblem, name FROM Region";
            using (SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["name"].ToString();
                        if (name == "Bandle City")
                        {
                            BandleCity.ImageLocation = reader["emblem"].ToString();
                            BandleCity.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Bilgewater")
                        {
                            Bilgewater.ImageLocation = reader["emblem"].ToString();
                            Bilgewater.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Demacia")
                        {
                            Demacia.ImageLocation = reader["emblem"].ToString();
                            Demacia.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Ionia")
                        {
                            Ionia.ImageLocation = reader["emblem"].ToString();
                            Ionia.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Ixtal")
                        {
                            Ixtal.ImageLocation = reader["emblem"].ToString();
                            Ixtal.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Piltover")
                        {
                            Piltover.ImageLocation = reader["emblem"].ToString();
                            Piltover.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Noxus")
                        {
                            Noxus.ImageLocation = reader["emblem"].ToString();
                            Noxus.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Shadow Isles")
                        {
                            ShadowIsles.ImageLocation = reader["emblem"].ToString();
                            ShadowIsles.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Shurima")
                        {
                            Shurima.ImageLocation = reader["emblem"].ToString();
                            Shurima.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Targon")
                        {
                            Targon.ImageLocation = reader["emblem"].ToString();
                            Targon.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Freljord")
                        {
                            Freljord.ImageLocation = reader["emblem"].ToString();
                            Freljord.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "The Void")
                        {
                            Void.ImageLocation = reader["emblem"].ToString();
                            Void.SizeMode = PictureBoxSizeMode.StretchImage;
                        }

                        else if (name == "Zaun")
                        {
                            Zaun.ImageLocation = reader["emblem"].ToString();
                            Zaun.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }

                }

            }
            


        }


        private void Bilgewater_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Bilgewater");
            region.Show();
            this.Hide();
        }

        private void Demacia_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Demacia");
            region.Show();
            this.Hide();
        }

        private void Ionia_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Ionia");
            region.Show();
            this.Hide();
        }

        private void Ixtal_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Ixtal");
            region.Show();
            this.Hide();
        }

        private void Piltover_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Piltover");
            region.Show();
            this.Hide();
        }

        private void Noxus_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Noxus");
            region.Show();
            this.Hide();
        }

        private void Targon_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Targon");
            region.Show();
            this.Hide();
        }

        private void Freljord_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Freljord");
            region.Show();
            this.Hide();
        }

        private void Void_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("The Void");
            region.Show();
            this.Hide();
        }

        private void Zaun_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Zaun");
            region.Show();
            this.Hide();
        }

        private void Shurima_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Shurima");
            region.Show();
            this.Hide();
        }

        private void BandleCity_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Bandle City");
            this.Hide();
            region.Show();
            
        }

        private void ShadowIsles_Click(object sender, EventArgs e)
        {
            Selected_Region region = new Selected_Region("Shadow Isles");
            region.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }
    }
}
