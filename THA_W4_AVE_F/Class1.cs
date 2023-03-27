using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_W4_AVE_F
{
    internal class Team
    {
        private string name;
        public string AddName
        {
            get { return name; }
            set { name = value; }
        }
        private string country;
        public string AddCountry
        {
            get { return country; }
            set { country = value; }
        }
    }
}
