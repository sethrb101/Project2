namespace DatabaseSystems_Project2
{
    partial class Form_updateStudent
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
            this.button_update = new System.Windows.Forms.Button();
            this.label_studentinfo = new System.Windows.Forms.Label();
            this.label_usernameLabel = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_nameLabel = new System.Windows.Forms.Label();
            this.label_yearLabel = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.button_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(191, 211);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 0;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label_studentinfo
            // 
            this.label_studentinfo.AutoSize = true;
            this.label_studentinfo.Location = new System.Drawing.Point(55, 43);
            this.label_studentinfo.Name = "label_studentinfo";
            this.label_studentinfo.Size = new System.Drawing.Size(99, 13);
            this.label_studentinfo.TabIndex = 1;
            this.label_studentinfo.Text = "Student Information";
            // 
            // label_usernameLabel
            // 
            this.label_usernameLabel.AutoSize = true;
            this.label_usernameLabel.Location = new System.Drawing.Point(102, 88);
            this.label_usernameLabel.Name = "label_usernameLabel";
            this.label_usernameLabel.Size = new System.Drawing.Size(75, 13);
            this.label_usernameLabel.TabIndex = 2;
            this.label_usernameLabel.Text = "Username (ID)";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(206, 88);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(35, 13);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "label3";
            // 
            // label_nameLabel
            // 
            this.label_nameLabel.AutoSize = true;
            this.label_nameLabel.Location = new System.Drawing.Point(102, 124);
            this.label_nameLabel.Name = "label_nameLabel";
            this.label_nameLabel.Size = new System.Drawing.Size(35, 13);
            this.label_nameLabel.TabIndex = 4;
            this.label_nameLabel.Text = "Name";
            // 
            // label_yearLabel
            // 
            this.label_yearLabel.AutoSize = true;
            this.label_yearLabel.Location = new System.Drawing.Point(102, 166);
            this.label_yearLabel.Name = "label_yearLabel";
            this.label_yearLabel.Size = new System.Drawing.Size(29, 13);
            this.label_yearLabel.TabIndex = 5;
            this.label_yearLabel.Text = "Year";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(209, 121);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(130, 20);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(209, 163);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(130, 20);
            this.textBox_year.TabIndex = 7;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(332, 38);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 8;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Form_updateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 276);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_yearLabel);
            this.Controls.Add(this.label_nameLabel);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_usernameLabel);
            this.Controls.Add(this.label_studentinfo);
            this.Controls.Add(this.button_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_updateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Student Information";
            this.Load += new System.EventHandler(this.Form_updateStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_studentinfo;
        private System.Windows.Forms.Label label_usernameLabel;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_nameLabel;
        private System.Windows.Forms.Label label_yearLabel;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.Button button_return;
    }
}