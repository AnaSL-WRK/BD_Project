namespace LoL_Forms
{
    partial class ManageStories
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
            this.Back = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.RichTextBox();
            this.UniverseName = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.RichTextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 98;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(531, 465);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(96, 31);
            this.Reset.TabIndex = 97;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Link
            // 
            this.Link.Location = new System.Drawing.Point(862, 288);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(275, 42);
            this.Link.TabIndex = 96;
            this.Link.Text = "";
            // 
            // UniverseName
            // 
            this.UniverseName.Location = new System.Drawing.Point(580, 293);
            this.UniverseName.Name = "UniverseName";
            this.UniverseName.Size = new System.Drawing.Size(190, 37);
            this.UniverseName.TabIndex = 95;
            this.UniverseName.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(643, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 94;
            this.label7.Text = "Universe Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 93;
            this.label6.Text = "Type";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(728, 147);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(148, 26);
            this.Type.TabIndex = 92;
            this.Type.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(998, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Link";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(935, 154);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(202, 33);
            this.Author.TabIndex = 90;
            this.Author.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 89;
            this.label4.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 88;
            this.label3.Text = "Author";
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(466, 153);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(212, 42);
            this.Title.TabIndex = 87;
            this.Title.Text = "";
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(193, 218);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(104, 23);
            this.Edit.TabIndex = 86;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(176, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Select Story";
            // 
            // comboBoxStories
            // 
            this.comboBoxStories.FormattingEnabled = true;
            this.comboBoxStories.Location = new System.Drawing.Point(167, 176);
            this.comboBoxStories.Name = "comboBoxStories";
            this.comboBoxStories.Size = new System.Drawing.Size(173, 23);
            this.comboBoxStories.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(546, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 83;
            this.label1.Text = "Manage Stories";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(193, 258);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(104, 23);
            this.Delete.TabIndex = 101;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(700, 465);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 31);
            this.Save.TabIndex = 102;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ManageStories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 618);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Delete);
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
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStories);
            this.Controls.Add(this.label1);
            this.Name = "ManageStories";
            this.Text = "ManageStories";
            this.Load += new System.EventHandler(this.ManageStories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Back;
        private Button Reset;
        private RichTextBox Link;
        private RichTextBox UniverseName;
        private Label label7;
        private Label label6;
        private RichTextBox Type;
        private Label label5;
        private RichTextBox Author;
        private Label label4;
        private Label label3;
        private RichTextBox Title;
        private Button Edit;
        private Label label2;
        private ComboBox comboBoxStories;
        private Label label1;
        private Button Delete;
        private Button Save;
    }
}