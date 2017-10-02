using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppendTextApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var content = "";
            saveFileDialog1.ShowDialog();
            content = File.ReadAllText(openFileDialog1.FileName);
            content += File.ReadAllText(openFileDialog2.FileName);
            File.WriteAllText(saveFileDialog1.FileName, content);
        }




        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var path = folderBrowserDialog1.SelectedPath;
            foreach (var filename in Directory.GetFiles(path, "*.txt"))
            {
                comboBox1.Items.Add(filename);
            }
        }


    }
}
