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
    }
}
