using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class Form1 : Form
    {
        private int fileNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayFileNumber(fileNumber)
            fileNumber++;
            if (fileNumber >= openFileDialog1.FileName.Count())
            {
                fileNumber = 0;
            }

            DisplayFileNumber(int fileNumber);
        }

        private void DisplayFileNumber(int v, int fileNumber)
        {
            throw new NotImplementedException();
        }
    }
}
