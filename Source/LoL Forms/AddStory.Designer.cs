namespace LoL_Forms
{
    partial class AddStory
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
            this.Link = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Universe = new System.Windows.Forms.ComboBox();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(621, 478);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 31);
            this.Save.TabIndex = 114;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(409, 478);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(81, 31);
            this.Reset.TabIndex = 113;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(711, 296);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(275, 42);
            this.Link.TabIndex = 112;
            this.Link.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "Universe Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 109;
            this.label6.Text = "Type";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(491, 156);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(148, 26);
            this.Type.TabIndex = 108;
            this.Type.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(824, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 107;
            this.label5.Text = "Link";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(726, 157);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(202, 33);
            this.Author.TabIndex = 106;
            this.Author.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 105;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(809, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Author";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(178, 156);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(212, 42);
            this.Title.TabIndex = 103;
            this.Title.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(508, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 115;
            this.label1.Text = "Add Story";
            // 
            // Universe
            // 
            this.Universe.FormattingEnabled = true;
            this.Universe.Location = new System.Drawing.Point(449, 315);
            this.Universe.Name = "Universe";
            this.Universe.Size = new System.Drawing.Size(171, 23);
            this.Universe.TabIndex = 116;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 117;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 119;
            this.label2.Text = "Participating champions";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(159, 314);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 166);
            this.checkedListBox1.TabIndex = 0;
            // 
            // AddStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 622);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Universe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Title);
            this.Name = "AddStory";
            this.Text = "AddStory";
            this.Load += new System.EventHandler(this.AddStory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private Button Reset;
        private RichTextBox Link;
        private Label label7;
        private Label label6;
        private RichTextBox Type;
        private Label label5;
        private RichTextBox Author;
        private Label label4;
        private Label label3;
        private RichTextBox Title;
        private Label label1;
        private ComboBox Universe;
        private Button Back;
        private Label label2;
        private CheckedListBox checkedListBox1;
    }
}