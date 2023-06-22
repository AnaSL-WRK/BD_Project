namespace LoL_Forms
{
    partial class AddUniverse
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
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ArtLink = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SkinLine = new System.Windows.Forms.RichTextBox();
            this.YearCreated = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(570, 476);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 31);
            this.Save.TabIndex = 130;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(407, 476);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(104, 31);
            this.Reset.TabIndex = 129;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ArtLink
            // 
            this.ArtLink.Location = new System.Drawing.Point(595, 316);
            this.ArtLink.Name = "ArtLink";
            this.ArtLink.Size = new System.Drawing.Size(190, 37);
            this.ArtLink.TabIndex = 128;
            this.ArtLink.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 127;
            this.label7.Text = "Art Link";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 126;
            this.label6.Text = "Skin Line";
            // 
            // SkinLine
            // 
            this.SkinLine.Location = new System.Drawing.Point(459, 162);
            this.SkinLine.Name = "SkinLine";
            this.SkinLine.Size = new System.Drawing.Size(148, 26);
            this.SkinLine.TabIndex = 125;
            this.SkinLine.Text = "";
            // 
            // YearCreated
            // 
            this.YearCreated.Location = new System.Drawing.Point(670, 168);
            this.YearCreated.Name = "YearCreated";
            this.YearCreated.Size = new System.Drawing.Size(202, 33);
            this.YearCreated.TabIndex = 124;
            this.YearCreated.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 123;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(748, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 122;
            this.label3.Text = "Year Created";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(197, 168);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(212, 42);
            this.Name.TabIndex = 121;
            this.Name.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(458, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 120;
            this.label1.Text = "Add Universe";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 131;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(277, 280);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 148);
            this.checkedListBox1.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 133;
            this.label2.Text = "Existing champions";
            // 
            // AddUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 619);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ArtLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SkinLine);
            this.Controls.Add(this.YearCreated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            //this.Name = "dbo.AddExistsOn";
            this.Text = "AddUniverse";
            this.Load += new System.EventHandler(this.AddUniverse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private Button Reset;
        private RichTextBox ArtLink;
        private Label label7;
        private Label label6;
        private RichTextBox SkinLine;
        private RichTextBox YearCreated;
        private Label label4;
        private Label label3;
        private RichTextBox Name;
        private Label label1;
        private Button Back;
        private CheckedListBox checkedListBox1;
        private Label label2;
    }
}