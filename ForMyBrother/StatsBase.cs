using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class StatsBase
    {
        
        public int level { get; protected set;} //레벨
        public string name { get; protected set;} //이름
        public int healthPointMax { get; protected set;} // 최대 hp
        public int healthPoint { get; protected set;} //현재 hp
        public int willPowerMax { get; protected set; } // 최대 의지력
        public int willPower { get; protected set;}// 현재 의지력
        public int strong {get; protected set;} // 힘
        public int wisdom { get; protected set;} // 지혜
        public int speed { get; protected set;}//민첩
        public int luck { get; protected set; } // 운
        public int exp { get; protected set; } // 경험치

    }
}
