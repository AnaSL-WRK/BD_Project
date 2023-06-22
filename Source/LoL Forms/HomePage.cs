using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Champions_Click(object sender, EventArgs e)
        {
            Champions champ_page = new Champions();
            champ_page.Show();
            this.Hide();
        }

        private void Regions_Click(object sender, EventArgs e)
        {
            Regions region_page = new Regions();
            region_page.Show();
            this.Hide();
        }

        private void Stories_Click(object sender, EventArgs e)
        {
            Stories stories_page = new Stories();
            stories_page.Show();
            this.Hide();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            Login login_page = new Login();
            login_page.Show();
            this.Hide();
        }

        private void Universes_Click(object sender, EventArgs e)
        {
            Universes universes_page = new Universes();
            universes_page.Show();
            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "ua.png");
            pictureBox1.Image = Properties.Resources.ua;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            ;
        }
    }
}
