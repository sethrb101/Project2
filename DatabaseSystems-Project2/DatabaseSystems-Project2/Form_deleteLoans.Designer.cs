namespace DatabaseSystems_Project2
{
    partial class Form_deleteLoans
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bookID = new System.Windows.Forms.TextBox();
            this.textBox_userID = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_dateOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username (ID)";
            // 
            // textBox_bookID
            // 
            this.textBox_bookID.Location = new System.Drawing.Point(216, 81);
            this.textBox_bookID.Name = "textBox_bookID";
            this.textBox_bookID.Size = new System.Drawing.Size(159, 20);
            this.textBox_bookID.TabIndex = 2;
            // 
            // textBox_userID
            // 
            this.textBox_userID.Location = new System.Drawing.Point(216, 116);
            this.textBox_userID.Name = "textBox_userID";
            this.textBox_userID.Size = new System.Drawing.Size(159, 20);
            this.textBox_userID.TabIndex = 3;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(216, 204);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DELETE BOOK LOANS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Out";
            // 
            // textBox_dateOut
            // 
            this.textBox_dateOut.Location = new System.Drawing.Point(216, 150);
            this.textBox_dateOut.Name = "textBox_dateOut";
            this.textBox_dateOut.Size = new System.Drawing.Size(159, 20);
            this.textBox_dateOut.TabIndex = 7;
            // 
            // Form_deleteLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 287);
            this.Controls.Add(this.textBox_dateOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_userID);
            this.Controls.Add(this.textBox_bookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_deleteLoans";
            this.Text = "Delete Book Loans";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bookID;
        private System.Windows.Forms.TextBox textBox_userID;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_dateOut;
    }
}