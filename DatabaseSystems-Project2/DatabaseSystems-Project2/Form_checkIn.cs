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
    public partial class Form_checkIn : Form
    {
        public Form_checkIn()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            // check if the username or password are empty
            if (textBox_bookID.Text == "" || textBox_userID.Text == "" || textBox_dateIn.Text == "")
            {
                //throw out a message if they are empty
                MessageBox.Show("Please fill out all fields!");
                return;
            }

            // try: catch the error in your code
            try
            {

                // connection string, it is the path/value used to find the database. It can be found in database properties.
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\sethrb101\OneDrive - The George Washington University\Project2\DatabaseSystems-Project2\DatabaseSystems-Project2\Library.mdf;Integrated Security=True";

                //create sql connection called "con", used to connect to Students database
                SqlConnection con = new SqlConnection(connectionString);

                // the sql command you want to execute in DBMS
                SqlCommand cmd = new SqlCommand("UPDATE BookLoan SET BookLoan.dateIn = @dateIn, BookLoan.fine = (0.50 * DATEDIFF(day, BookLoan.dateDue, @dateIn)) WHERE BookLoan.bookID = @bookID AND BookLoan.userID = @userID;", con);

                cmd.Parameters.AddWithValue("@bookID", textBox_bookID.Text);
                cmd.Parameters.AddWithValue("@userID", textBox_userID.Text);
                cmd.Parameters.AddWithValue("@dateIn", textBox_dateIn.Text);

                //open the connection to DB
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book is now checked in.");

                //return to login page
                this.Hide();
                Form_login f1 = new Form_login();
                f1.Show();

            }
            // catch trow out error message if there is an error
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show(ex.Message);
            }
            //====================================================================
        }

        private void Form_checkIn_Load(object sender, EventArgs e)
        {
            
        }
    }
}
