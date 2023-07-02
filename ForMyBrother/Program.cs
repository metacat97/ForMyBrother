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
            Console.OutputEncoding = Encoding.UTF8;
            Button button = new Button();
            choiceButton chButton = new choiceButton();
            User user = new User();
            mainUI ui = new mainUI();
            Shop showItems = new Shop();
            Map map = new Map();
            textBase printEvent = new textBase();
            everyText pText = new everyText();
            AllEvent allEvent = new AllEvent();
            Battle test = new Battle();

            Random rand = new Random();
           
            while (true) // 엔딩 보면 다시 돌아오게끔
            {
                int shopMeetCount = 0; //상점에 처음 왔는지 아닌지 체크 하는 
                allEvent.endingCount = 0;
                int normalCount = 0;
                int alleventCount = 0;
                int maineventCount = 0;
                ui.setUi();//콘솔창 크기 고정
                ui.PrintUi();//처음 도화지 출력
                ui.PrintTitle(); // 타이틀 로고 출력
                button.PrintButton();//버튼 첫 출력
                button.ControlButton();//버튼 제어 기능 - 게임 종료를 누르면 break

                Console.Clear();//지워주고

                ui.resizeUi(110, 40);//사이즈 재조정
                //allEvent.Prololog();//프롤로그 텍스트 출력
               // allEvent.PllQ1(user);//스테이터스 질문 1
                Console.Clear();
                //allEvent.PllQ2(user);// 스테이터스 질문 2
                Console.Clear();
                //allEvent.PllQ3(user);//스테이터스 질문 3

                while (true)//주 게임 반복문 시작
                {
                    ui.setUi();//콘솔창 크기 고정
                    ui.PrintUi(); //비유하자면 도화지  출력

                    ui.statBorder();//스테이터스 밑 줄
                    ui.PrintStatus(user); //능력치 변환 ui 테스트 
                    #region 유저 텍스트 테두리
                    ui.userTextBorder();
                    ui.userProfileBorder();
                    ui.PrintText("천천히 눈을 뜬다");
                    Console.ReadLine();
                    #endregion;
                    allEvent.GuideMessage();
                    chButton.SetThree("집을 나선다", "특수 임무 수행","편의점을 방문한다");
                    chButton.PrintThree();
                    chButton.ControlThree(6, 7,8,user);
                    if (chButton.choiceControlNum == 6)//6이면 무작위 이벤트 출력
                    {
                        maineventCount += 1;
                        alleventCount += 1;
                        ui.MiddleClearUi();//여기다가 중앙화면만 지워주는 공백 그려줄려고요
                        //if (alleventCount == 1)
                        //{
                        //    allEvent.event001(); //이벤트 텍스트 모음 출력
                        //}
                        
                       // Console.ReadLine();
                       
                            //normalCount = rand.Next(1, 20);
                            normalCount = 4;
                       
                        if (normalCount == 6)
                        {
                            user.SubWill();
                        }
                        allEvent.EventControl(normalCount, chButton);
                        if (chButton.choiceControlNum == 23)
                        {
                            test.startBattle(user);
                            if (user.healthPoint <= 0)
                            {
                                Console.WriteLine("체력이 0이 되어 집으로 귀환합니다.");
                                Console.ReadLine();
                                user.SubWill();
                                allEvent.badEndingCount +=1;
                            }
                            else
                            {
                                allEvent.endingCount  +=1;
                            }
                        }
                        else if (chButton.choiceControlNum ==31)
                        {
                            test.startBattle1(user);
                            if (user.healthPoint <= 0)
                            {
                                Console.WriteLine("체력이 0이 되어 집으로 귀환합니다.");
                                Console.ReadLine();
                                user.SubWill();
                                allEvent.badEndingCount +=1;
                            }
                            else
                            {
                                allEvent.endingCount  +=1;
                            }
                        }
                        else if (chButton.choiceControlNum == 33)
                        {
                            for (int i = 0; i < user.userInven.Count; i++)
                            {
                                if (user.userInven[i].itemName == "고등어")
                                {
                                    Console.SetCursorPosition(100, 10);
                                    Console.WriteLine("정말 감사합니다! 맛있게 해드릴게요!");
                                    user.Heal();
                                    Console.ReadLine();

                                }
                                else
                                {
                                    Console.SetCursorPosition(100, 10);
                                    Console.WriteLine("없는데 해드릴 수는 없어요!");
                                    user.SubWill();
                                    Console.ReadLine() ;
                                }
                            }
                        }
                        else if(chButton.choiceControlNum == 37)
                        {
                            Console.SetCursorPosition(100, 10);
                            Console.WriteLine("500 코인을 획득했다~!");
                            user.UserSetCoin(500);
                            Console.ReadLine();
                            
                        }
                        else if (chButton.choiceControlNum == 51)
                        {
                            user.Heal();
                        }
                        else if ( chButton.choiceControlNum == 52)
                        {
                            //전투 발생
                            test.startBattle(user);
                            if (user.healthPoint <= 0)
                            {
                                Console.WriteLine("체력이 0이 되어 집으로 귀환합니다.");
                                Console.ReadLine();
                                user.SubWill();
                                allEvent.badEndingCount +=1;
                            }
                            else
                            {
                                allEvent.endingCount  +=1;
                            }
                        }
                        else if (chButton.choiceControlNum == 56 || chButton.choiceControlNum == 58)
                        {
                            Console.SetCursorPosition(100, 10);
                            Console.WriteLine("당기지 않았지만 치이익 소리를 내며 폭발이 일어났다");
                            user.UserHit(user.healthPoint/2);
                            Console.ReadLine();

                        }
                        else if (chButton.choiceControlNum ==60)
                        {
                            allEvent.BadEnd();
                            ui.ShowBadEnding();
                            Console.ReadLine();

                            break;
                        }




                    }
                    else if (chButton.choiceControlNum == 7)
                    {
                        //Console.ReadLine();

                        Console.Clear();
                        ui.resizeUi(60, 38); //사이즈 재조정
                        map.drawMap(user, showItems);

                    }
                    else if (chButton.choiceControlNum ==8)
                    {

                        //상점을 보여줄 차례
                        ui.MiddleClearUi();
                        if (shopMeetCount == 0)
                        {
                            ui.profileShop2();
                            allEvent.ShopOpen1();
                            //ui.MiddleClearUi();

                            shopMeetCount = 1;
                        }
                        else if (shopMeetCount == 1)
                        {
                            ui.profileShop2();
                            allEvent.ShopOpen2();
                            //ui.MiddleClearUi();

                        }
                        showItems.MarketUi(showItems.Item);
                       // showItems.SpecialUi(showItems.SpecialItem); 
                        showItems.Purchase(user);

                        //ui.MiddleClearUi();
                        switch (user.shopIO)
                        {
                            case 0:
                                allEvent.ShopClose1();
                                break;
                            case 1:

                                allEvent.ShopClose2();
                                break;
                        }
                    }
                    
                    if (allEvent.endingCount == 8)
                    {
                        allEvent.HappyEnd();
                        ui.ShowHappyEnding();
                        Console.ReadLine();
                        break;
                    }
                    else if (allEvent.badEndingCount == 4)
                    {
                        allEvent.BadEnd();
                        ui.ShowBadEnding();
                        Console.ReadLine();

                        break;
                    }

                   
                }
            }
        }
    }
}
