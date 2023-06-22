namespace LoL_Forms
{
    partial class AddChampion
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
            this.Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Species = new System.Windows.Forms.TextBox();
            this.Region = new System.Windows.Forms.ComboBox();
            this.SplashArt = new System.Windows.Forms.TextBox();
            this.Quote = new System.Windows.Forms.RichTextBox();
            this.ReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.PName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
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
            this.Story = new System.Windows.Forms.ComboBox();
            this.Universe = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(507, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add new Champion";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(7, 112);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(148, 23);
            this.Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Species";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Splash Art Link";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(602, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Region";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Release Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(102, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quote";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(278, 112);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 23);
            this.Gender.TabIndex = 10;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(505, 182);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(213, 93);
            this.Description.TabIndex = 11;
            this.Description.Text = "";
            // 
            // Species
            // 
            this.Species.Location = new System.Drawing.Point(29, 217);
            this.Species.Name = "Species";
            this.Species.Size = new System.Drawing.Size(113, 23);
            this.Species.TabIndex = 12;
            this.Species.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Region
            // 
            this.Region.FormattingEnabled = true;
            this.Region.Location = new System.Drawing.Point(559, 112);
            this.Region.Name = "Region";
            this.Region.Size = new System.Drawing.Size(121, 23);
            this.Region.TabIndex = 13;
            // 
            // SplashArt
            // 
            this.SplashArt.Location = new System.Drawing.Point(434, 328);
            this.SplashArt.Name = "SplashArt";
            this.SplashArt.Size = new System.Drawing.Size(246, 23);
            this.SplashArt.TabIndex = 14;
            // 
            // Quote
            // 
            this.Quote.Location = new System.Drawing.Point(63, 311);
            this.Quote.Name = "Quote";
            this.Quote.Size = new System.Drawing.Size(181, 49);
            this.Quote.TabIndex = 15;
            this.Quote.Text = "";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Location = new System.Drawing.Point(199, 214);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(200, 23);
            this.ReleaseDate.TabIndex = 16;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(581, 560);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(176, 38);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(951, 398);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(100, 23);
            this.PName.TabIndex = 104;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1086, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 103;
            this.label16.Text = "W";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(908, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 102;
            this.label15.Text = "E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(979, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 101;
            this.label14.Text = "Passive";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1095, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 100;
            this.label10.Text = "R";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(901, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 99;
            this.label12.Text = "Q";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(969, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 25);
            this.label17.TabIndex = 98;
            this.label17.Text = "Abilities";
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(1050, 238);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(100, 23);
            this.RName.TabIndex = 97;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(868, 234);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 23);
            this.EName.TabIndex = 96;
            // 
            // WName
            // 
            this.WName.Location = new System.Drawing.Point(1051, 83);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(100, 23);
            this.WName.TabIndex = 95;
            // 
            // QName
            // 
            this.QName.Location = new System.Drawing.Point(861, 86);
            this.QName.Name = "QName";
            this.QName.Size = new System.Drawing.Size(100, 23);
            this.QName.TabIndex = 94;
            // 
            // PDesc
            // 
            this.PDesc.Location = new System.Drawing.Point(880, 427);
            this.PDesc.Name = "PDesc";
            this.PDesc.Size = new System.Drawing.Size(224, 96);
            this.PDesc.TabIndex = 93;
            this.PDesc.Text = "";
            // 
            // RDesc
            // 
            this.RDesc.Location = new System.Drawing.Point(1028, 267);
            this.RDesc.Name = "RDesc";
            this.RDesc.Size = new System.Drawing.Size(139, 84);
            this.RDesc.TabIndex = 92;
            this.RDesc.Text = "";
            // 
            // EDesc
            // 
            this.EDesc.Location = new System.Drawing.Point(844, 263);
            this.EDesc.Name = "EDesc";
            this.EDesc.Size = new System.Drawing.Size(139, 84);
            this.EDesc.TabIndex = 91;
            this.EDesc.Text = "";
            // 
            // WDesc
            // 
            this.WDesc.Location = new System.Drawing.Point(1028, 112);
            this.WDesc.Name = "WDesc";
            this.WDesc.Size = new System.Drawing.Size(139, 84);
            this.WDesc.TabIndex = 90;
            this.WDesc.Text = "";
            // 
            // QDesc
            // 
            this.QDesc.Location = new System.Drawing.Point(844, 115);
            this.QDesc.Name = "QDesc";
            this.QDesc.Size = new System.Drawing.Size(139, 84);
            this.QDesc.TabIndex = 89;
            this.QDesc.Text = "";
            // 
            // Story
            // 
            this.Story.FormattingEnabled = true;
            this.Story.Location = new System.Drawing.Point(82, 450);
            this.Story.Name = "Story";
            this.Story.Size = new System.Drawing.Size(217, 23);
            this.Story.TabIndex = 105;
            // 
            // Universe
            // 
            this.Universe.FormattingEnabled = true;
            this.Universe.Location = new System.Drawing.Point(505, 450);
            this.Universe.Name = "Universe";
            this.Universe.Size = new System.Drawing.Size(225, 23);
            this.Universe.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 15);
            this.label11.TabIndex = 107;
            this.label11.Text = "Story where it features";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 427);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 15);
            this.label13.TabIndex = 108;
            this.label13.Text = "Alternate Universe where it exists on";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 109;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddChampion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 619);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Universe);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Quote);
            this.Controls.Add(this.SplashArt);
            this.Controls.Add(this.Region);
            this.Controls.Add(this.Species);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            //this.Name = "AddChampion";
            this.Text = "AddChampion";
            this.Load += new System.EventHandler(this.AddChampion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox Gender;
        private RichTextBox Description;
        private TextBox Species;
        private ComboBox Region;
        private TextBox SplashArt;
        private RichTextBox Quote;
        private DateTimePicker ReleaseDate;
        private Button Add;
        private TextBox PName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label10;
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
        private ComboBox Story;
        private ComboBox Universe;
        private Label label11;
        private Label label13;
        private Button Back;
    }
}