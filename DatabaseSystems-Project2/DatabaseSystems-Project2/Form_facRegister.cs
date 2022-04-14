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
    public partial class Form_facRegister : Form
    {
        public Form_facRegister()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            //==========================After clicking the "Login" button, your code will do following===================================


            // check if the username or password are empty
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                //throw out a message if they are empty
                MessageBox.Show("Please provide your information!");
                return;
            }
            if (!( textBox_username.Text.StartsWith("f")))
            {
                //throw out a message if username does not start with s or f
                MessageBox.Show("Please use an appropriate username! (start with 's' if student, start with 'f' if faculty)");
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
                SqlCommand cmd = new SqlCommand("INSERT INTO UserLogin VALUES (@username, @password); INSERT INTO Faculty VALUES (@username, @sname, @deptID);", con);

                //Assign values to variables. Give TextBox: username -> @username; TextBox: password-> @password

                cmd.Parameters.AddWithValue("@username", textBox_username.Text);
                cmd.Parameters.AddWithValue("@password", textBox_password.Text);
                cmd.Parameters.AddWithValue("@sname", textBox_name.Text);
                cmd.Parameters.AddWithValue("@deptID", textBox_deptID.Text);

                //open the connection to DB
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account successfully created!");

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
