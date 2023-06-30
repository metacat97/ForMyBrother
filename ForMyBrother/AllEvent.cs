using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    //컨트롤 넘버 20까지 쓰임
    public class AllEvent
    {

        public int endingCount { get; set; }
        mainUI Ui = new mainUI();
        everyText pText = new everyText();
        choiceButton chBtn = new choiceButton(); //chBtn은 choiceButton의 약자 입니다.
        #region 프롤로그와 질문 이벤트
        public void Prololog()
        {
            for (int j = 0; j < 15; j++)
            {
                Ui.uiPrintEvent(pText.prololog[j].chName, pText.prololog[j].chText, 60);
                Console.ReadLine();
            }
        }
        public void PllQ1(User player)
        {
            for (int j = 0; j < 2; j++)
            {
                Ui.uiPrintEvent(pText.pllQuestion[j].chName, pText.pllQuestion[j].chText, 60);
                Console.ReadLine();
            }
            chBtn.SetThree("심준보", "유준호", "박준오");
            chBtn.PrintThree();
            chBtn.ControlThree(11, 12, 13, player);
            if (chBtn.choiceControlNum == 11)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum == 12)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum== 13)
            {
                player.UpStat();
            }
        }
        public void PllQ2(User player)
        {
            for (int j = 2; j < 6; j++)
            {
                Ui.uiPrintEvent(pText.pllQuestion[j].chName, pText.pllQuestion[j].chText, 60);
                Console.ReadLine();
            }
            chBtn.SetThree("답변1", "답변2", "답변3");
            chBtn.PrintThree();
            chBtn.ControlThree(14, 15, 16, player);
            if (chBtn.choiceControlNum == 14)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum == 15)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum== 16)
            {
                player.UpStat();
            }
        }
        public void PllQ3(User player)
        {
            for (int j = 6; j < 15; j++)
            {
                Ui.uiPrintEvent(pText.pllQuestion[j].chName, pText.pllQuestion[j].chText, 60);
                Console.ReadLine();
            }
            chBtn.SetThree("답변1", "답변2", "답변3");
            chBtn.PrintThree();
            chBtn.ControlThree(17, 18, 19, player);
            if (chBtn.choiceControlNum == 17)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum == 18)
            {
                player.UpStat();
            }
            else if (chBtn.choiceControlNum== 19)
            {
                player.UpStat();
            }
        }

        public void GuideMessage()
        {
            for (int j = 0; j < 2; j++)
            {
                Ui.uiPrintEvent(pText.etc1Text[j].chName, pText.etc1Text[j].chText, 50);
                Console.ReadLine();
            }
        }
        #endregion
        #region 상점 이벤트
        public void ShopOpen1()
        {
            for (int j = 0; j < 14; j++)
            {
                Ui.rollText(pText.shopText[j].chName, pText.shopText[j].chText, 60);
                Console.ReadLine();
            }
        }
        public void ShopOpen2()
        {
            for (int j = 8; j < 14; j++)
            {
                Ui.rollText(pText.shopText[j].chName, pText.shopText[j].chText, 50);
                Console.ReadLine();
            }
        }

        public void ShopClose()
        {
            for (int j = 14; j < 18; j++)
            {
                Ui.rollText(pText.shopText[j].chName, pText.shopText[j].chText, 60);
                Console.ReadLine();
            }
        }
        #endregion

        #region 메인 이벤트
        public void event001()
        {
            for (int j = 0; j < 10; j++)
            {
                Ui.rollText(pText.userText[j].chName, pText.userText[j].chText, 50);
                Console.ReadLine();
            }
            chBtn.SettingTwoChoice(" 왼쪽 ", "오른쪽");
            chBtn.PrintChoice();
            chBtn.ControlChoice(9, 10);
            if (chBtn.choiceControlNum == 9)
            {
                endingCount += 1;
            }
            else if (chBtn.choiceControlNum == 10)
            {
                endingCount += 2;
            }

        }
        public void event002()
        {

        }
        #endregion
        #region 노멀이벤트
        public void Nevent001()
        {
            for (int j = 0; j < 81; j++)
            {
                Ui.rollText(pText.normalEvent001[j].chName, pText.normalEvent001[j].chText, 50);
                Console.ReadLine();
            }
            chBtn.SettingTwoChoice("그들이 올 때까지 기다린다", "내가 찾아간다.");
            chBtn.PrintChoice();
            chBtn.ControlChoice(21, 22);
            if (chBtn.choiceControlNum == 21)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 22)
            {
                endingCount +=1;
            }
        }
        public void Nevent002()
        {
            for (int j = 0; j < pText.normalEvent002.Count; j++)
            {
                Console.SetCursorPosition(1, 20+(j%4)*2);
                Ui.TextAPEvent(pText.normalEvent002[j].chText, 50);
                Console.ReadLine();

            }



            chBtn.SettingTwoChoice("기습한다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(23, 24);
            if (chBtn.choiceControlNum == 23)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 24)
            {
                endingCount +=1;
            }
        }
        public void Nevent003()
        {
            for (int j = 0; j < 7; j++)
            {
                if(j %7 == 0)
                {
                    Ui.MiddleClearUi();
                }
                Console.SetCursorPosition(2, 12+(j%7)*2);
                Ui.TextAPEvent(pText.normalEvent003[j].chText, 50);
                Console.ReadLine();
            }
            chBtn.SettingTwoChoice("지나친다", "무슨 일인지 물어본다.");
            chBtn.PrintChoice();
            chBtn.ControlChoice(25, 26);
            if (chBtn.choiceControlNum == 25)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 26)
            {
                for (int j = 7; j < 14; j++)
                {
                    if (j %7 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(2, 12+(j%7)*2);
                    Ui.TextAPEvent(pText.normalEvent003[j].chText, 50);
                    Console.ReadLine();
                }
                chBtn.SettingTwoChoice("그래 얼마든지", "귀찮게 굴지마");
                chBtn.PrintChoice();
                chBtn.ControlChoice(27, 28);
                if (chBtn.choiceControlNum == 27)
                {
                    for (int j = 14; j < 49; j++)
                    {
                        if (j %7 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(2, 12+(j%7)*2);
                        Ui.TextAPEvent(pText.normalEvent003[j].chText, 50);
                        Console.ReadLine();
                    }
                    chBtn.SettingTwoChoice("싸운다", "도망친다");
                    chBtn.PrintChoice();
                    chBtn.ControlChoice(31, 32);
                    if (chBtn.choiceControlNum == 31)
                    {
                        endingCount  +=1;
                    }
                    else if (chBtn.choiceControlNum == 32)
                    {
                        endingCount -=1;
                    }
                }
                else if (chBtn.choiceControlNum == 28)
                {
                    endingCount +=1;

                }

            }
        }
        public void Nevent004()
        {

        }
        public void Nevent005()
        {

        }
        public void Nevent006()
        {

        }
        public void Nevent007()
        {

        }
        public void Nevent008()
        {

        }
        public void Nevent009()
        {

        }
        public void Nevent010()
        {

        }





        #endregion

        #region 엔딩 이벤트
        public void ending001()
        {
            Console.Clear();
            Console.WriteLine("덕분에 좋아졌어");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Happy End");
            Console.ReadLine();

        }
        public void ending002()
        {
            Console.Clear();
            Console.WriteLine("게임은 끝났어");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Bad End");
            Console.ReadLine();


        }
        #endregion

        #region 던전 이벤트
        public void DGEvent001()
        {
            Console.Clear();
            Console.WriteLine("덕분에 좋아졌어");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Happy End");
            Console.ReadLine();

        }
        public void DGEvent002()
        {
            Console.Clear();
            Console.WriteLine("덕분에 좋아졌어");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Happy End");
            Console.ReadLine();

        }


        #endregion

        public void EventControl(int randomNumber)
        {
            if (randomNumber == 1)
            {
                //Nevent001();
            }
            else if (randomNumber == 2)
            {
                Nevent002();
            }
            else if (randomNumber == 3)
            {
                Nevent003();
            }
            else if (randomNumber == 4)
            {

            }
            else if (randomNumber == 5)
            {

            }
            else if (randomNumber == 6)
            {

            }
            else if (randomNumber == 7)
            {

            }
            else if (randomNumber == 8)
            {

            }
            else if (randomNumber == 9)
            {

            }
            else if (randomNumber == 10)
            {

            }
            else if (randomNumber == 11)
            {

            }
            else if (randomNumber == 12)
            {

            }
            else if (randomNumber == 13)
            {

            }
            else if (randomNumber == 14)
            {

            }
            else if (randomNumber == 15)
            {

            }
            else if (randomNumber == 16)
            {

            }
            else if (randomNumber == 17)
            {

            }
            else if (randomNumber == 18)
            {

            }
            else if (randomNumber == 19)
            {

            }
            else if (randomNumber == 20)
            {

            }
            else if (randomNumber == 21)
            {

            }
            else if (randomNumber == 22)
            {

            }
            else if (randomNumber == 23)
            {

            }
            else if (randomNumber == 24)
            {

            }
            else if (randomNumber == 25)
            {

            }
            else if (randomNumber == 26)
            {

            }
            else if (randomNumber == 27)
            {

            }
            else if (randomNumber == 28)
            {

            }
            else if (randomNumber == 29)
            {

            }
            else if (randomNumber == 30)
            {

            }

        }
    }
}
