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
            mainUI ui = new mainUI();
            ui.setUi();
            ui.PrintUi();
            //ui.PrintTitle();
            //button.PrintButton();
            //while (true)
            //{
            //    button.ControlButton();

            //    Console.WriteLine(button.controlNum);
            //}
            ui.PrintStatus(user.healthPoint, user.willPower, user.strong,user.wisdom, user.speed, user.luck); //능력치 변환 ui 테스트 
            user.LevelUp();
            Console.ReadLine();
            ui.PrintStatus(user.healthPoint, user.willPower, user.strong, user.wisdom, user.speed, user.luck);


        }
    }
}
