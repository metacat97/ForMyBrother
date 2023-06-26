using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class StatsBase
    {
        public int level { get; protected set;}
        public string name { get; protected set;}   
        public int healthPointMax { get; protected set;}
        public int healthPoint { get; protected set;}
        public int willPowerMax { get; protected set; }
        public int willPower { get; protected set;}
        public int attack {get; protected set;}
        public int defence { get; protected set; }
        public int exp { get; protected set; }

    }
}
