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

            while (true)
            {
                allEvent.endingCount = 0;
                //showItems.addItem();
                ui.setUi();//콘솔창 크기 고정
                ui.PrintUi();//처음 도화지 출력
                ui.PrintTitle(); // 타이틀 로고 출력
                button.PrintButton();//버튼 첫 출력
                button.ControlButton();//버튼 제어 기능 - 게임 종료를 누르면 break
                while (true)
                {
                    ui.setUi();//콘솔창 크기 고정
                    ui.PrintUi(); //비유하자면 도화지  출력
                    /*
                     여기는 스토리 프롤로그 출력 명령문 들어가야합니다.
                     */
                    ui.statBorder();
                    ui.PrintStatus(user); //능력치 변환 ui 테스트 
                    #region 유저 텍스트 테두리
                    ui.userTextBorder();
                    ui.userProfileBorder();
                    ui.PrintText();
                    Console.ReadLine();
                    #endregion;
                    allEvent.prolog();
                    chButton.SetThree("무작위 이벤트", "던전","상점");
                    chButton.PrintThree();
                    chButton.ControlThree(6, 7,8);
                    if (chButton.choiceControlNum == 6)//6이면 무작위 이벤트 출력
                    {
                        //여기다가 중앙화면만 지워주는 공백 그려줄려고요
                        allEvent.event001(); //이벤트 텍스트 모음 출력
                    }
                    else if (chButton.choiceControlNum == 7)
                    {
                        //Console.ReadLine();

                        Console.Clear();
                        ui.resizeUi(60, 38); //사이즈 재조정
                        map.drawMap(user);

                    }
                    else if (chButton.choiceControlNum ==8)
                    {
                        //상점을 보여줄 차례
                    }
                    //Console.ReadLine();
                    if (allEvent.endingCount == 1)
                    {
                        allEvent.ending001();
                        break;
                    }
                    else if (allEvent.endingCount == 2)
                    {
                        allEvent.ending002();
                        break;
                    }



                    //게임의 시작
                    //user.LevelUp(); //테스트 레벨업 
                    //Console.ReadLine();
                    //ui.PrintStatus(user.healthPoint, user.willPower, user.strong, user.wisdom, user.speed, user.luck);// 다시 스텟 출력

                    //printEvent.eventText01();
                }
            }
        }
    }
}
