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
            User user = new User();

            //button.PrintButton();
            //while (true) 
            //{
            //    button.ControlButton();
            //}

            Console.WriteLine(user.exp);
            Console.WriteLine(user.attack);

            user.LevelUp();
            Console.WriteLine(user.exp);
            Console.WriteLine(user.attack);
        }
    }
}
