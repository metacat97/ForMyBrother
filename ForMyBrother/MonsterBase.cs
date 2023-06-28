using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class MonsterBase
    {
        public string Name { get; protected set; }

        public int Hp { get; protected set; }
        public int Str { get; protected set; }
        public int Def { get; protected set; }

        public virtual void Init(string name, int hp, int damage)
        {
            this.Name = name;
            this.Hp = hp;
            this.Str = damage;
        }
        public virtual void HitDamage(int damage) 
        {
            this.Hp -= damage;
        }

    }

}
