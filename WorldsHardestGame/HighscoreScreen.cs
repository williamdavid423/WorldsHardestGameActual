using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WorldsHardestGame
{
    public partial class HighscoreScreen : UserControl
    {
        List<string> highscoreList = new List<string>();

        public HighscoreScreen()
        {
            InitializeComponent();
        }

    public void HighscoreBuilder()
        {
            XmlReader reader = XmlReader.Create("HighscoreXml.xml");
        }

        private void initialTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("HighscoreXml.xml");
        }

        private void HighscoreScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
