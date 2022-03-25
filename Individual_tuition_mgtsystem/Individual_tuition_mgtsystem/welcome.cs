using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_tuition_mgtsystem
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void lblenter_Click(object sender, EventArgs e)
        {
            logint mn = new logint();
            mn.Show();
            this.Hide();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            logint mn = new logint();
            mn.Show();
            this.Hide();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {

            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructions mn = new Instructions();
            mn.Show();
            this.Hide();
        }
    }
}
