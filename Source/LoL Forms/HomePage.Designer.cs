namespace LoL_Forms
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Champions = new System.Windows.Forms.Button();
            this.Regions = new System.Windows.Forms.Button();
            this.Stories = new System.Windows.Forms.Button();
            this.AdminLogin = new System.Windows.Forms.Button();
            this.Universes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Champions
            // 
            this.Champions.Location = new System.Drawing.Point(580, 93);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(152, 30);
            this.Champions.TabIndex = 0;
            this.Champions.Text = "Champions";
            this.Champions.UseVisualStyleBackColor = true;
            this.Champions.Click += new System.EventHandler(this.Champions_Click);
            // 
            // Regions
            // 
            this.Regions.Location = new System.Drawing.Point(580, 156);
            this.Regions.Name = "Regions";
            this.Regions.Size = new System.Drawing.Size(152, 30);
            this.Regions.TabIndex = 1;
            this.Regions.Text = "Regions";
            this.Regions.UseVisualStyleBackColor = true;
            this.Regions.Click += new System.EventHandler(this.Regions_Click);
            // 
            // Stories
            // 
            this.Stories.Location = new System.Drawing.Point(580, 219);
            this.Stories.Name = "Stories";
            this.Stories.Size = new System.Drawing.Size(152, 29);
            this.Stories.TabIndex = 2;
            this.Stories.Text = "Stories";
            this.Stories.UseVisualStyleBackColor = true;
            this.Stories.Click += new System.EventHandler(this.Stories_Click);
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(580, 335);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(152, 29);
            this.AdminLogin.TabIndex = 3;
            this.AdminLogin.Text = "Admin Login";
            this.AdminLogin.UseVisualStyleBackColor = true;
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // Universes
            // 
            this.Universes.Location = new System.Drawing.Point(580, 273);
            this.Universes.Name = "Universes";
            this.Universes.Size = new System.Drawing.Size(152, 29);
            this.Universes.TabIndex = 4;
            this.Universes.Text = "Alternate Universes";
            this.Universes.UseVisualStyleBackColor = true;
            this.Universes.Click += new System.EventHandler(this.Universes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "LEAGUE OF LEGENDS DATABASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desenvolvido por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Guilherme Lopes 93393";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(65, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ana Loureiro 104063";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 80);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Universes);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.Stories);
            this.Controls.Add(this.Regions);
            this.Controls.Add(this.Champions);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Champions;
        private Button Regions;
        private Button Stories;
        private Button AdminLogin;
        private Button Universes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}