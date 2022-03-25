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
    public partial class Attendance : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");
        public Attendance()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {

            con.Open();
            string sql = "insert into Stda(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','"+txtsub.Text+"','"+tbname.Text+"','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnv1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stda";
            SqlDataAdapter s = new SqlDataAdapter(query,con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btnr2_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Stdb(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','" + txtsub.Text + "','" + tbname.Text+"','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnv2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stdb";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btnr6_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Stdf(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','" + txtsub.Text + "','" + tbname.Text + "','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            Income mn = new Income();
            mn.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            tbsid.Text = "";
            txtsub.Text = "";
            tbname.Text = "";
            tbfee.Text = "";

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void tbsid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            tbname.Focus();
        }

        private void tbname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               txtsub.Focus();
        }

        private void dtp1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void tbfee_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
              tbfee.Focus();
        }

        private void txtsub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsub_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               tbfee.Focus();
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnv3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stdc";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btnr3_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Stdc(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','" + txtsub.Text + "','" + tbname.Text + "','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnv4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stdd";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btnr4_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Stdd(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','" + txtsub.Text + "','" + tbname.Text + "','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnv5_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "select * from Stde";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btnr5_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Stde(Studentid,Subject,Name,Date,Fee) values('" + tbsid.Text + "','" + txtsub.Text + "','" + tbname.Text + "','" + dtp1.Text + "','" + tbfee.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnv6_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stdf";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            con.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            int i ;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stda where id =" + i + "";
            com.ExecuteNonQuery();
           con.Close();
            fill();
            MessageBox.Show("Deleted Sucessfully");


        }

        public void fill6()
        {

            string query = "select * from Stdf";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }
        public void fill5()
        {

            string query = "select * from Stde";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }
        public void fill4()
        {

            string query = "select * from Stdd";
            SqlDataAdapter s = new SqlDataAdapter(query,con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }
        public void fill2()
        {

            string query = "select * from Stdc";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }


        public void fill1()
        {

            string query = "select * from Stdb";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;

        }

        public void fill()
        {
           
            string query = "select * from Stda";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv1.DataSource = a;
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stda set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();

            fill();
            con.Close();

            MessageBox.Show("Updated Successfully");

        }

        private void del2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stdb where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill1();
            MessageBox.Show("Deleted Sucessfully");
        }

        private void del3_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stdc where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill2();
            MessageBox.Show("Deleted Sucessfully");
        }

        private void btnup2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stdc set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();

            fill2();
            con.Close();

            MessageBox.Show("Updated Successfully");

        }

        private void btnup1_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stdb set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();
            
            fill1();
            con.Close();

            MessageBox.Show("Updated Successfully");
        }

        private void Del4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stdd where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill4();
            MessageBox.Show("Deleted Sucessfully");

        }

        private void btnup3_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stdd set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();

            fill4();
            con.Close();

            MessageBox.Show("Updated Successfully");
        }

        private void Del5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stde where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill5();
            MessageBox.Show("Deleted Sucessfully");
        }

        private void btnup5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stde set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();

            fill5();
            con.Close();

            MessageBox.Show("Updated Successfully");
         }

        private void Del6_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
         (dgv1.SelectedCells[0].Value.ToString());
            SqlCommand com = con.CreateCommand();
            con.Open();
            com.CommandType = CommandType.Text;
            com.CommandText = "delete from Stdf where id =" + i + "";
            com.ExecuteNonQuery();
            con.Close();
            fill6();
            MessageBox.Show("Deleted Sucessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32
            (dgv1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "update Stdf set Studentid='" + tbsid.Text + "',Name='" + tbname.Text + "', Subject='" + txtsub.Text + "',Date='" + dtp1.Text + "',Fee='" + tbfee.Text + "'where id= " + i + "";
            com.ExecuteNonQuery();

            fill6();
            con.Close();

            MessageBox.Show("Updated Successfully");
        }
    }
}