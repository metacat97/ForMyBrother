using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Button
    {
        string startBt = "게임 시작"; // 시작 버튼 문자열 변수입니다.
        string endBt = "게임 종료"; // 게임 종료 문자열 변수입니다.

        public void PrintButton()
        {
            Console.SetCursorPosition(0, 0); //처음이 x 두번째가 y
            Console.WriteLine("=>");
            Console.SetCursorPosition(3, 0);
            Console.WriteLine($"{startBt}");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine($"{endBt}");

        }
        public void ControlButton()
        {
            int controlNum = 0;
            ConsoleKeyInfo upDown = Console.ReadKey();
            if (upDown.Key == ConsoleKey.W || upDown.Key == ConsoleKey.UpArrow)
            {
                

                controlNum = 0;
                if (controlNum == 0)
                {
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, 0); //처음이 x 두번째가 y
                    Console.WriteLine("=>");
                    Console.SetCursorPosition(3, 0);
                    Console.WriteLine($"{startBt}");
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine($"{endBt}");
                }
            }
            else if (upDown.Key == ConsoleKey.S || upDown.Key == ConsoleKey.DownArrow)
            {
                controlNum = 1;
                if (controlNum == 1)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("  ");
                    Console.SetCursorPosition(0, 2); //처음이 x 두번째가 y
                    Console.WriteLine("=>");
                    Console.SetCursorPosition(3, 0);
                    Console.WriteLine($"{startBt}");
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine($"{endBt}");
                }

            }


        }

    }
}
