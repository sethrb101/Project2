namespace DatabaseSystems_Project2
{
    partial class Form_facRegister
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
            this.textBox_deptID = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_deptID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_userPassword = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_deptID
            // 
            this.textBox_deptID.Location = new System.Drawing.Point(221, 190);
            this.textBox_deptID.Name = "textBox_deptID";
            this.textBox_deptID.Size = new System.Drawing.Size(146, 20);
            this.textBox_deptID.TabIndex = 23;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(221, 155);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(146, 20);
            this.textBox_name.TabIndex = 22;
            // 
            // label_deptID
            // 
            this.label_deptID.AutoSize = true;
            this.label_deptID.Location = new System.Drawing.Point(134, 193);
            this.label_deptID.Name = "label_deptID";
            this.label_deptID.Size = new System.Drawing.Size(44, 13);
            this.label_deptID.TabIndex = 21;
            this.label_deptID.Text = "Dept ID";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(134, 158);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Name";
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(397, 35);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 19;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(221, 120);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(146, 20);
            this.textBox_password.TabIndex = 18;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(221, 84);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(146, 20);
            this.textBox_username.TabIndex = 17;
            // 
            // label_userPassword
            // 
            this.label_userPassword.AutoSize = true;
            this.label_userPassword.Location = new System.Drawing.Point(134, 123);
            this.label_userPassword.Name = "label_userPassword";
            this.label_userPassword.Size = new System.Drawing.Size(53, 13);
            this.label_userPassword.TabIndex = 16;
            this.label_userPassword.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(134, 87);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(75, 13);
            this.label_username.TabIndex = 15;
            this.label_username.Text = "Username (ID)";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(221, 231);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 14;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form_facRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 308);
            this.Controls.Add(this.textBox_deptID);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_deptID);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_userPassword);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_submit);
            this.Name = "Form_facRegister";
            this.Text = "Faculty Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_deptID;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_deptID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_userPassword;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_submit;
    }
}