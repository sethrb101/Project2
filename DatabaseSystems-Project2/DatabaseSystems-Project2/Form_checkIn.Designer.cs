namespace DatabaseSystems_Project2
{
    partial class Form_checkIn
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
            this.textBox_dateIn = new System.Windows.Forms.TextBox();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.textBox_bookID = new System.Windows.Forms.TextBox();
            this.label_dateIn = new System.Windows.Forms.Label();
            this.label_userID = new System.Windows.Forms.Label();
            this.label_bookID = new System.Windows.Forms.Label();
            this.label_blpLabel = new System.Windows.Forms.Label();
            this.textBox_dateOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(194, 271);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 15;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // textBox_dateIn
            // 
            this.textBox_dateIn.Location = new System.Drawing.Point(194, 226);
            this.textBox_dateIn.Name = "textBox_dateIn";
            this.textBox_dateIn.Size = new System.Drawing.Size(138, 20);
            this.textBox_dateIn.TabIndex = 14;
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(194, 145);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(138, 20);
            this.textBox_userID.TabIndex = 13;
            // 
            // textBox_bookID
            // 
            this.textBox_bookID.Location = new System.Drawing.Point(194, 104);
            this.textBox_bookID.Name = "textBox_bookID";
            this.textBox_bookID.Size = new System.Drawing.Size(138, 20);
            this.textBox_bookID.TabIndex = 12;
            // 
            // label_dateIn
            // 
            this.label_dateIn.AutoSize = true;
            this.label_dateIn.Location = new System.Drawing.Point(135, 229);
            this.label_dateIn.Name = "label_dateIn";
            this.label_dateIn.Size = new System.Drawing.Size(42, 13);
            this.label_dateIn.TabIndex = 11;
            this.label_dateIn.Text = "Date In";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Location = new System.Drawing.Point(135, 148);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(43, 13);
            this.label_userID.TabIndex = 10;
            this.label_userID.Text = "User ID";
            // 
            // label_bookID
            // 
            this.label_bookID.AutoSize = true;
            this.label_bookID.Location = new System.Drawing.Point(135, 107);
            this.label_bookID.Name = "label_bookID";
            this.label_bookID.Size = new System.Drawing.Size(46, 13);
            this.label_bookID.TabIndex = 9;
            this.label_bookID.Text = "Book ID";
            // 
            // label_blpLabel
            // 
            this.label_blpLabel.AutoSize = true;
            this.label_blpLabel.Location = new System.Drawing.Point(201, 64);
            this.label_blpLabel.Name = "label_blpLabel";
            this.label_blpLabel.Size = new System.Drawing.Size(57, 13);
            this.label_blpLabel.TabIndex = 8;
            this.label_blpLabel.Text = "CHECK IN";
            // 
            // textBox_dateOut
            // 
            this.textBox_dateOut.Location = new System.Drawing.Point(194, 185);
            this.textBox_dateOut.Name = "textBox_dateOut";
            this.textBox_dateOut.Size = new System.Drawing.Size(138, 20);
            this.textBox_dateOut.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Date Out";
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(357, 24);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 18;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Form_checkIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 350);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dateOut);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.textBox_dateIn);
            this.Controls.Add(this.textBox_userID);
            this.Controls.Add(this.textBox_bookID);
            this.Controls.Add(this.label_dateIn);
            this.Controls.Add(this.label_userID);
            this.Controls.Add(this.label_bookID);
            this.Controls.Add(this.label_blpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_checkIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Form_checkIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox textBox_dateIn;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.TextBox textBox_bookID;
        private System.Windows.Forms.Label label_dateIn;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label_bookID;
        private System.Windows.Forms.Label label_blpLabel;
        private System.Windows.Forms.TextBox textBox_dateOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_return;
    }
}