using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class textBase
    {
        public int diffNumber;
        public string chName;
        public string chText;
        public void InitText(int number,string name, string text)
        {
            diffNumber = number;
            chName = name;
            chText = text; 
        }
    }
}
