namespace DatabaseSystems_Project2
{
    partial class Form_search
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
            this.button_search = new System.Windows.Forms.Button();
            this.label_sbl = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_bookLoans = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_max = new System.Windows.Forms.Button();
            this.button_min = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            this.button_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(583, 67);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(111, 23);
            this.button_search.TabIndex = 0;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_sbl
            // 
            this.label_sbl.AutoSize = true;
            this.label_sbl.Location = new System.Drawing.Point(322, 30);
            this.label_sbl.Name = "label_sbl";
            this.label_sbl.Size = new System.Drawing.Size(123, 13);
            this.label_sbl.TabIndex = 1;
            this.label_sbl.Text = "SEARCH BOOK LOANS";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(165, 69);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(390, 20);
            this.textBox_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username (ID)";
            // 
            // dataGridView_bookLoans
            // 
            this.dataGridView_bookLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bookLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookLoans.Location = new System.Drawing.Point(75, 121);
            this.dataGridView_bookLoans.Name = "dataGridView_bookLoans";
            this.dataGridView_bookLoans.Size = new System.Drawing.Size(619, 231);
            this.dataGridView_bookLoans.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fine Information";
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(78, 456);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(159, 40);
            this.button_max.TabIndex = 8;
            this.button_max.Text = "MAX";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(308, 456);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(159, 40);
            this.button_min.TabIndex = 9;
            this.button_min.Text = "MIN";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(535, 456);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(159, 40);
            this.button_avg.TabIndex = 10;
            this.button_avg.Text = "AVG";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(349, 578);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 11;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Form_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 626);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_bookLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_sbl);
            this.Controls.Add(this.button_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book Loans";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Label label_sbl;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_bookLoans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_avg;
        private System.Windows.Forms.Button button_return;
    }
}