namespace DatabaseSystems_Project2
{
    partial class Form_updateFaculty
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
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_deptID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_deptIDLabel = new System.Windows.Forms.Label();
            this.label_nameLabel = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_usernameLabel = new System.Windows.Forms.Label();
            this.label_facultyinfo = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(335, 39);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 17;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_deptID
            // 
            this.textBox_deptID.Location = new System.Drawing.Point(205, 169);
            this.textBox_deptID.Name = "textBox_deptID";
            this.textBox_deptID.Size = new System.Drawing.Size(130, 20);
            this.textBox_deptID.TabIndex = 16;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(205, 127);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(130, 20);
            this.textBox_name.TabIndex = 15;
            // 
            // label_deptIDLabel
            // 
            this.label_deptIDLabel.AutoSize = true;
            this.label_deptIDLabel.Location = new System.Drawing.Point(98, 172);
            this.label_deptIDLabel.Name = "label_deptIDLabel";
            this.label_deptIDLabel.Size = new System.Drawing.Size(44, 13);
            this.label_deptIDLabel.TabIndex = 14;
            this.label_deptIDLabel.Text = "Dept ID";
            // 
            // label_nameLabel
            // 
            this.label_nameLabel.AutoSize = true;
            this.label_nameLabel.Location = new System.Drawing.Point(98, 130);
            this.label_nameLabel.Name = "label_nameLabel";
            this.label_nameLabel.Size = new System.Drawing.Size(35, 13);
            this.label_nameLabel.TabIndex = 13;
            this.label_nameLabel.Text = "Name";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(202, 94);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(35, 13);
            this.label_username.TabIndex = 12;
            this.label_username.Text = "label3";
            // 
            // label_usernameLabel
            // 
            this.label_usernameLabel.AutoSize = true;
            this.label_usernameLabel.Location = new System.Drawing.Point(98, 94);
            this.label_usernameLabel.Name = "label_usernameLabel";
            this.label_usernameLabel.Size = new System.Drawing.Size(75, 13);
            this.label_usernameLabel.TabIndex = 11;
            this.label_usernameLabel.Text = "Username (ID)";
            // 
            // label_facultyinfo
            // 
            this.label_facultyinfo.AutoSize = true;
            this.label_facultyinfo.Location = new System.Drawing.Point(51, 49);
            this.label_facultyinfo.Name = "label_facultyinfo";
            this.label_facultyinfo.Size = new System.Drawing.Size(96, 13);
            this.label_facultyinfo.TabIndex = 10;
            this.label_facultyinfo.Text = "Faculty Information";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(187, 217);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 9;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // Form_updateFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 284);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_deptID);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_deptIDLabel);
            this.Controls.Add(this.label_nameLabel);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_usernameLabel);
            this.Controls.Add(this.label_facultyinfo);
            this.Controls.Add(this.button_update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_updateFaculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Faculty Information";
            this.Load += new System.EventHandler(this.Form_updateFaculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_deptID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_deptIDLabel;
        private System.Windows.Forms.Label label_nameLabel;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_usernameLabel;
        private System.Windows.Forms.Label label_facultyinfo;
        private System.Windows.Forms.Button button_update;
    }
}