using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DatabaseSystems_Project2
{
    public partial class Form_deleteLoans : Form
    {
        // this is the path of the database
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sethrb101\\OneDrive - The George Washington University\\Project2\\DatabaseSystems-Project2\\DatabaseSystems-Project2\\Library.mdf;Integrated Security=True");

        public Form_deleteLoans()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_bookID.Text != "" && textBox_userID.Text != "" && textBox_dateOut.Text != "")
            {
                //if (textBox_dateOut.Text instanceof Date)
                //{
                    SqlCommand cmd = new SqlCommand("DELETE FROM BookLoan WHERE BookLoan.bookID = @bookID AND BookLoan.userID = @userID AND BookLoan.dateOut = @dateOut;", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@bookID", textBox_bookID.Text);
                    cmd.Parameters.AddWithValue("@userID", textBox_userID.Text);
                    cmd.Parameters.AddWithValue("@dateOut", textBox_dateOut.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book loan record has been deleted.");
                //}
                //else
                //{
                //    MessageBox.Show("Incorrect formatting!");
                //}
            }
            else
            {
                MessageBox.Show("Please fill out all fields!");
            }
        }
    }
}
