using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        public void PrintStatus(User UiPlayer)
        {
            

            Console.SetCursorPosition(consoleWidth-178, consoleHeight-49);  //좌측 상단에 출력 
            Console.WriteLine($"체력 = {UiPlayer.healthPoint}"); //이름을 출력합니다.
            Console.SetCursorPosition(consoleWidth-178, consoleHeight-48);  //좌측 상단에 출력 
            Console.WriteLine($"의지 = {UiPlayer.willPower}"); //의지를 출력합니다.
            Console.SetCursorPosition(consoleWidth-55, consoleHeight-49);  //좌측 상단에 출력 
            Console.WriteLine($"  힘 = {UiPlayer.strong}"); //힘 출력합니다.
            Console.SetCursorPosition(consoleWidth-54, consoleHeight-48);  //우측 상단에 출력 
            Console.WriteLine($"지혜 = {UiPlayer.wisdom}"); //지혜를 출력합니다.

            Console.SetCursorPosition(consoleWidth-35, consoleHeight-49);   
            Console.WriteLine($"민첩 = {UiPlayer.speed}"); //민첨를 출력합니다.

            Console.SetCursorPosition(consoleWidth-34, consoleHeight-48);  //우측 상단에 출력 
            Console.WriteLine($"  운 = {UiPlayer.luck}"); //운을 출력합니다.


        }
        public void statBorder()
        {
            Console.SetCursorPosition(0, consoleHeight-47);//주인공 대사
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
        }
        public void rollText(string name , string text, int textSpeed)//대화 한줄씩 출력 대사 위치는 임의로 조정
        {
            Console.SetCursorPosition(30, 40);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(32, 40);
            Console.Write(name + " :");
            Console.SetCursorPosition(42, 40);
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(textSpeed);
            }
        }
        public void uiPrintEvent(string name, string text, int textSpeed)
        {

            Console.SetCursorPosition(30, 20);
            Console.WriteLine("                                                                             ");
            Console.SetCursorPosition(30, 20);
            Console.Write(name + " :");

            Console.SetCursorPosition(42, 20);
            for (int j = 0; j < text.Length; j++)
            {
                Console.Write(text[j]);
                Thread.Sleep(textSpeed);
            }
        }

        public void PrintText()
        {
            Console.SetCursorPosition(consoleWidth-150, consoleHeight-10);
            Console.WriteLine("│   본인   │    무엇을 하면 좋을까?                                      ");
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
        public void BattleUi()
        {
            //배틀 시작시 UI입니다.
        }
        public void MiddleClearUi()
        {
            Console.SetCursorPosition(0, 3);
           
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
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
        }
        


    }
}
