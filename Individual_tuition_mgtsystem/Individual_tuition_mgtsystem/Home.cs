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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnatnd_Click(object sender, EventArgs e)
        {


            Attendance mn = new Attendance();
            mn.Show();
            this.Hide();
        }

        private void btnfee_Click(object sender, EventArgs e)
        {
            Income mn = new Income();
            mn.Show();
            this.Hide();
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            Registration mn = new Registration();
            mn.Show();
            this.Hide();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            Income mn = new Income();
            mn.Show();
            this.Hide();
        }

        private void btnclz_Click(object sender, EventArgs e)
        {
            Myclasses mn = new Myclasses();
            mn.Show();
            this.Hide();
        }

        private void btnser_Click(object sender, EventArgs e)
        {
            search mn = new search();
            mn.Show();
            this.Hide();
        }

        private void btnstdcontrol_Click(object sender, EventArgs e)
        {

            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Instructions mn = new Instructions();
            mn.Show();
            this.Hide();
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            welcome mn = new welcome();
            mn.Show();
            this.Hide();
        }
    }
}
