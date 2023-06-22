namespace LoL_Forms
{
    partial class Champions
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxChampions = new System.Windows.Forms.ComboBox();
            this.searchChampName = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.champImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.champDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.champName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.champSpecies = new System.Windows.Forms.RichTextBox();
            this.champGender = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.champRegion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.champQuote = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.champRelease = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.QDesc = new System.Windows.Forms.RichTextBox();
            this.WDesc = new System.Windows.Forms.RichTextBox();
            this.EDesc = new System.Windows.Forms.RichTextBox();
            this.RDesc = new System.Windows.Forms.RichTextBox();
            this.PDesc = new System.Windows.Forms.RichTextBox();
            this.QName = new System.Windows.Forms.TextBox();
            this.WName = new System.Windows.Forms.TextBox();
            this.EName = new System.Windows.Forms.TextBox();
            this.RName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Noxus = new System.Windows.Forms.RadioButton();
            this.Bilgewater = new System.Windows.Forms.RadioButton();
            this.Piltover = new System.Windows.Forms.RadioButton();
            this.BandleCity = new System.Windows.Forms.RadioButton();
            this.Zaun = new System.Windows.Forms.RadioButton();
            this.Void = new System.Windows.Forms.RadioButton();
            this.Freljord = new System.Windows.Forms.RadioButton();
            this.ShadowIsles = new System.Windows.Forms.RadioButton();
            this.Targon = new System.Windows.Forms.RadioButton();
            this.Shurima = new System.Windows.Forms.RadioButton();
            this.Ixtal = new System.Windows.Forms.RadioButton();
            this.Ionia = new System.Windows.Forms.RadioButton();
            this.Demacia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.champImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChampions
            // 
            this.comboBoxChampions.FormattingEnabled = true;
            this.comboBoxChampions.Location = new System.Drawing.Point(528, 54);
            this.comboBoxChampions.Name = "comboBoxChampions";
            this.comboBoxChampions.Size = new System.Drawing.Size(121, 23);
            this.comboBoxChampions.TabIndex = 1;
            // 
            // searchChampName
            // 
            this.searchChampName.Location = new System.Drawing.Point(289, 53);
            this.searchChampName.Name = "searchChampName";
            this.searchChampName.Size = new System.Drawing.Size(100, 23);
            this.searchChampName.TabIndex = 2;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(717, 52);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 23);
            this.runButton.TabIndex = 5;
            this.runButton.Text = "Search";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // champImage
            // 
            this.champImage.Location = new System.Drawing.Point(702, 282);
            this.champImage.Name = "champImage";
            this.champImage.Size = new System.Drawing.Size(513, 305);
            this.champImage.TabIndex = 6;
            this.champImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type the name:";
            // 
            // champDescription
            // 
            this.champDescription.Location = new System.Drawing.Point(265, 150);
            this.champDescription.Name = "champDescription";
            this.champDescription.Size = new System.Drawing.Size(180, 31);
            this.champDescription.TabIndex = 9;
            this.champDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // champName
            // 
            this.champName.Location = new System.Drawing.Point(20, 154);
            this.champName.Name = "champName";
            this.champName.Size = new System.Drawing.Size(185, 25);
            this.champName.TabIndex = 11;
            this.champName.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(565, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Species";
            // 
            // champSpecies
            // 
            this.champSpecies.Location = new System.Drawing.Point(503, 148);
            this.champSpecies.Name = "champSpecies";
            this.champSpecies.Size = new System.Drawing.Size(159, 31);
            this.champSpecies.TabIndex = 14;
            this.champSpecies.Text = "";
            // 
            // champGender
            // 
            this.champGender.Location = new System.Drawing.Point(34, 224);
            this.champGender.Name = "champGender";
            this.champGender.Size = new System.Drawing.Size(148, 31);
            this.champGender.TabIndex = 15;
            this.champGender.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Gender";
            // 
            // champRegion
            // 
            this.champRegion.Location = new System.Drawing.Point(289, 225);
            this.champRegion.Name = "champRegion";
            this.champRegion.Size = new System.Drawing.Size(134, 30);
            this.champRegion.TabIndex = 17;
            this.champRegion.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Region";
            // 
            // champQuote
            // 
            this.champQuote.Location = new System.Drawing.Point(727, 162);
            this.champQuote.Name = "champQuote";
            this.champQuote.Size = new System.Drawing.Size(194, 73);
            this.champQuote.TabIndex = 19;
            this.champQuote.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(805, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Quote";
            // 
            // champRelease
            // 
            this.champRelease.Location = new System.Drawing.Point(517, 235);
            this.champRelease.Name = "champRelease";
            this.champRelease.Size = new System.Drawing.Size(145, 30);
            this.champRelease.TabIndex = 21;
            this.champRelease.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(565, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Release Date";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(855, 51);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 23);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Reset Fields";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // QDesc
            // 
            this.QDesc.Location = new System.Drawing.Point(20, 348);
            this.QDesc.Name = "QDesc";
            this.QDesc.Size = new System.Drawing.Size(139, 84);
            this.QDesc.TabIndex = 57;
            this.QDesc.Text = "";
            // 
            // WDesc
            // 
            this.WDesc.Location = new System.Drawing.Point(194, 348);
            this.WDesc.Name = "WDesc";
            this.WDesc.Size = new System.Drawing.Size(139, 84);
            this.WDesc.TabIndex = 58;
            this.WDesc.Text = "";
            // 
            // EDesc
            // 
            this.EDesc.Location = new System.Drawing.Point(368, 348);
            this.EDesc.Name = "EDesc";
            this.EDesc.Size = new System.Drawing.Size(139, 84);
            this.EDesc.TabIndex = 59;
            this.EDesc.Text = "";
            // 
            // RDesc
            // 
            this.RDesc.Location = new System.Drawing.Point(540, 348);
            this.RDesc.Name = "RDesc";
            this.RDesc.Size = new System.Drawing.Size(139, 84);
            this.RDesc.TabIndex = 60;
            this.RDesc.Text = "";
            // 
            // PDesc
            // 
            this.PDesc.Location = new System.Drawing.Point(252, 491);
            this.PDesc.Name = "PDesc";
            this.PDesc.Size = new System.Drawing.Size(224, 96);
            this.PDesc.TabIndex = 61;
            this.PDesc.Text = "";
            // 
            // QName
            // 
            this.QName.Location = new System.Drawing.Point(37, 319);
            this.QName.Name = "QName";
            this.QName.Size = new System.Drawing.Size(100, 23);
            this.QName.TabIndex = 62;
            // 
            // WName
            // 
            this.WName.Location = new System.Drawing.Point(217, 319);
            this.WName.Name = "WName";
            this.WName.Size = new System.Drawing.Size(100, 23);
            this.WName.TabIndex = 63;
            // 
            // EName
            // 
            this.EName.Location = new System.Drawing.Point(392, 319);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(100, 23);
            this.EName.TabIndex = 64;
            // 
            // RName
            // 
            this.RName.Location = new System.Drawing.Point(562, 319);
            this.RName.Name = "RName";
            this.RName.Size = new System.Drawing.Size(100, 23);
            this.RName.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(334, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 25);
            this.label11.TabIndex = 66;
            this.label11.Text = "Abilities";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(77, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 15);
            this.label12.TabIndex = 67;
            this.label12.Text = "Q";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(607, 301);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 68;
            this.label13.Text = "R";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(351, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 15);
            this.label14.TabIndex = 69;
            this.label14.Text = "Passive";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(432, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 70;
            this.label15.Text = "E";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 15);
            this.label16.TabIndex = 71;
            this.label16.Text = "W";
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(323, 462);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(100, 23);
            this.PName.TabIndex = 72;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Noxus);
            this.groupBox1.Controls.Add(this.Bilgewater);
            this.groupBox1.Controls.Add(this.Piltover);
            this.groupBox1.Controls.Add(this.BandleCity);
            this.groupBox1.Controls.Add(this.Zaun);
            this.groupBox1.Controls.Add(this.Void);
            this.groupBox1.Controls.Add(this.Freljord);
            this.groupBox1.Controls.Add(this.ShadowIsles);
            this.groupBox1.Controls.Add(this.Targon);
            this.groupBox1.Controls.Add(this.Shurima);
            this.groupBox1.Controls.Add(this.Ixtal);
            this.groupBox1.Controls.Add(this.Ionia);
            this.groupBox1.Controls.Add(this.Demacia);
            this.groupBox1.Location = new System.Drawing.Point(1006, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 170);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region";
            // 
            // Noxus
            // 
            this.Noxus.AutoSize = true;
            this.Noxus.Location = new System.Drawing.Point(106, 117);
            this.Noxus.Name = "Noxus";
            this.Noxus.Size = new System.Drawing.Size(59, 19);
            this.Noxus.TabIndex = 14;
            this.Noxus.TabStop = true;
            this.Noxus.Text = "Noxus";
            this.Noxus.UseVisualStyleBackColor = true;
            this.Noxus.CheckedChanged += new System.EventHandler(this.Noxus_CheckedChanged);
            // 
            // Bilgewater
            // 
            this.Bilgewater.AutoSize = true;
            this.Bilgewater.Location = new System.Drawing.Point(106, 101);
            this.Bilgewater.Name = "Bilgewater";
            this.Bilgewater.Size = new System.Drawing.Size(80, 19);
            this.Bilgewater.TabIndex = 1;
            this.Bilgewater.TabStop = true;
            this.Bilgewater.Text = "Bilgewater";
            this.Bilgewater.UseVisualStyleBackColor = true;
            this.Bilgewater.CheckedChanged += new System.EventHandler(this.Bilgewater_CheckedChanged);
            // 
            // Piltover
            // 
            this.Piltover.AutoSize = true;
            this.Piltover.Location = new System.Drawing.Point(106, 22);
            this.Piltover.Name = "Piltover";
            this.Piltover.Size = new System.Drawing.Size(65, 19);
            this.Piltover.TabIndex = 13;
            this.Piltover.TabStop = true;
            this.Piltover.Text = "Piltover";
            this.Piltover.UseVisualStyleBackColor = true;
            this.Piltover.CheckedChanged += new System.EventHandler(this.Piltover_CheckedChanged);
            // 
            // BandleCity
            // 
            this.BandleCity.AutoSize = true;
            this.BandleCity.Location = new System.Drawing.Point(106, 63);
            this.BandleCity.Name = "BandleCity";
            this.BandleCity.Size = new System.Drawing.Size(85, 19);
            this.BandleCity.TabIndex = 0;
            this.BandleCity.TabStop = true;
            this.BandleCity.Text = "Bandle City";
            this.BandleCity.UseVisualStyleBackColor = true;
            this.BandleCity.CheckedChanged += new System.EventHandler(this.BandleCity_CheckedChanged);
            // 
            // Zaun
            // 
            this.Zaun.AutoSize = true;
            this.Zaun.Location = new System.Drawing.Point(6, 117);
            this.Zaun.Name = "Zaun";
            this.Zaun.Size = new System.Drawing.Size(52, 19);
            this.Zaun.TabIndex = 11;
            this.Zaun.TabStop = true;
            this.Zaun.Text = "Zaun";
            this.Zaun.UseVisualStyleBackColor = true;
            this.Zaun.CheckedChanged += new System.EventHandler(this.Zaun_CheckedChanged);
            // 
            // Void
            // 
            this.Void.AutoSize = true;
            this.Void.Location = new System.Drawing.Point(6, 101);
            this.Void.Name = "Void";
            this.Void.Size = new System.Drawing.Size(70, 19);
            this.Void.TabIndex = 10;
            this.Void.TabStop = true;
            this.Void.Text = "The Void";
            this.Void.UseVisualStyleBackColor = true;
            this.Void.CheckedChanged += new System.EventHandler(this.Void_CheckedChanged);
            // 
            // Freljord
            // 
            this.Freljord.AutoSize = true;
            this.Freljord.Location = new System.Drawing.Point(6, 63);
            this.Freljord.Name = "Freljord";
            this.Freljord.Size = new System.Drawing.Size(65, 19);
            this.Freljord.TabIndex = 9;
            this.Freljord.TabStop = true;
            this.Freljord.Text = "Freljord";
            this.Freljord.UseVisualStyleBackColor = true;
            this.Freljord.CheckedChanged += new System.EventHandler(this.Freljord_CheckedChanged);
            // 
            // ShadowIsles
            // 
            this.ShadowIsles.AutoSize = true;
            this.ShadowIsles.Location = new System.Drawing.Point(6, 137);
            this.ShadowIsles.Name = "ShadowIsles";
            this.ShadowIsles.Size = new System.Drawing.Size(92, 19);
            this.ShadowIsles.TabIndex = 6;
            this.ShadowIsles.TabStop = true;
            this.ShadowIsles.Text = "Shadow Isles";
            this.ShadowIsles.UseVisualStyleBackColor = true;
            this.ShadowIsles.CheckedChanged += new System.EventHandler(this.ShadowIsles_CheckedChanged);
            // 
            // Targon
            // 
            this.Targon.AutoSize = true;
            this.Targon.Location = new System.Drawing.Point(6, 44);
            this.Targon.Name = "Targon";
            this.Targon.Size = new System.Drawing.Size(61, 19);
            this.Targon.TabIndex = 8;
            this.Targon.TabStop = true;
            this.Targon.Text = "Targon";
            this.Targon.UseVisualStyleBackColor = true;
            this.Targon.CheckedChanged += new System.EventHandler(this.Targon_CheckedChanged);
            // 
            // Shurima
            // 
            this.Shurima.AutoSize = true;
            this.Shurima.Location = new System.Drawing.Point(106, 44);
            this.Shurima.Name = "Shurima";
            this.Shurima.Size = new System.Drawing.Size(69, 19);
            this.Shurima.TabIndex = 7;
            this.Shurima.TabStop = true;
            this.Shurima.Text = "Shurima";
            this.Shurima.UseVisualStyleBackColor = true;
            this.Shurima.CheckedChanged += new System.EventHandler(this.Shurima_CheckedChanged);
            // 
            // Ixtal
            // 
            this.Ixtal.AutoSize = true;
            this.Ixtal.Location = new System.Drawing.Point(6, 83);
            this.Ixtal.Name = "Ixtal";
            this.Ixtal.Size = new System.Drawing.Size(47, 19);
            this.Ixtal.TabIndex = 3;
            this.Ixtal.TabStop = true;
            this.Ixtal.Text = "Ixtal";
            this.Ixtal.UseVisualStyleBackColor = true;
            this.Ixtal.CheckedChanged += new System.EventHandler(this.Ixtal_CheckedChanged);
            // 
            // Ionia
            // 
            this.Ionia.AutoSize = true;
            this.Ionia.Location = new System.Drawing.Point(106, 83);
            this.Ionia.Name = "Ionia";
            this.Ionia.Size = new System.Drawing.Size(51, 19);
            this.Ionia.TabIndex = 2;
            this.Ionia.TabStop = true;
            this.Ionia.Text = "Ionia";
            this.Ionia.UseVisualStyleBackColor = true;
            this.Ionia.CheckedChanged += new System.EventHandler(this.Ionia_CheckedChanged);
            // 
            // Demacia
            // 
            this.Demacia.AutoSize = true;
            this.Demacia.Location = new System.Drawing.Point(6, 22);
            this.Demacia.Name = "Demacia";
            this.Demacia.Size = new System.Drawing.Size(71, 19);
            this.Demacia.TabIndex = 1;
            this.Demacia.TabStop = true;
            this.Demacia.Text = "Demacia";
            this.Demacia.UseVisualStyleBackColor = true;
            this.Demacia.CheckedChanged += new System.EventHandler(this.Demacia_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Female);
            this.groupBox2.Controls.Add(this.Male);
            this.groupBox2.Location = new System.Drawing.Point(1006, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(106, 22);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(63, 19);
            this.Female.TabIndex = 1;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(16, 20);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(51, 19);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Champion Info";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(1074, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 21);
            this.label17.TabIndex = 77;
            this.label17.Text = "Filters";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(412, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 21);
            this.label18.TabIndex = 78;
            this.label18.Text = "Or select it:";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(18, 15);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 79;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Champions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 599);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.RName);
            this.Controls.Add(this.EName);
            this.Controls.Add(this.WName);
            this.Controls.Add(this.QName);
            this.Controls.Add(this.PDesc);
            this.Controls.Add(this.RDesc);
            this.Controls.Add(this.EDesc);
            this.Controls.Add(this.WDesc);
            this.Controls.Add(this.QDesc);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.champRelease);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.champQuote);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.champRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.champGender);
            this.Controls.Add(this.champSpecies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.champName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.champDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.champImage);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.searchChampName);
            this.Controls.Add(this.comboBoxChampions);
            this.Name = "Champions";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.champImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox comboBoxChampions;
        private TextBox searchChampName;
        private Button runButton;
        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox champImage;
        private Label label3;
        private RichTextBox champDescription;
        private Label label4;
        private Label label6;
        private Label label5;
        private RichTextBox champName;
        private RichTextBox champGender;
        private RichTextBox champSpecies;
        private Label label7;
        private Label label8;
        private RichTextBox champRegion;
        private Label label9;
        private RichTextBox champQuote;
        private Label label10;
        private RichTextBox champRelease;
        private Button resetButton;
        private RichTextBox EDesc;
        private RichTextBox WDesc;
        private RichTextBox QDesc;
        private RichTextBox RDesc;
        private RichTextBox PDesc;
        private TextBox QName;
        private Label label11;
        private TextBox RName;
        private TextBox EName;
        private TextBox WName;
        private TextBox PName;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton Bilgewater;       
        private RadioButton Piltover;
        private RadioButton BandleCity;
        private RadioButton Zaun;
        private RadioButton Void;
        private RadioButton Freljord;
        private RadioButton ShadowIsles;
        private RadioButton Targon;
        private RadioButton Shurima;
        private RadioButton Ixtal;
        private RadioButton Ionia;
        private RadioButton Demacia;
        private RadioButton Female;
        private RadioButton Male;
        private RadioButton Noxus;
        private Label label1;
        private Label label17;
        private Label label18;
        private Button Back;
    }
}