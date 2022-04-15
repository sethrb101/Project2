using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSystems_Project2
{
    public partial class Form_libraryPortal : Form
    {
        public Form_libraryPortal()
        {
            InitializeComponent();
        }

        private void button_checkOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTERING CHECK OUT");
            this.Hide();
            Form_checkOut co = new Form_checkOut();
            co.Show();
            return;
        }

        private void button_checkIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTERING CHECK IN");
            this.Hide();
            Form_checkIn ci = new Form_checkIn();
            ci.Show();
            return;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTERING SEARCH PORTAL");
            this.Hide();
            Form_search s = new Form_search();
            s.Show();
            return;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ENTERING DELETE PORTAL");
            this.Hide();
            Form_deleteLoans d = new Form_deleteLoans();
            d.Show();
            return;
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to return?", "Return", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //if yes, hide this form
                this.Hide();
                Form_login f1 = new Form_login();
                f1.Show();
            }
        }
    }
}
