using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Map
    {
        public void drawMap()
        {
            User player = new User(); //유저 클래스 소환
            //랜덤 인스턴스 생성
            Random rand = new Random();
            //메인 맵 초기 크기 선언
            int yFirst_Map_Area = 40;
            int xFirst_Map_Area = 40;
            //유저 위치 선언
            player.setuxyPos(37, 20);
            //맵 배열 만들기
            string[,] map = new string[yFirst_Map_Area, xFirst_Map_Area];


            for (int i = 0; i < yFirst_Map_Area; i++)
            {
                for (int j = 0; j < xFirst_Map_Area; j++)
                {
                    map[i, j] = "　";
                    if (i == 0 || j == 0)
                    {
                        map[i, j] = "■";
                    }
                    if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                    {
                        map[i, j] = "■";
                    }
                    if (i == player.uyPos && j == player.uxPos)
                    {
                        map[i, j] = "♥";
                    }
                    
                }
            }


            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < yFirst_Map_Area; i++)
            {
                for (int j = 0; j < xFirst_Map_Area; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if (i == player.uyPos && j == player.uxPos)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("{0}", map[i, j]);
                    Console.ResetColor();
                }
                Console.WriteLine();
            }//처음 출력 끝나는 부분

            while (true)
            {
                ConsoleKeyInfo UserInput = Console.ReadKey();
                //Console.Clear();
                if (UserInput.Key == ConsoleKey.W || UserInput.Key == ConsoleKey.UpArrow)
                {
                    if (player.uyPos > 1)
                    {
                        if (map[(player.uyPos-1), player.uxPos] == "■")
                        {

                        }
                        else if (map[(player.uyPos-1), player.uxPos] == "＠")
                        {
                            Console.WriteLine("클로버 문양 발견");

                            //player.SubyPos(1);
                            //Map[player.uyPos, player.uxPos] ="♥";
                            //Map[player.uyPos+1, player.uxPos] ="　";
                        }
                        else if (player.uyPos >5 && player.uyPos < 17 && player.uxPos > 53 && player.uxPos<74)
                        {



                            player.SubyPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos+1, player.uxPos] ="※";

                        }
                        else
                        {
                            player.SubyPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos+1, player.uxPos] ="　";
                        }




                    }
                    else
                    {
                        player.setuxyPos(1, player.uxPos);
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//상단 이동
                else if (UserInput.Key == ConsoleKey.S || UserInput.Key == ConsoleKey.DownArrow)
                {
                    if (player.uyPos < yFirst_Map_Area-2)
                    {
                        if (map[(player.uyPos+1), player.uxPos] == "■")
                        {
                            Console.WriteLine("적 문양 잘 만남");
                            //player.SumyPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos-1, player.uxPos] ="　";
                        }
                        else if (map[(player.uyPos+1), player.uxPos] == "＠")
                        {
                            Console.WriteLine("클로버 문양 발견");


                            //player.SumyPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos-1, player.uxPos] ="　";
                        }
                        else
                        {
                            player.SumyPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos-1, player.uxPos] ="　";
                        }

                    }
                    else
                    {
                        player.setuxyPos(yFirst_Map_Area-2, player.uxPos);
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//하단 이동
                else if (UserInput.Key == ConsoleKey.A || UserInput.Key == ConsoleKey.LeftArrow)
                {
                    if (player.uxPos > 1)
                    {
                        if (map[player.uyPos, (player.uxPos-1)] == "■")
                        {
                            Console.WriteLine("벽 발견");
                            //player.SubxPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos, player.uxPos+1] ="　";
                        }
                        else if (map[player.uyPos, (player.uxPos-1)] == "＠")
                        {
                            Console.WriteLine("클로버 발견");
                            //player.SubxPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos, player.uxPos+1] ="　";

                        }
                        else
                        {
                            player.SubxPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos, player.uxPos+1] ="　";
                        }
                    }
                    else
                    {
                        player.setuxyPos(player.uyPos, 1);
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }

                }//좌측 이동
                else if (UserInput.Key == ConsoleKey.D || UserInput.Key == ConsoleKey.RightArrow)
                {
                    if (player.uxPos < xFirst_Map_Area-2)
                    {
                        if (map[player.uyPos, (player.uxPos+1)] == "■")
                        {
                            Console.WriteLine("전투를 시작합니다.\n");
                            //player.SumxPos(1);
                            //map[player.uyPos, player.uxPos] ="&";
                            //map[player.uyPos, player.uxPos-1] ="　";
                        }
                        else if (map[player.uyPos, (player.uxPos+1)] == "@")
                        {
                            Console.WriteLine("카드 게임을 시작합니다.");
                            //player.SumxPos(1);
                            //map[player.uyPos, player.uxPos] ="&";
                            //map[player.uyPos, player.uxPos-1] ="　";
                        }
                        else
                        {
                            player.SumxPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos, player.uxPos-1] ="　";
                        }

                    }
                    else
                    {
                        player.setuxyPos(player.uyPos, xFirst_Map_Area-2);
                        Console.WriteLine("\n 벽에 막혀 더 이상 갈 수 없어요");
                    }
                }//우측 이동
                else if (UserInput.Key == ConsoleKey.R)
                {
                    for (int i = 0; i < yFirst_Map_Area; i++)
                    {
                        for (int j = 0; j < xFirst_Map_Area; j++)
                        {
                            map[i, j] = "　";
                            if (i == 0 || j == 0)
                            {
                                map[i, j] = "■";
                            }
                            if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                            {
                                map[i, j] = "■";
                            }
                            if (i == player.uyPos && j == player.uxPos)
                            {
                                map[i, j] = "♥";
                            }
                        }
                    }
                }//맵 리셋

                


                //출력하는 부분
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < yFirst_Map_Area; i++)
                {
                    for (int j = 0; j < xFirst_Map_Area; j++)
                    {
                        if (i >5 && i < 17 && j > 53 && j<74)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        if (i == 0 || j == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        if (i == yFirst_Map_Area-1 || j == xFirst_Map_Area-1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        if (i == player.uyPos && j == player.uxPos)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        
                        Console.Write("{0}", map[i, j]);
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }//while안에서 출력 끝나는 부분
                   

            }//main while 끝나는 부분

        }
         
    }
}
 