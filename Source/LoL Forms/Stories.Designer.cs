namespace LoL_Forms
{
    partial class Stories
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
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UniverseName = new System.Windows.Forms.RichTextBox();
            this.Link = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Champion = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stories";
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(306, 75);
            this.comboBoxStories.Name = "comboBoxStories";
            this.comboBoxStories.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStories.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(506, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(49, 167);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(212, 42);
            this.Title.TabIndex = 4;
            this.Title.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Title";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(348, 167);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(202, 33);
            this.Author.TabIndex = 7;
            this.Author.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Link";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(624, 161);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(148, 48);
            this.Type.TabIndex = 10;
            this.Type.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Universe Name";
            // 
            // UniverseName
            // 
            this.UniverseName.Location = new System.Drawing.Point(358, 290);
            this.UniverseName.Name = "UniverseName";
            this.UniverseName.Size = new System.Drawing.Size(190, 37);
            this.UniverseName.TabIndex = 13;
            this.UniverseName.Text = "";
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(12, 290);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(275, 42);
            this.Link.TabIndex = 14;
            this.Link.Text = "";
            this.Link.TextChanged += new System.EventHandler(this.Link_TextChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(624, 75);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 16);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 80;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Champion
            // 
            this.Champion.Location = new System.Drawing.Point(611, 290);
            this.Champion.Name = "Champion";
            this.Champion.Size = new System.Drawing.Size(161, 35);
            this.Champion.TabIndex = 81;
            this.Champion.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(642, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Featured Champion";
            // 
            // Stories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Champion);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.UniverseName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.label1);
            this.Name = "Stories";
            this.Text = "Stories";
            this.Load += new System.EventHandler(this.Stories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBoxStories;
        private Label label2;
        private Button searchButton;
        private RichTextBox Title;
        private Label label3;
        private Label label4;
        private RichTextBox Author;
        private Label label5;
        private RichTextBox Type;
        private Label label6;
        private Label label7;
        private RichTextBox UniverseName;
        private RichTextBox Link;
        private Button Reset;
        private Button Back;
        private RichTextBox Champion;
        private Label label8;
    }
}