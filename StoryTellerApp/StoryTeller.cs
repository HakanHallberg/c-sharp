using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTellerApp
{
    public partial class StoryTeller : Form
    {
        public StoryTeller()
        {
            InitializeComponent();
        }

        private void StoryTeller_Click(object sender, EventArgs e)
        {
            StoryTeller storyTeller = new StoryTeller();
            StoryTeller.Text = storyTeller.TellStory(
                NameOfChild.Text,
                Convert.ToInt32(numAge.Value),
                Scary.Enabled);
        }


    }
}
