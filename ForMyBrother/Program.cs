using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();


            button.PrintButton();
            while (true) 
            {
                button.ControlButton();
            }

            


        }
    }
}
