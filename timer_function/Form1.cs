using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_function
{
    public partial class Time_Form : Form
    {
        public Time_Form()
        {
            InitializeComponent();
        }

        private void Time_Form_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.Day+"/" +DateTime.Now.Month +"/" +DateTime.Now.Year;
            textBox2.Text = DateTime.Now.Hour +" : " +DateTime.Now.Minute +" : " +DateTime.Now.Second;

            // ------------- Timer 2 --------------------
            timer2.Interval= 1000;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rn= new Random();
            int a,b,c;
            a = rn.Next(0, 244);
            b = rn.Next(0, 233);
            c = rn.Next(0, 233);

            label1.Text = "Red" + a +"Green"+b+"Blue"+c;
            ForeColor= Color.FromArgb(a,b,c);
        }
    }
}