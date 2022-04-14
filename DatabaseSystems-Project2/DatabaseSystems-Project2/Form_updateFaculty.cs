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
    public partial class Form_updateFaculty : Form
    {
        public Form_updateFaculty()
        {
            InitializeComponent();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            // connection string, it is the path/value used to find the database. It can be found in database properties.
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\sethrb101\OneDrive - The George Washington University\Project2\DatabaseSystems-Project2\DatabaseSystems-Project2\Library.mdf;Integrated Security=True";

            //create sql connection called "con", used to connect to Students database
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            // the sql command you want to execute in DBMS
            SqlCommand cmd = new SqlCommand("UPDATE Faculty SET Faculty.fname = @name, Faculty.deptID = @deptID WHERE Faculty.userID = @username;", con);

            cmd.Parameters.AddWithValue("@username", label_username.Text);
            cmd.Parameters.AddWithValue("@name", textBox_name.Text);
            cmd.Parameters.AddWithValue("@deptID", textBox_deptID.Text);

            //con.Open();

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information successfully updated!");
        }

        private void Form_updateFaculty_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\sethrb101\OneDrive - The George Washington University\Project2\DatabaseSystems-Project2\DatabaseSystems-Project2\Library.mdf;Integrated Security=True";
            //get the username from the Form_login
            string username = Form_login.username;
            SqlConnection con = new SqlConnection(connectionString);

            // the sql command you want to execute in DBMS
            SqlCommand cmd = new SqlCommand("SELECT * FROM Faculty WHERE Faculty.userID = @username", con);

            cmd.Parameters.AddWithValue("@username", username);
            //cmd.Parameters.AddWithValue("@saddress", textBox_saddr.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            label_username.Text = dt.Rows[0]["userID"].ToString();
            textBox_name.Text = dt.Rows[0]["fname"].ToString();
            textBox_deptID.Text = dt.Rows[0]["deptID"].ToString();
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
