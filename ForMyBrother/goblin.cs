using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class goblin : MonsterBase
    {

        public int Speed { get; private set; }
        
        //public goblin() 
        //{
        //    Name = "고블린";
        //    Speed = 5;
        //}
        public override void Init(string name, int hp, int damage)
        {
            base.Init(name, hp, damage);
        }
        public override void HitDamage(int damage)
        {
            base.HitDamage(damage);
        }
    }
}
