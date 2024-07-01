using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_C_Sharp
{
    internal class Player
    {
        //public string name = "sandesh";
        //public int health = 89;

        private string name = "sandesh";
        private int health = 89;

        public int getHealth()
        {
            return health;
        }

        public string getName()
        {
            return name;
        }

        public void setHelth(int h) {
            health = h;
        }
    }
}
