﻿namespace DatabaseSystems_Project2
{
    partial class Form_libraryPortal
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
            this.label_libraryPortal = new System.Windows.Forms.Label();
            this.button_checkOut = new System.Windows.Forms.Button();
            this.button_checkIn = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_libraryPortal
            // 
            this.label_libraryPortal.AutoSize = true;
            this.label_libraryPortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_libraryPortal.Location = new System.Drawing.Point(102, 28);
            this.label_libraryPortal.Name = "label_libraryPortal";
            this.label_libraryPortal.Size = new System.Drawing.Size(303, 37);
            this.label_libraryPortal.TabIndex = 0;
            this.label_libraryPortal.Text = "LIBRARY PORTAL";
            // 
            // button_checkOut
            // 
            this.button_checkOut.Location = new System.Drawing.Point(80, 103);
            this.button_checkOut.Name = "button_checkOut";
            this.button_checkOut.Size = new System.Drawing.Size(97, 23);
            this.button_checkOut.TabIndex = 1;
            this.button_checkOut.Text = "CHECK OUT";
            this.button_checkOut.UseVisualStyleBackColor = true;
            this.button_checkOut.Click += new System.EventHandler(this.button_checkOut_Click);
            // 
            // button_checkIn
            // 
            this.button_checkIn.Location = new System.Drawing.Point(80, 142);
            this.button_checkIn.Name = "button_checkIn";
            this.button_checkIn.Size = new System.Drawing.Size(97, 23);
            this.button_checkIn.TabIndex = 2;
            this.button_checkIn.Text = "CHECK IN";
            this.button_checkIn.UseVisualStyleBackColor = true;
            this.button_checkIn.Click += new System.EventHandler(this.button_checkIn_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(299, 103);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(141, 23);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "SEARCH BOOK LOANS";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(299, 142);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(141, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "DELETE BOOK LOANS";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_libraryPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_checkIn);
            this.Controls.Add(this.button_checkOut);
            this.Controls.Add(this.label_libraryPortal);
            this.Name = "Form_libraryPortal";
            this.Text = "Library Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_libraryPortal;
        private System.Windows.Forms.Button button_checkOut;
        private System.Windows.Forms.Button button_checkIn;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_delete;
    }
}