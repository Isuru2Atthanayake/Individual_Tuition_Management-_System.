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
    public partial class Student_instructions : Form
    {
        public Student_instructions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_Control_pannel mn = new Student_Control_pannel();
            mn.Show();
            this.Hide();
        }
    }
}
