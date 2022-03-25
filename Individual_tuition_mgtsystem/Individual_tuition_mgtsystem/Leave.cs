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
    public partial class Leave : Form
    {
        public Leave()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                lblleave.Text = "Leave has placed";

            }
            else
                lblleave.Text = "";
        }

        private void btnsve_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Leave(StudentID,Name,Date,proceed) values('" + tb1.Text + "','" + tb2.Text + "','" + dtp1.Text + "','" + lblleave.Text + "')";
            SqlCommand com = new SqlCommand(sql,con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnview_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "select * from Leave";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }
        public void fill1()
        {

            string query = "select * from Leave";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Leave set StudentID='" + tb1.Text + "',Name='" + tb2.Text + "',Date='" + dtp1.Text + "', proceed='" + lblleave.Text + "' where id= " + i + "";
            com.ExecuteNonQuery();

            fill1();
            con.Close();

            MessageBox.Show("Updated Successfully");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Leave where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill1();
            MessageBox.Show("Deleted Sucessfully");

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }
    }
}
