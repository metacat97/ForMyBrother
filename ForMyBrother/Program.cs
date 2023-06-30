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
                ui.setUi();//콘솔창 크기 고정
                ui.PrintUi();//처음 도화지 출력
                ui.PrintTitle(); // 타이틀 로고 출력
                button.PrintButton();//버튼 첫 출력
                button.ControlButton();//버튼 제어 기능 - 게임 종료를 누르면 break

                Console.Clear();//지워주고

                //ui.resizeUi(110, 40);//사이즈 재조정
                //allEvent.Prololog();//프롤로그 텍스트 출력
                //allEvent.PllQ1(user);//스테이터스 질문 1
                //Console.Clear();
                //allEvent.PllQ2(user);// 스테이터스 질문 2
                //Console.Clear();
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
                    ui.PrintText();
                    //Console.ReadLine();
                    #endregion;
                    //allEvent.GuideMessage();
                    chButton.SetThree("무작위 이벤트", "던전","상점");
                    chButton.PrintThree();
                    chButton.ControlThree(6, 7,8,user);
                    if (chButton.choiceControlNum == 6)//6이면 무작위 이벤트 출력
                    {
                        alleventCount += 1;
                        ui.MiddleClearUi();//여기다가 중앙화면만 지워주는 공백 그려줄려고요
                        if (alleventCount == 1)
                        {
                            allEvent.event001(); //이벤트 텍스트 모음 출력
                        }
                        normalCount = rand.Next(1, 10);
                       // Console.ReadLine();
                        allEvent.EventControl(normalCount);
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
                        //if (shopMeetCount == 0)
                        //{
                        //    allEvent.ShopOpen1();
                        //    shopMeetCount = 1;
                        //}
                        //else if (shopMeetCount == 1)
                        //{
                        //    allEvent.ShopOpen2();
                        //}
                        showItems.MarketUi(showItems.Item);
                        showItems.Purchase(user);
                        ui.MiddleClearUi();
                       // allEvent.ShopClose();

                        
                    }
                    
                    if (allEvent.endingCount == 4)
                    {
                        allEvent.ending001();
                        break;
                    }
                    else if (allEvent.endingCount == 5)
                    {
                        allEvent.ending002();
                        break;
                    }

                   
                }
            }
        }
    }
}
