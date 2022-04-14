namespace DatabaseSystems_Project2
{
    partial class Form_checkOut
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
            this.label_blpLabel = new System.Windows.Forms.Label();
            this.label_bookID = new System.Windows.Forms.Label();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_dateOut = new System.Windows.Forms.Label();
            this.textBox_bookID = new System.Windows.Forms.TextBox();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.textBox_dateOut = new System.Windows.Forms.TextBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_blpLabel
            // 
            this.label_blpLabel.AutoSize = true;
            this.label_blpLabel.Location = new System.Drawing.Point(161, 41);
            this.label_blpLabel.Name = "label_blpLabel";
            this.label_blpLabel.Size = new System.Drawing.Size(69, 13);
            this.label_blpLabel.TabIndex = 0;
            this.label_blpLabel.Text = "CHECK OUT";
            // 
            // label_bookID
            // 
            this.label_bookID.AutoSize = true;
            this.label_bookID.Location = new System.Drawing.Point(105, 83);
            this.label_bookID.Name = "label_bookID";
            this.label_bookID.Size = new System.Drawing.Size(46, 13);
            this.label_bookID.TabIndex = 1;
            this.label_bookID.Text = "Book ID";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Location = new System.Drawing.Point(105, 126);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(43, 13);
            this.label_userID.TabIndex = 2;
            this.label_userID.Text = "User ID";
            // 
            // label_dateOut
            // 
            this.label_dateOut.AutoSize = true;
            this.label_dateOut.Location = new System.Drawing.Point(105, 169);
            this.label_dateOut.Name = "label_dateOut";
            this.label_dateOut.Size = new System.Drawing.Size(50, 13);
            this.label_dateOut.TabIndex = 3;
            this.label_dateOut.Text = "Date Out";
            // 
            // textBox_bookID
            // 
            this.textBox_bookID.Location = new System.Drawing.Point(164, 80);
            this.textBox_bookID.Name = "textBox_bookID";
            this.textBox_bookID.Size = new System.Drawing.Size(138, 20);
            this.textBox_bookID.TabIndex = 4;
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(164, 123);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(138, 20);
            this.textBox_userID.TabIndex = 5;
            // 
            // textBox_dateOut
            // 
            this.textBox_dateOut.Location = new System.Drawing.Point(164, 166);
            this.textBox_dateOut.Name = "textBox_dateOut";
            this.textBox_dateOut.Size = new System.Drawing.Size(138, 20);
            this.textBox_dateOut.TabIndex = 6;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(164, 217);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 7;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // Form_checkOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 276);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_dateOut);
            this.Controls.Add(this.textBox_userID);
            this.Controls.Add(this.textBox_bookID);
            this.Controls.Add(this.label_dateOut);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.label_bookID);
            this.Controls.Add(this.label_blpLabel);
            this.Name = "Form_checkOut";
            this.Text = "Check Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_blpLabel;
        private System.Windows.Forms.Label label_bookID;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_dateOut;
        private System.Windows.Forms.TextBox textBox_bookID;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.TextBox textBox_dateOut;
        private System.Windows.Forms.Button button_submit;
    }
}