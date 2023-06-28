using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Map
    {
            //User player = new User(); //유저 클래스 소환
        public void drawMap(User player)
        {
            goblin mob1 = new goblin();
            Battle battle = new Battle();  
            //랜덤 인스턴스 생성
            Random rand = new Random();
            //메인 맵 초기 크기 선언
            int yFirst_Map_Area = 30;
            int xFirst_Map_Area = 30;
            //유저 위치 선언
            player.setuxyPos(27, 20);
            //맵 배열 만들기
            string[,] map = new string[yFirst_Map_Area, xFirst_Map_Area];
            //장애물(벽)담을 배열
            int[] wallY = new int[200];
            int[] wallX = new int[200];
            //아이템 담을 배열
            int[] mapItemY = new int[100];
            int[] mapItemX = new int[100];
            //이벤트 담을 배열
            int[] eventY = new int[100];
            int[] eventX = new int[100];
            //escape count 만들기
            int escCount = 1;

            #region 맵과 아이템 생성
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
            //벽 생성
            for (int i = 0; i < 50; i++)
            {
                wallY[i]=rand.Next(2, yFirst_Map_Area-2);
                wallX[i]=rand.Next(2, xFirst_Map_Area-2);
                map[wallY[i], wallX[i]] = "■";
            }
            //아이템 생성
            for (int i = 0; i <3; i++)
            {
                mapItemY[i]=rand.Next(2, yFirst_Map_Area-2);
                mapItemX[i]=rand.Next(2, xFirst_Map_Area-2);
                map[mapItemY[i], mapItemX[i]] = "ⓐ";
            }
            //이벤트 생성
            for (int i = 0; i <1; i++)
            {
                mapItemY[i]=rand.Next(2, yFirst_Map_Area-2);
                mapItemX[i]=rand.Next(2, xFirst_Map_Area-2);
                map[mapItemY[i], mapItemX[i]] = "？";
            }
            #endregion;
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
            //주 반복문 시작
            while (escCount != 0)
            {
                ConsoleKeyInfo UserInput = Console.ReadKey();
                Console.WriteLine("현재 사용자의 체력 = {0} --- 의지 ={1}", player.healthPoint, player.willPower);
                //Console.Clear();
                if (UserInput.Key == ConsoleKey.Escape)//esc 입력의 경우
                {
                    Console.WriteLine("정말 나가시겠습니까? (y/n 입력)");
                    string escQuestion = Console.ReadLine();
                    if (escQuestion == "y")
                    {
                        escCount -= 1;
                    }
                    else if (escQuestion == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Press any key...");

                        continue;
                    }
                    else
                    {
                        Console.WriteLine(" y 혹은 n 으로 다시 입력해주시길 바랍니다");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Press any key...");
                    }
                }
                else if (UserInput.Key == ConsoleKey.W || UserInput.Key == ConsoleKey.UpArrow)
                {
                    if (player.uyPos > 1)
                    {
                        if (map[(player.uyPos-1), player.uxPos] == "■")
                        {

                        }
                        else if (map[(player.uyPos-1), player.uxPos] == "ⓐ")
                        {

                          
                            battle.startBattle(player);

                            player.SubyPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos+1, player.uxPos] ="　";
                        }
                        else if(map[(player.uyPos-1), player.uxPos] == "？")
                        {

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
                            //Console.WriteLine("적 문양 잘 만남");
                            //player.SumyPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos-1, player.uxPos] ="　";
                        }
                        else if (map[(player.uyPos+1), player.uxPos] == "ⓐ")
                        {
                            //Console.WriteLine("클로버 문양 발견");
                            battle.startBattle(player);

                            player.SumyPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos-1, player.uxPos] ="　";
                        }
                        else if (map[(player.uyPos+1), player.uxPos] == "？")
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
                            //Console.WriteLine("벽 발견");
                            //player.SubxPos(1);
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos, player.uxPos+1] ="　";
                        }
                        else if (map[player.uyPos, (player.uxPos-1)] == "ⓐ")
                        {
                            //Console.WriteLine("적 발견");
                            battle.startBattle(player);
                            player.SubxPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos, player.uxPos+1] ="　";

                        }
                        else if (map[player.uyPos, (player.uxPos-1)] == "？")
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
                            //map[player.uyPos, player.uxPos] ="♥";
                            //map[player.uyPos, player.uxPos-1] ="　";
                        }
                        else if (map[player.uyPos, (player.uxPos+1)] == "ⓐ")
                        {
                            battle.startBattle(player);
                            player.SumxPos(1);
                            map[player.uyPos, player.uxPos] ="♥";
                            map[player.uyPos, player.uxPos-1] ="　";
                        }
                        else if (map[player.uyPos, (player.uxPos+1)] == "？")
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
                else if (UserInput.Key == ConsoleKey.Spacebar || UserInput.Key == ConsoleKey.Enter)
                {
                    //미구현
                }//엔터 혹은 스페이스바 입력의 경우
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
 