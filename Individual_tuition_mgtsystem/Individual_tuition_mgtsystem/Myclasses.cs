using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Individual_tuition_mgtsystem.Properties;

namespace Individual_tuition_mgtsystem
{
    public partial class Myclasses : Form
    {
        public Myclasses()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home mn = new Home();
            mn.Show();
            this.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Settings.Default["date"] = tbd.Text;
            Settings.Default["place"] = tbp.Text;
            Settings.Default["time"] = tbs.Text;
            Settings.Default["subject"] = tbt.Text;
            Settings.Default.Save();

        }

        private void Myclasses_Load(object sender, EventArgs e)
        {
            tbd.Text = Settings.Default["date"].ToString();
            tbp.Text = Settings.Default["place"].ToString();
            tbs.Text = Settings.Default["time"].ToString();
            tbt.Text = Settings.Default["subject"].ToString();
        }
    }
}
