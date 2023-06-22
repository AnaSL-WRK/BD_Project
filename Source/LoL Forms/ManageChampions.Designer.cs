namespace LoL_Forms
{
    partial class ManageChampions
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
            this.comboBoxChampions = new System.Windows.Forms.ComboBox();
            this.searchChampName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.RichTextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Species = new System.Windows.Forms.RichTextBox();
            this.SplashArt = new System.Windows.Forms.RichTextBox();
            this.Quote = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.Region = new System.Windows.Forms.ComboBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RName = new System.Windows.Forms.TextBox();
            this.EName = new System.Windows.Forms.TextBox();
            this.WName = new System.Windows.Forms.TextBox();
            this.QName = new System.Windows.Forms.TextBox();
            this.PDesc = new System.Windows.Forms.RichTextBox();
            this.RDesc = new System.Windows.Forms.RichTextBox();
            this.EDesc = new System.Windows.Forms.RichTextBox();
            this.WDesc = new System.Windows.Forms.RichTextBox();
            this.QDesc = new System.Windows.Forms.RichTextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(488, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Champions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxChampions
            // 
            this.comboBoxChampions.FormattingEnabled = true;
            this.comboBoxChampions.Location = new System.Drawing.Point(12, 198);
            this.comboBoxChampions.Name = "comboBoxChampions";
            this.comboBoxChampions.Size = new System.Drawing.Size(136, 23);
            this.comboBoxChampions.TabIndex = 1;
            // 
            // searchChampName
            // 
            this.searchChampName.Location = new System.Drawing.Point(12, 135);
            this.searchChampName.Name = "searchChampName";
            this.searchChampName.Size = new System.Drawing.Size(136, 23);
            this.searchChampName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type the name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Or select it";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(32, 250);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(89, 33);
            this.Edit.TabIndex = 5;
            this.Edit.Text = "Edit Info";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(32, 305);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(89, 33);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click_1);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(397, 133);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(122, 25);
            this.Name.TabIndex = 7;
            this.Name.Text = "";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(605, 135);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(123, 25);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            // 
            // Species
            // 
            this.Species.Location = new System.Drawing.Point(703, 254);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(134, 25);
            this.Species.TabIndex = 10;
            this.Species.Text = "";
            // 
            // SplashArt
            // 
            this.SplashArt.Location = new System.Drawing.Point(529, 357);
            this.SplashArt.Name = "SplashArt";
            this.SplashArt.Size = new System.Drawing.Size(140, 33);
            this.SplashArt.TabIndex = 11;
            this.SplashArt.Text = "";
            // 
            // Quote
            // 
            this.Quote.Location = new System.Drawing.Point(540, 242);
            this.Quote.Name = "Quote";
            this.Quote.Size = new System.Drawing.Size(122, 41);
            this.Quote.TabIndex = 12;
            this.Quote.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Species";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Release Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Quote";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(551, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Splash Art Link";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Location = new System.Drawing.Point(285, 367);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(167, 23);
            this.ReleaseDate.TabIndex = 35;
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(716, 364);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(121, 23);
            this.Region.TabIndex = 36;
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(999, 385);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(100, 23);
            this.PName.TabIndex = 88;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1134, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 87;
            this.label16.Text = "W";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(956, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 86;
            this.label15.Text = "E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1027, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 85;
            this.label14.Text = "Passive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1143, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "R";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(949, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 83;
            this.label12.Text = "Q";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1017, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 25);
            this.label17.TabIndex = 82;
            this.label17.Text = "Abilities";
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(1098, 225);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(100, 23);
            this.RName.TabIndex = 81;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(916, 221);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 23);
            this.EName.TabIndex = 80;
            // 
            // WName
            // 
            this.WName.Location = new System.Drawing.Point(1099, 70);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(100, 23);
            this.WName.TabIndex = 79;
            // 
            // QName
            // 
            this.QName.Location = new System.Drawing.Point(909, 73);
            this.QName.Name = "QName";
            this.QName.Size = new System.Drawing.Size(100, 23);
            this.QName.TabIndex = 78;
            // 
            // PDesc
            // 
            this.PDesc.Location = new System.Drawing.Point(928, 414);
            this.PDesc.Name = "PDesc";
            this.PDesc.Size = new System.Drawing.Size(224, 96);
            this.PDesc.TabIndex = 77;
            this.PDesc.Text = "";
            // 
            // RDesc
            // 
            this.RDesc.Location = new System.Drawing.Point(1076, 254);
            this.RDesc.Name = "RDesc";
            this.RDesc.Size = new System.Drawing.Size(139, 84);
            this.RDesc.TabIndex = 76;
            this.RDesc.Text = "";
            // 
            // EDesc
            // 
            this.EDesc.Location = new System.Drawing.Point(892, 250);
            this.EDesc.Name = "EDesc";
            this.EDesc.Size = new System.Drawing.Size(139, 84);
            this.EDesc.TabIndex = 75;
            this.EDesc.Text = "";
            // 
            // WDesc
            // 
            this.WDesc.Location = new System.Drawing.Point(1076, 99);
            this.WDesc.Name = "WDesc";
            this.WDesc.Size = new System.Drawing.Size(139, 84);
            this.WDesc.TabIndex = 74;
            this.WDesc.Text = "";
            // 
            // QDesc
            // 
            this.QDesc.Location = new System.Drawing.Point(892, 102);
            this.QDesc.Name = "QDesc";
            this.QDesc.Size = new System.Drawing.Size(139, 84);
            this.QDesc.TabIndex = 73;
            this.QDesc.Text = "";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(525, 494);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 35);
            this.Save.TabIndex = 89;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(315, 242);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 23);
            this.Gender.TabIndex = 90;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 91;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // ManageChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 601);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.WName);
            this.Controls.Add(this.QName);
            this.Controls.Add(this.PDesc);
            this.Controls.Add(this.RDesc);
            this.Controls.Add(this.EDesc);
            this.Controls.Add(this.WDesc);
            this.Controls.Add(this.QDesc);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Quote);
            this.Controls.Add(this.SplashArt);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchChampName);
            this.Controls.Add(this.comboBoxChampions);
            this.Controls.Add(this.label1);
           // this.Name = "ManageChampions";
            this.Text = "DeleteChampion";
            this.Load += new System.EventHandler(this.ManageChampions_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxChampions;
        private TextBox searchChampName;
        private Label label2;
        private Label label3;
        private Button Edit;
        private Button Delete;
        private RichTextBox Name;
        private RichTextBox Description;
        private RichTextBox Species;
        private RichTextBox SplashArt;
        private RichTextBox Quote;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label13;
        private DateTimePicker ReleaseDate;
        private ComboBox Region;
        private TextBox PName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label9;
        private Label label12;
        private Label label17;
        private TextBox RName;
        private TextBox EName;
        private TextBox WName;
        private TextBox QName;
        private RichTextBox PDesc;
        private RichTextBox RDesc;
        private RichTextBox EDesc;
        private RichTextBox WDesc;
        private RichTextBox QDesc;
        private Button Save;
        private ComboBox Gender;
        private Button Back;
    }
}