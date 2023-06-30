using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Button : mainUI
    {
        string startBt = "게임 시작"; // 시작 버튼 문자열 변수입니다.
        string endBt = "게임 종료"; // 게임 종료 문자열 변수입니다.

        public int xbuttonPo { get; private set; } //가로
        public int ybuttonPo { get; private set; } // 세로

        public int controlNum { get; set; }//컨트롤하기 위해


        public void PrintButton()
        {
            xbuttonPo = 82;
            ybuttonPo = 40;
            Console.SetCursorPosition(xbuttonPo, ybuttonPo); //처음이 가로x 두번째가 세로y
            Console.WriteLine("=>");
            Console.SetCursorPosition(xbuttonPo+3, ybuttonPo);
            Console.WriteLine($"{startBt}");
            Console.SetCursorPosition(xbuttonPo+3, ybuttonPo+2);
            Console.WriteLine($"{endBt}");
            controlNum = 0;
        }
        public void ControlButton()
        {
            //mainUI printUi = new mainUI();
            //User user = new User();

            while (controlNum != 6)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.W || userInput.Key == ConsoleKey.UpArrow)
                {
                    controlNum = 0;
                    if (controlNum == 0)
                    {
                        Console.SetCursorPosition(xbuttonPo, ybuttonPo+2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xbuttonPo, ybuttonPo); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        Console.SetCursorPosition(xbuttonPo+3, ybuttonPo);
                        Console.WriteLine($"{startBt}");
                        Console.SetCursorPosition(xbuttonPo+3, ybuttonPo + 2);
                        Console.WriteLine($"{endBt}");
                        Console.SetCursorPosition(0,0);

                    }
                }
                else if (userInput.Key == ConsoleKey.S || userInput.Key == ConsoleKey.DownArrow)
                {
                    controlNum = 1;
                    if (controlNum == 1)
                    {
                        Console.SetCursorPosition(xbuttonPo, ybuttonPo);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xbuttonPo, ybuttonPo + 2); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        Console.SetCursorPosition(xbuttonPo + 3, ybuttonPo);
                        Console.WriteLine($"{startBt}");
                        Console.SetCursorPosition(xbuttonPo + 3, ybuttonPo+ 2);
                        Console.WriteLine($"{endBt}");
                    }
                }
                else if (userInput.Key == ConsoleKey.Enter)
                {
                    if (controlNum == 1) 
                    {
                        Environment.Exit(0);
                    }
                    else if(controlNum == 0) 
                    {
                        controlNum = 6;
                    }
                }
        //        Console.WriteLine(controlNum);
            }
        }
    }
}
