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
    public partial class Student_Control_pannel : Form
    {
        public Student_Control_pannel()
        {
            InitializeComponent();
        }

        private void btnleave_Click(object sender, EventArgs e)
        {
            Leave mn = new Leave();
            mn.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Student mn = new Student();
            mn.Show();
            this.Hide();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            pay mn = new pay();
            mn.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            welcome mn = new welcome();
            mn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_instructions mn = new Student_instructions();
            mn.Show();
            this.Hide();
        }
    }
}
