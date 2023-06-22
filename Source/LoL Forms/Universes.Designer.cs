namespace LoL_Forms
{
    partial class Universes
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
            this.Name = new System.Windows.Forms.RichTextBox();
            this.SkinLine = new System.Windows.Forms.RichTextBox();
            this.YearCreated = new System.Windows.Forms.RichTextBox();
            this.Champions = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUniverses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Art = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Art)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alternate Universes";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(89, 225);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(130, 24);
            this.Name.TabIndex = 1;
            this.Name.Text = "";
            // 
            // SkinLine
            // 
            this.SkinLine.Location = new System.Drawing.Point(340, 225);
            this.SkinLine.Name = "SkinLine";
            this.SkinLine.Size = new System.Drawing.Size(130, 24);
            this.SkinLine.TabIndex = 2;
            this.SkinLine.Text = "";
            // 
            // YearCreated
            // 
            this.YearCreated.Location = new System.Drawing.Point(599, 225);
            this.YearCreated.Name = "YearCreated";
            this.YearCreated.Size = new System.Drawing.Size(130, 24);
            this.YearCreated.TabIndex = 3;
            this.YearCreated.Text = "";
            // 
            // Champions
            // 
            this.Champions.Location = new System.Drawing.Point(89, 333);
            this.Champions.Name = "Champions";
            this.Champions.Size = new System.Drawing.Size(174, 75);
            this.Champions.TabIndex = 4;
            this.Champions.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Existing Champions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year Created";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Skin Line";
            // 
            // comboBoxUniverses
            // 
            this.comboBoxUniverses.FormattingEnabled = true;
            this.comboBoxUniverses.Location = new System.Drawing.Point(332, 110);
            this.comboBoxUniverses.Name = "comboBoxUniverses";
            this.comboBoxUniverses.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUniverses.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(201, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Name";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(520, 110);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 11;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Art
            // 
            this.Art.Location = new System.Drawing.Point(447, 308);
            this.Art.Name = "Art";
            this.Art.Size = new System.Drawing.Size(351, 140);
            this.Art.TabIndex = 12;
            this.Art.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Art";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Universes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Art);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxUniverses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Champions);
            this.Controls.Add(this.YearCreated);
            this.Controls.Add(this.SkinLine);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            //this.Name = "Universes";
            this.Text = "Universes";
            this.Load += new System.EventHandler(this.Universes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Art)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RichTextBox Name;
        private RichTextBox SkinLine;
        private RichTextBox YearCreated;
        private RichTextBox Champions;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxUniverses;
        private Label label6;
        private Button Search;
        private PictureBox Art;
        private Label label7;
        private Button Back;
    }
}