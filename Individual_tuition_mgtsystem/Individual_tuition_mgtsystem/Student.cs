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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
      
        private void btnsearch_Click(object sender, EventArgs e)
        {


            /*search mn = new search();
            mn.Show();
            this.Hide();*/
            SqlConnection c = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");
            c.Open();
            String ei = tbsearch.Text;

            ////////////////////////////////////////////////////////////////
            //    Image im = pictureBox1.Image;
            ///////////////////////////////////////////////////////////////
            string query = "select * from Income where studentID  = '" + ei + "'";
            SqlDataAdapter s = new SqlDataAdapter(query, c);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            c.Close();

            {
               /* lblstdid.Text = r.GetString(1);
                lblfee.Text = r.GetString(2);
                lbldate.Text = r.GetString(3);
               


                //    pictureBox1.Image = r.GetString(5);
                lblno.Text = "user found";


                this.btnsearch.ForeColor = Color.Green;
                btnclear.Text = "Clear student details (Ese/End)";


                this.lblstdid.ForeColor = Color.Green;
                this.lblfee.ForeColor = Color.Green;
                this.lbldate.ForeColor = Color.Green;
               







                this.lblno.ForeColor = Color.Green;*/
            }

            //else
            {

                /*lblstdid.Text = "";
                lblfee.Text = "";
                lbldate.Text = "";
            

                lblno.Text = "user found";






                lblno.Text = "no user found";
                this.lblno.ForeColor = Color.Red;
                this.btnclear.ForeColor = Color.Red;
                btnclear.Text = "search new student (Ese/End)";
                //   this.lblno.BackColor = Color.Red;*/
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
          
            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }
    }
}
