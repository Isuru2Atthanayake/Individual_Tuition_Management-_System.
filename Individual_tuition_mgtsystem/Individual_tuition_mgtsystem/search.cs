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

namespace Individual_tuition_mgtsystem
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            String ei = tbsearch.Text;

////////////////////////////////////////////////////////////////
        //    Image im = pictureBox1.Image;
///////////////////////////////////////////////////////////////
            string query = "select * from Registration where studentID  = '" + ei + "'";
            SqlCommand com = new SqlCommand(query, c);
            SqlDataReader r = com.ExecuteReader();
            if (r.Read())

            {
                lblstd.Text = r.GetString(1);
                lblname.Text = r.GetString(2);
                lblsub.Text = r.GetString(3);
                lblcontact.Text = r.GetString(4);
                lbldate.Text = r.GetString(5);
               

            //    pictureBox1.Image = r.GetString(5);
                lblno.Text = "user found" ;


                this.btnok.ForeColor = Color.Green;
                btnok.Text = "Clear student details (Ese/End)";
               

                this.lblstd.ForeColor = Color.Green;
                this.lblname.ForeColor = Color.Green;
                this.lblsub.ForeColor = Color.Green;
                this.lbldate.ForeColor = Color.Green;
                this.lblcontact.ForeColor = Color.Green;








                this.lblno.ForeColor = Color.Green;
            }

            else
            {

                lblstd.Text = "";
                lblname.Text = "";
                lblsub.Text = "";
                lbldate.Text = "";
                lblcontact.Text ="";

                lblno.Text = "user found";






                lblno.Text = "no user found";
               this.lblno.ForeColor = Color.Red;
                this.btnok.ForeColor = Color.Red;
                btnok.Text = "search new student (Ese/End)";
             //   this.lblno.BackColor = Color.Red;
            
            }

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbsearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { btnsearch.PerformClick(); }
               else
             
               if  (e.KeyCode == Keys.Escape)
                   { btnok.PerformClick(); }
            else

               if (e.KeyCode == Keys.End)
            { btnok.PerformClick(); }


        }

        private void btnok_Click(object sender, EventArgs e)
        {
            tbsearch.Text = "";
            lblstd.Text = "";
            lblname.Text = "";
            lblsub.Text = "";
            lbldate.Text = "";
            lblcontact.Text = "";
            lblno.Text = "";
            tbsearch.Focus();
        }

        private void btnok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                tbsearch.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
