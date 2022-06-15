using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldsHardestGame
{
    internal class Highscore
    {
        public string name;
        public string time;

        public Highscore(string _name, string _time)
        {
            name = _name;
            time = _time;
        }
    }
    
}
