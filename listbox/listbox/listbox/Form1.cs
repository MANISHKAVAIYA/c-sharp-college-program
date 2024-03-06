using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> va = new List<string> { "Hello", "This" };

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("BBA");
            listBox1.Items.Add("MBA");
            listBox1.Items.Add("BCA");
            listBox1.Items.Add("MCA");
            // multiple line select karva mate hamesha for each loop j use karvi.
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            
            // second listbox add item start list first create va string

            listBox2.DataSource = va;

            // end of listbox no.2

            BackColor= Color.LightGoldenrodYellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show(listBox1.SelectedItem.ToString());
   
            // foreach loop hamesha loop all collection use only work.:

            foreach (var item in listBox1.SelectedItems)
            {
                MessageBox.Show(item.ToString());
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
