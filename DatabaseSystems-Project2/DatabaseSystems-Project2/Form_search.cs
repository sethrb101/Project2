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
    public partial class Form_search : Form
    {
        // this is the path of the database
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\sethrb101\\OneDrive - The George Washington University\\Project2\\DatabaseSystems-Project2\\DatabaseSystems-Project2\\Library.mdf;Integrated Security=True");
        
        public Form_search()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            //
            if (textBox_username.Text == "")
            {
                MessageBox.Show("Please provide a user ID");
                return;
            }
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("EXEC userLoans @username = @userID;", con);
            cmd.Parameters.AddWithValue("@userID", textBox_username.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_bookLoans.DataSource = dt;
            con.Close();
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("EXEC bookFineMax;", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            // show query result
            MessageBox.Show("Maximum fine: $" + dt.Rows[0]["MAX_Fine"].ToString());
            con.Close();
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("EXEC bookFineMin;", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            // show query result
            MessageBox.Show("Minimum fine: $" + dt.Rows[0]["MIN_Fine"].ToString());
            con.Close();
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("EXEC bookFineAvg;", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            // show query result
            MessageBox.Show("Average fine: $" + dt.Rows[0]["AVG_Fine"].ToString());
            con.Close();
        }
    }
}
