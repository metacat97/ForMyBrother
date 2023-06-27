﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother 
{
    public class mainUI
    {
        public int consoleWidth {get; private set;}
        public int consoleHeight { get; private set; }
        
        public void setUi()
        {
            consoleWidth = 180;
            consoleHeight = 50;
            Console.SetWindowSize(consoleWidth, consoleHeight); 
        }
        public void resizeUi(int x, int y)//맵 그려줄 때 사이즈 조정을 위해
        {
            consoleWidth = x; 
            consoleHeight = y; 
            Console.SetWindowSize(consoleWidth, consoleHeight);
        }
        public void PrintUi()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("│                                                                                                                                                                                 │");
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");

        }
        public void PrintTitle()
        {
            Console.SetCursorPosition(consoleWidth-125, consoleHeight-30);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(consoleWidth-125, consoleHeight-29);
            Console.WriteLine("│                                                                        │");
            Console.SetCursorPosition(consoleWidth-125, consoleHeight-28);
            Console.WriteLine("│                            타이틀 들어갈 자리                          │");
            Console.SetCursorPosition(consoleWidth-125, consoleHeight-27);
            Console.WriteLine("│                                                                        │");
            Console.SetCursorPosition(consoleWidth-125, consoleHeight-26);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘");
        }

        public void PrintStatus(int hp, int will, int str, int wisdom, int speed, int luck)
        {
            

            Console.SetCursorPosition(consoleWidth-178, consoleHeight-49);  //좌측 상단에 출력 
            Console.WriteLine($"체력 = {hp}"); //이름을 출력합니다.
            Console.SetCursorPosition(consoleWidth-178, consoleHeight-48);  //좌측 상단에 출력 
            Console.WriteLine($"의지 = {will}"); //의지를 출력합니다.
            Console.SetCursorPosition(consoleWidth-55, consoleHeight-49);  //좌측 상단에 출력 
            Console.WriteLine($"  힘 = {str}"); //힘 출력합니다.
            Console.SetCursorPosition(consoleWidth-54, consoleHeight-48);  //우측 상단에 출력 
            Console.WriteLine($"지혜 = {wisdom}"); //지혜를 출력합니다.

            Console.SetCursorPosition(consoleWidth-35, consoleHeight-49);   
            Console.WriteLine($"민첩 = {speed}"); //민첨를 출력합니다.

            Console.SetCursorPosition(consoleWidth-34, consoleHeight-48);  //우측 상단에 출력 
            Console.WriteLine($"  운 = {luck}"); //운을 출력합니다.


        }
        public void statBorder()
        {
            Console.SetCursorPosition(0, consoleHeight-47);//주인공 대사
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
        }
        public void PrintText()
        {
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-12);
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────────┐");
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-11);
            Console.WriteLine("│                                                                        │");
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-10);
            Console.WriteLine("│                            텍스트 들어갈 자리                          │");
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-9);
            Console.WriteLine("│                                                                        │");
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-8);
            Console.WriteLine("└────────────────────────────────────────────────────────────────────────┘");
        }
        public void userTextBorder()
        {
            Console.SetCursorPosition(0,consoleHeight-14 );//주인공 대사
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
        }
        public void userProfileBorder()
        {
            Console.SetCursorPosition(0, consoleHeight-14);//주인공 대사
            Console.WriteLine("├────────────────────────┐");
            Console.SetCursorPosition(0, consoleHeight-13);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-12);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-11);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-10);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-9);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-8);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-7);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-6);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-5);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-4);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-3);//주인공 대사
            Console.WriteLine("│                        │");
            Console.SetCursorPosition(0, consoleHeight-2);//주인공 대사
            Console.WriteLine("└────────────────────────┘");

        }
    }
}
