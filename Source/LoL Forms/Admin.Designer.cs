namespace LoL_Forms
{
    partial class Admin
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewAdmin = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.AddChamp = new System.Windows.Forms.Button();
            this.ManageChamps = new System.Windows.Forms.Button();
            this.ManageRegions = new System.Windows.Forms.Button();
            this.ManageStories = new System.Windows.Forms.Button();
            this.ManageUniverses = new System.Windows.Forms.Button();
            this.AddStory = new System.Windows.Forms.Button();
            this.AddUniverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(322, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Page";
            // 
            // NewAdmin
            // 
            this.NewAdmin.Location = new System.Drawing.Point(136, 96);
            this.NewAdmin.Name = "NewAdmin";
            this.NewAdmin.Size = new System.Drawing.Size(153, 35);
            this.NewAdmin.TabIndex = 1;
            this.NewAdmin.Text = "Create new Admin";
            this.NewAdmin.UseVisualStyleBackColor = true;
            this.NewAdmin.Click += new System.EventHandler(this.NewAdmin_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddChamp
            // 
            this.AddChamp.Location = new System.Drawing.Point(136, 173);
            this.AddChamp.Name = "AddChamp";
            this.AddChamp.Size = new System.Drawing.Size(153, 35);
            this.AddChamp.TabIndex = 3;
            this.AddChamp.Text = "Add new Champion";
            this.AddChamp.UseVisualStyleBackColor = true;
            this.AddChamp.Click += new System.EventHandler(this.AddChamp_Click);
            // 
            // ManageChamps
            // 
            this.ManageChamps.Location = new System.Drawing.Point(136, 251);
            this.ManageChamps.Name = "ManageChamps";
            this.ManageChamps.Size = new System.Drawing.Size(153, 35);
            this.ManageChamps.TabIndex = 4;
            this.ManageChamps.Text = "Manage Champions";
            this.ManageChamps.UseVisualStyleBackColor = true;
            this.ManageChamps.Click += new System.EventHandler(this.DeleteChamp_Click);
            // 
            // ManageRegions
            // 
            this.ManageRegions.Location = new System.Drawing.Point(136, 318);
            this.ManageRegions.Name = "ManageRegions";
            this.ManageRegions.Size = new System.Drawing.Size(153, 35);
            this.ManageRegions.TabIndex = 5;
            this.ManageRegions.Text = "Manage Regions";
            this.ManageRegions.UseVisualStyleBackColor = true;
            this.ManageRegions.Click += new System.EventHandler(this.DeleteRegion_Click);
            // 
            // ManageStories
            // 
            this.ManageStories.Location = new System.Drawing.Point(466, 96);
            this.ManageStories.Name = "ManageStories";
            this.ManageStories.Size = new System.Drawing.Size(153, 35);
            this.ManageStories.TabIndex = 6;
            this.ManageStories.Text = "Manage Stories";
            this.ManageStories.UseVisualStyleBackColor = true;
            this.ManageStories.Click += new System.EventHandler(this.ManageStories_Click);
            // 
            // ManageUniverses
            // 
            this.ManageUniverses.Location = new System.Drawing.Point(466, 318);
            this.ManageUniverses.Name = "ManageUniverses";
            this.ManageUniverses.Size = new System.Drawing.Size(153, 35);
            this.ManageUniverses.TabIndex = 7;
            this.ManageUniverses.Text = "Manage Universes";
            this.ManageUniverses.UseVisualStyleBackColor = true;
            this.ManageUniverses.Click += new System.EventHandler(this.ManageUniverses_Click);
            // 
            // AddStory
            // 
            this.AddStory.Location = new System.Drawing.Point(466, 173);
            this.AddStory.Name = "AddStory";
            this.AddStory.Size = new System.Drawing.Size(153, 35);
            this.AddStory.TabIndex = 8;
            this.AddStory.Text = "Add new Story";
            this.AddStory.UseVisualStyleBackColor = true;
            this.AddStory.Click += new System.EventHandler(this.AddStory_Click);
            // 
            // AddUniverse
            // 
            this.AddUniverse.Location = new System.Drawing.Point(466, 251);
            this.AddUniverse.Name = "AddUniverse";
            this.AddUniverse.Size = new System.Drawing.Size(153, 35);
            this.AddUniverse.TabIndex = 9;
            this.AddUniverse.Text = "Add Universe";
            this.AddUniverse.UseVisualStyleBackColor = true;
            this.AddUniverse.Click += new System.EventHandler(this.AddUniverse_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddUniverse);
            this.Controls.Add(this.AddStory);
            this.Controls.Add(this.ManageUniverses);
            this.Controls.Add(this.ManageStories);
            this.Controls.Add(this.ManageRegions);
            this.Controls.Add(this.ManageChamps);
            this.Controls.Add(this.AddChamp);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NewAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button NewAdmin;
        private Button Back;
        private Button AddChamp;
        private Button ManageChamps;
        private Button ManageRegions;
        private Button ManageStories;
        private Button ManageUniverses;
        private Button AddStory;
        private Button AddUniverse;
    }
}