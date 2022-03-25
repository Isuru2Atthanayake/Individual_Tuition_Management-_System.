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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Isuru\\Desktop\\csharphome\\Individual_tuition_mgtsystem\\Individual_tuition_mgtsystem\\Individual.mdf;Integrated Security=True;Connect Timeout=30");

        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {

            con.Open();
            string sql = "insert into Registration(Studentid,Name,Place,Contact,Date) values('" + tbr.Text + "','" + tbn.Text + "','" +tba.Text + "','" + tbc.Text + "','" + dtp2.Text + "')";
            SqlCommand com = new SqlCommand(sql, con);
            MessageBox.Show("..................Inserted sucessfully...................");
            com.ExecuteNonQuery();
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
               tbn.Focus();
        }

        private void tbn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
           tba.Focus();
        }

        private void tba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            tbc.Focus();
        }

        private void tbc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dtp2.Focus();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG*", ValidateNames = true, Multiselect = false })

                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);

                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "jjj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
       }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {

        }*/
    }
    }

