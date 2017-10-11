using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int message = int.Parse(textBox3.Text.Substring(9, 1));
            if (message % 2 != 1)
                label4.Text = "God morgon fru " + textBox1.Text + " " + textBox2.Text + "!";
            else
                label4.Text = "God morgon herr " + textBox1.Text + " " + textBox2.Text + "!"; 
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
