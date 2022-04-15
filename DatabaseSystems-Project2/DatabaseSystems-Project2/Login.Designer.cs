namespace DatabaseSystems_Project2
{
    partial class Form_login
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
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.linkLabel_stuRegister = new System.Windows.Forms.LinkLabel();
            this.linkLabel_facRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(208, 201);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(208, 71);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(162, 20);
            this.textBox_username.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(208, 122);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(162, 20);
            this.textBox_password.TabIndex = 2;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(114, 74);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(75, 13);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username (ID)";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(114, 125);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // linkLabel_stuRegister
            // 
            this.linkLabel_stuRegister.AutoSize = true;
            this.linkLabel_stuRegister.Location = new System.Drawing.Point(114, 167);
            this.linkLabel_stuRegister.Name = "linkLabel_stuRegister";
            this.linkLabel_stuRegister.Size = new System.Drawing.Size(127, 13);
            this.linkLabel_stuRegister.TabIndex = 5;
            this.linkLabel_stuRegister.TabStop = true;
            this.linkLabel_stuRegister.Text = "Create a student account";
            this.linkLabel_stuRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_stuRegister_LinkClicked);
            // 
            // linkLabel_facRegister
            // 
            this.linkLabel_facRegister.AutoSize = true;
            this.linkLabel_facRegister.Location = new System.Drawing.Point(247, 167);
            this.linkLabel_facRegister.Name = "linkLabel_facRegister";
            this.linkLabel_facRegister.Size = new System.Drawing.Size(123, 13);
            this.linkLabel_facRegister.TabIndex = 6;
            this.linkLabel_facRegister.TabStop = true;
            this.linkLabel_facRegister.Text = "Create a faculty account";
            this.linkLabel_facRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_facRegister_LinkClicked);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 293);
            this.Controls.Add(this.linkLabel_facRegister);
            this.Controls.Add(this.linkLabel_stuRegister);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.button_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.LinkLabel linkLabel_stuRegister;
        private System.Windows.Forms.LinkLabel linkLabel_facRegister;
    }
}

