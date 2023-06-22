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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void NewAdmin_Click(object sender, EventArgs e)
        {
            CreateAdmin createAdmin_page = new CreateAdmin();
            createAdmin_page.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            HomePage home_page = new HomePage();
            home_page.Show();
            this.Hide();
        }

        private void AddChamp_Click(object sender, EventArgs e)
        {
            AddChampion addchamp_page = new AddChampion();
            addchamp_page.Show();
            this.Hide();
        }

        private void DeleteChamp_Click(object sender, EventArgs e)
        {
            ManageChampions deletechamp_page = new ManageChampions();
            deletechamp_page.Show();
            this.Hide();
        }

        private void DeleteRegion_Click(object sender, EventArgs e)
        {
            ManageRegion deleteregion_page = new ManageRegion();
            deleteregion_page.Show();
            this.Hide();
        }

        private void ManageStories_Click(object sender, EventArgs e)
        {
            ManageStories managestories_page = new ManageStories();
            managestories_page.Show();
            this.Hide();
        }

        private void ManageUniverses_Click(object sender, EventArgs e)
        {
            ManageUniverse manageUniverse_page = new ManageUniverse();
            manageUniverse_page.Show();
            this.Hide();
        }

        private void AddStory_Click(object sender, EventArgs e)
        {
            AddStory addStory_page = new AddStory();
            addStory_page.Show();
            this.Hide();
        }

        private void AddUniverse_Click(object sender, EventArgs e)
        {
            AddUniverse addUniverse_page = new AddUniverse();
            addUniverse_page.Show();
            this.Hide();
        }
    }
}
