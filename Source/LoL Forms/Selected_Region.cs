using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoL_Forms
{
    public partial class Selected_Region : Form
    {   
        private string region_name;
        public Selected_Region(String region)
        {
            
            InitializeComponent();
            region_name = region;
            //changeBackground(region_name);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Image")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Set the image layout to Zoom
                    DataGridViewImageCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                    if (cell != null)
                    {
                        cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].DataPropertyName == "Image")
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    // Set the image layout to Zoom
                    DataGridViewImageCell cell = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewImageCell;
                    if (cell != null)
                    {
                        cell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }
        }


        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void Selected_Region_Load(object sender, EventArgs e)
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
            dataGridView1.RowTemplate.Height = 100; // Set the desired height in pixels
            dataGridView2.RowTemplate.Height = 100; // Set the desired height in pixels
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DataBindingComplete += dataGridView1_DataBindingComplete;
            dataGridView2.DataBindingComplete += dataGridView2_DataBindingComplete;


            //dataGridView1.Columns["ImageColumn"].DefaultCellStyle.ImageLayout = DataGridViewImageCellLayout.Stretch;




            string query = $"SELECT emblem FROM Region WHERE NAME = '{region_name}' ";
            SqlCommand command = new SqlCommand(query, DatabaseConnection.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                name.Text = region_name;
                emblem.ImageLocation = reader["emblem"].ToString();
                emblem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            reader.Close();
            query = $"SELECT description,image,title FROM Secrets WHERE region_name = '{region_name}' ";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            reader = command.ExecuteReader();
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Title", typeof(string));
            dataTable1.Columns.Add("Description", typeof(string));
            dataTable1.Columns.Add("Image", typeof(Image));
            
            while (reader.Read())
            {
                //secret.Text = reader["description"].ToString();
                //SecretImage.ImageLocation = reader["image"].ToString();
                //SecretImage.SizeMode= PictureBoxSizeMode.StretchImage;

                string description = reader["description"].ToString();
                //string image = reader["image"].ToString();

                string title = reader["title"].ToString();

                Image image;

                try
                {
                    WebClient webClient = new WebClient();
                    byte[] imageBytes = webClient.DownloadData(reader["image"].ToString());

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    // Handle any errors while downloading or loading the image
                    image = null; // Set a default image or handle the error as needed
                }

                dataTable1.Rows.Add(title, description, image);
            }
            reader.Close();
            dataGridView1.DataSource = dataTable1;

            DataTable dataTable2 = new DataTable();
            dataTable2.Columns.Add("Name", typeof(string));
            dataTable2.Columns.Add("Description", typeof(string));
            dataTable2.Columns.Add("Image", typeof(Image));

            query = $"SELECT description,art,name FROM Tribes WHERE region_name = '{region_name}' ";
            command = new SqlCommand(query, DatabaseConnection.GetConnection());
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                //secret.Text = reader["description"].ToString();
                //SecretImage.ImageLocation = reader["image"].ToString();
                //SecretImage.SizeMode= PictureBoxSizeMode.StretchImage;

                string description = reader["description"].ToString();
                //string image = reader["image"].ToString();

                string name = reader["name"].ToString();

                Image image;

                try
                {
                    WebClient webClient = new WebClient();
                    byte[] imageBytes = webClient.DownloadData(reader["art"].ToString());

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    // Handle any errors while downloading or loading the image
                    image = null; // Set a default image or handle the error as needed
                }

                dataTable2.Rows.Add(name, description, image);
            }
            reader.Close();
            dataGridView2.DataSource = dataTable2;


        }

        

        private void Back_Click(object sender, EventArgs e)
        {
            Regions regions_page = new Regions();
            regions_page.Show();
            this.Hide();
        }
    }
}
