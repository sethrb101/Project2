namespace DatabaseSystems_Project2
{
    partial class Form_stuRegister
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
            this.button_submit = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_userPassword = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_return = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(201, 231);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 0;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(114, 87);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(75, 13);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username (ID)";
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Location = new System.Drawing.Point(114, 123);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(53, 13);
            this.label_userPassword.TabIndex = 2;
            this.label_userPassword.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(201, 84);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(146, 20);
            this.textBox_username.TabIndex = 5;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(201, 120);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(146, 20);
            this.textBox_password.TabIndex = 6;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(369, 23);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 9;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(114, 158);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Name";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(114, 193);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(29, 13);
            this.label_year.TabIndex = 11;
            this.label_year.Text = "Year";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(201, 155);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(146, 20);
            this.textBox_name.TabIndex = 12;
            // 
            // textBox_year
            // 
            this.textBox_year.Location = new System.Drawing.Point(201, 190);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(146, 20);
            this.textBox_year.TabIndex = 13;
            // 
            // Form_stuRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 307);
            this.Controls.Add(this.textBox_year);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_year);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_userPassword);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_stuRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_userPassword;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_year;
    }
}