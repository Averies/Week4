using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_AVE_F
{
    internal class Player
    {
        private string name;
        public string AddName
        {
            get { return name; }
            set { name = value; }
        }
        private string number;
        public string AddNumber
        {
            get { return number; }
            set { number = value; }
        }
        private string position;
        public string AddPosition
        {
            get { return position; }
            set { position = value; }
        }
    }
}
