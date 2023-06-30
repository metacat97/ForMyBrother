using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace ForMyBrother 
{
    public class mainUI
    {
        
        public int consoleWidth {get; private set;}
        public int consoleHeight { get; private set; }
        //public int cutline { get; private set; }
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
            Console.SetCursorPosition(60, 15);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 16);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣾⠟⠛⠛⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 17);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⢰⣿⠀⠀⠀⢀⣤⣄⡀⠀⠀⠀⢳⡄⢀⣤⣶⣶⡶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 18);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠸⣿⠿⠿⠿⠿⠛⠛⠉⡀⠀⠀⠈⣿⣾⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 19);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣿⡄⠀⠀⠀⠀⠀⣼⡿⠿⢷⣄⠹⣿⠀⠀⠀⠀⠀⠀⠀⠀⠈⠳⣦⣤⣼⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 20);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢿⡇⠀⠀⠀⠀⢸⣿⡇⠀⠀⣿⠀⣿⡄⠀⠀⠀⣶⣷⣾⡿⣷⠀⠀⣼⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 21);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢿⡇⠀⠀⠀⠀⢸⣿⡇⠀⠀⣿⠀⣿⡄⠀⠀⠀⣶⣷⣾⡿⣷⠀⠀⣼⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 22);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣇⠀⠀⠀⠀⠀⠙⢿⣶⣾⠏⠀⢿⣧⠀⠀⢠⣿⠁⣿⡇⣿⢀⣼⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 23);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠈⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠀⠀ ⠘⠛⠀⠉⠁⠛⠘⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 24);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀ ⠀⠀⠀⢰⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.SetCursorPosition(60, 25);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣧⠀⠀⠀⠀  ⣠⠀⠀⠀⠀⠀⠀⠀ ⢸⡆⣀⡀⢸⡇⠀⠀⠀⠀ ⢀⣠⣄⠀⢶⡀⣀⣀⡀");
            Console.SetCursorPosition(60, 26);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣤⣤⣤⡀⣿⣶⡶⠀⢠⣶⣦⣄⠀⠀⠘⢻⣿⠛⠉⢸⣿⡿⠿⣶⣄ ⢸⣏⣹⣷⢸⣿⠛⠋⠁");
            Console.SetCursorPosition(60, 27);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠉⠀⢹⡇⣿⡏⠀⠀⣿⠁⢀⣿⠀⠀⠀⠀⣿⡀⠀⠈⣿⡇⠀⠈⣿⡆⠀⢿⡟⠋⠁⠈⣿⠀⠀⠀");
            Console.SetCursorPosition(60, 28);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⠀⢀⣸⡇⣿⡇⠀⠀⣿⣤⣼⠏⠀⠀⠀⠀⠹⢷⣶⠄⣿⡇⠀⠀⠈⣿⠄⠸⢷⣦⣀⡀⠿⠀⠀⠀");
            Console.SetCursorPosition(60, 29);
            Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠿⠿⠟⠋⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠀⠀⠀⠀⠀⠀⠀⠈⠉⠁⠀⠀⠀⠀");

        }
        public void PrintStatus(User UiPlayer)
        {

            Console.SetCursorPosition(5, 1);  //좌측 상단에 출력 
            Console.WriteLine($"Lv = {UiPlayer.level}"); //이름을 출력합니다.
            Console.SetCursorPosition(30, 1);  //좌측 상단에 출력 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"체력 = {UiPlayer.healthPoint}"); //이름을 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(30, 2);  //좌측 상단에 출력 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"의지 = {UiPlayer.willPower}"); //의지를 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(126, 1);  //좌측 상단에 출력 
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"힘 = {UiPlayer.strong}"); //힘 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(126, 2);  //우측 상단에 출력 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"운 =  {UiPlayer.luck}"); //지혜를 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(145, 2);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"민첩 = {UiPlayer.speed}"); //민첨를 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(145, 1);  //우측 상단에 출력 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"지혜 = {UiPlayer.wisdom}"); //운을 출력합니다.
            Console.ResetColor();

            Console.SetCursorPosition(163, 2);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"소지금 = {UiPlayer.coin}"); //민첨를 출력합니다.
            Console.ResetColor();

        } //스텟 출력 
        public void statBorder()
        {
            Console.SetCursorPosition(0, 3);//스테이터스 밑 줄
            Console.WriteLine("├─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┤");
        }//스테이터스 보더
        public void rollText(string name , string text, int textSpeed)//대화 한줄씩 출력 대사 위치는 임의로 조정
        {
            Console.SetCursorPosition(30, 40);
            Console.WriteLine("                                                                                                          ");
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

            Console.SetCursorPosition(20, 20); 
            Console.WriteLine("                                                                                                  ");
            Console.SetCursorPosition(20, 20);
            Console.Write(name + " :");

            Console.SetCursorPosition(32, 20);
            for (int j = 0; j < text.Length; j++)
            {
                Console.Write(text[j]);
                Thread.Sleep(textSpeed);
            }
        }
        public void TextAPEvent(string text, int textSpeed)//AP   all print 한다는 의미이빈다.
        {
                //Console.SetCursorPosition(1, cutline+line*2);
                for (int j = 0; j < text.Length; j++)
                {
                    Console.Write(text[j]);
                    Thread.Sleep(textSpeed);
                }
        }
        public void InvenClear(User player)
        {
            for (int i = 0; i < player.userInven.Count; i++)
            {
                Console.SetCursorPosition(30, 10+i);
                Console.WriteLine("                                                 ");
            }
        }

        public void PrintText(string text)
        {
            Console.SetCursorPosition(30,40);
            Console.WriteLine(" "+text+"                                                               ");
        }//메인화면에 항상 보여줄
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
