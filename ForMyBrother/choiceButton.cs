using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class choiceButton
    {
        public int choiceControlNum {  get; set; } 
        /*
         6 = 던전
         7 = 무작위 이벤트
         8 = 
         */
        public string choice1 { get; private set;}
        public string choice2 { get; private set;}
        public string choice3 { get; private set;}
        public string choice4 { get; private set;}

        public int xchoicePo;
        public int ychoicePo;
        public void SettingTwoChoice(string text1, string text2)
        {
            choice1 = text1;
            choice2 = text2;
        }
        public void SetThree(string text1, string text2, string text3)
        {
            choice1 = text1;
            choice2 = text2;
            choice3 = text3;
        }
        public void SettingAllChoice(string text1, string text2, string text3, string text4)
        {
            choice1 = text1;
            choice2 = text2;
            choice3 = text3;
            choice4 = text4;
        }
        public void PrintChoice()
        {
            xchoicePo = 82;
            ychoicePo = 10;
            Console.SetCursorPosition(xchoicePo, ychoicePo); //처음이 가로x 두번째가 세로y
            Console.WriteLine("=>");
            Console.SetCursorPosition(xchoicePo+3, ychoicePo);
            Console.WriteLine($"{choice1}");
            Console.SetCursorPosition(xchoicePo+3, ychoicePo+2);
            Console.WriteLine($"{choice2}");
            choiceControlNum = 0;
        }
       
        public void ControlChoice(int ch1, int ch2)
        {
            //mainUI printUi = new mainUI();
            //User user = new User();

            while (choiceControlNum < 5)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.W || userInput.Key == ConsoleKey.UpArrow)
                {
                    choiceControlNum = 0;
                    if (choiceControlNum == 0)
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo+2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        Console.SetCursorPosition(xchoicePo+3, ychoicePo);
                        Console.WriteLine($"{choice1}");
                        Console.SetCursorPosition(xchoicePo+3, ychoicePo + 2);
                        Console.WriteLine($"{choice2}");
                    }
                }
                else if (userInput.Key == ConsoleKey.S || userInput.Key == ConsoleKey.DownArrow)
                {
                    choiceControlNum = 1;
                    if (choiceControlNum == 1)
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo + 2); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        Console.SetCursorPosition(xchoicePo + 3, ychoicePo);
                        Console.WriteLine($"{choice1}");
                        Console.SetCursorPosition(xchoicePo + 3, ychoicePo+ 2);
                        Console.WriteLine($"{choice2}");
                    }
                }
                else if (userInput.Key == ConsoleKey.Enter)
                {
                    if (choiceControlNum == 0)
                    {
                        choiceControlNum = ch1;
                    }
                    else if (choiceControlNum == 1)
                    {
                        choiceControlNum = ch2;
                    }
                }
                        Console.WriteLine(choiceControlNum);
            }
        }
        public void PrintThree()
        {
            xchoicePo = 82;
            ychoicePo = 10;
            Console.SetCursorPosition(xchoicePo, ychoicePo); //처음이 가로x 두번째가 세로y
            Console.WriteLine("=>");
            Console.SetCursorPosition(xchoicePo+3, ychoicePo);
            Console.WriteLine($"{choice1}");
            Console.SetCursorPosition(xchoicePo+3, ychoicePo+2);
            Console.WriteLine($"{choice2}");
            Console.SetCursorPosition(xchoicePo+3, ychoicePo+4);
            Console.WriteLine($"{choice3}");
            choiceControlNum = 0;
        }
        public void ControlThree(int ch1, int ch2, int ch3)
        {
            //mainUI printUi = new mainUI();
            //User user = new User();

            while (choiceControlNum < 5)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.W || userInput.Key == ConsoleKey.UpArrow)
                {
                    if(choiceControlNum <= 0)
                    {
                        choiceControlNum = 0;
                    }
                   
                    else
                    {
                        choiceControlNum -=1;
                    }

                    if (choiceControlNum == 0)
                    {
                        
                        Console.SetCursorPosition(xchoicePo, ychoicePo+2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo+4);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        //Console.SetCursorPosition(xchoicePo+3, ychoicePo);
                        //Console.WriteLine($"{choice1}");
                        //Console.SetCursorPosition(xchoicePo+3, ychoicePo + 2);
                        //Console.WriteLine($"{choice2}");
                    }
                    else if(choiceControlNum == 1) 
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo+4);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo+2); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                    }
                    else if (choiceControlNum == 2) 
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo+2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo+4);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo+4); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                    }
                }
                else if (userInput.Key == ConsoleKey.S || userInput.Key == ConsoleKey.DownArrow)
                {
                    if (choiceControlNum >=2)
                    {
                        choiceControlNum = 2;
                    }
                    else
                    {
                        choiceControlNum +=1;
                    }
                    //choiceControlNum = 1;
                    if (choiceControlNum == 0)
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo +2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo +4 );
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo ); //처음이 x 두번째가 y
                        Console.WriteLine("=>");
                        //Console.SetCursorPosition(xchoicePo + 3, ychoicePo);
                        //Console.WriteLine($"{choice1}");
                        //Console.SetCursorPosition(xchoicePo + 3, ychoicePo+ 2);
                        //Console.WriteLine($"{choice2}");
                    }
                    else if(choiceControlNum == 1)
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo+4);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo + 2); 
                        Console.WriteLine("=>");
                    }
                    else if (choiceControlNum == 2)
                    {
                        Console.SetCursorPosition(xchoicePo, ychoicePo+2);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo);
                        Console.WriteLine("  ");
                        Console.SetCursorPosition(xchoicePo, ychoicePo + 4); 
                        Console.WriteLine("=>");
                    }
                }
                else if (userInput.Key == ConsoleKey.Enter)
                {
                    if (choiceControlNum == 0)
                    {
                        choiceControlNum = ch1;
                    }
                    else if (choiceControlNum == 1)
                    {
                        choiceControlNum = ch2;
                    }
                    else if (choiceControlNum == 2)
                    {
                        choiceControlNum = ch3;
                    }

                }
                Console.WriteLine(choiceControlNum);
            }
        }




    }
}
