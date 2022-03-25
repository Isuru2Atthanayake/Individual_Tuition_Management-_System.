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
    public partial class pay : Form
    {
        public pay()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "insert into Income(Studentid,Fee,Date) values('" + tb1.Text + "','" + tb2.Text + "','" + dtp1.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }
    }
}
