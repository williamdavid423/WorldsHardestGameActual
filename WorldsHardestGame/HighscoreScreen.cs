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
        List<Highscore> highscoreList = new List<Highscore>();

        public HighscoreScreen()
        {
            InitializeComponent();
            HighscoreBuilder();
        }

    public void HighscoreBuilder()
        {
            string name, time;

            XmlReader reader = XmlReader.Create("Resources/HighscoreXml.xml");

            while (reader.Read())

            {

                if (reader.NodeType == XmlNodeType.Text)

                {
                   // reader.ReadToFollowing("name");
                    name = reader.ReadString();



                    reader.ReadToNextSibling("time");

                    time = reader.ReadString();


                    Highscore hs = new Highscore(name, time);

                    highscoreList.Add(hs);

                }



            }
            foreach (Highscore h in highscoreList)
            {
                namesLabel.Text += $"\n{h.name}     {h.time}";
            }
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
