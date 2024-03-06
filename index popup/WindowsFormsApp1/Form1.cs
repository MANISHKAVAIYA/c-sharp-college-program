using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form : Form
    {
        List<string> li = new List<string>()
        {
            "-- Select --",
            "India",
            "Bharat",
            "Hindustan",
        };
        public form()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_Load_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = li;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // selectedvalue ni badle selectindex karvathi number aavse.
                string m = comboBox1.SelectedIndex.ToString();
             //   MessageBox.Show(m);
            if (m.Equals("0")) 
            {
                MessageBox.Show("please select your country", "warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(comboBox1.SelectedValue.ToString());
            }
        }
    }
}

