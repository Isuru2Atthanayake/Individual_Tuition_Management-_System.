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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnv_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Income";
            SqlDataAdapter s = new SqlDataAdapter(query, con);
            DataTable a = new DataTable();
            s.Fill(a);
            dgv2.DataSource = a;
            con.Close();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {

            con.Open();
            string sql = "insert into Income(Studentid,Fee,Date) values('" + tb1.Text + "','" + tb2.Text + "','" + dtp2.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("Inserted sucessfully");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "0";
           
            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                lbltotal.Text = Convert.ToString(double.Parse(lbltotal.Text) + double.Parse(dgv2.Rows[i].Cells[2].Value.ToString()));
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

     /*  private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(tb1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 30));

            e.Graphics.DrawString(label2.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 30));
         }
        */
        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawString(tb1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 100));
           // e.Graphics.DrawString(lbltotal.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(100, 40));
           // e.Graphics.DrawString(label6.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 10));




            e.Graphics.DrawString(lbl100.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 60));

         e.Graphics.DrawString(lbl101.Text, new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, new Point(250, 100));

            e.Graphics.DrawString(lbl102.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 140));
// id
          e.Graphics.DrawString(label2.Text, new Font("Trajan Pro", 14, FontStyle.Bold), Brushes.Black, new Point(100,260));
            e.Graphics.DrawString(tb1.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 270));
       
 e.Graphics.DrawString(label3.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(100, 320));
            e.Graphics.DrawString(dtp2.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 340));
//...............
            e.Graphics.DrawString(lblb.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(10, 420));
            e.Graphics.DrawString(lblb.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(10, 430));
            //...............

            //fee
            e.Graphics.DrawString(label1.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(100, 560));
            e.Graphics.DrawString(tb2.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 570));



            e.Graphics.DrawString(lblcash.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(100, 620));
            e.Graphics.DrawString(txtcash.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 630));

            //............./
            e.Graphics.DrawString(label4.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 670));
           


            e.Graphics.DrawString(lblche.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(100, 680));
            e.Graphics.DrawString(txtcheng.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 700));
//.......//
            e.Graphics.DrawString(label4.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 710));
          e.Graphics.DrawString(label4.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(400, 720));






            //         e.Graphics.DrawString(lblb.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(10, 610));
            //***
            e.Graphics.DrawString(lbl100.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 940));

            e.Graphics.DrawString(lblthank.Text, new Font("Trajan Pro", 12, FontStyle.Bold), Brushes.Black, new Point(300, 970));

            e.Graphics.DrawString(lbl100.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 1000));
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double a1, a2, at;
            a1 = double.Parse(tb2.Text);
            a2 = double.Parse(txtcash.Text);
            at = a2 - a1;
            txtcheng.Text = at.ToString();
        }

        private void lblthank_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         //   dgv2.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void dgv2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
