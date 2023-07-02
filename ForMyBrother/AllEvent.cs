using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    //컨트롤 넘버 34까지 쓰임
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
                Console.SetCursorPosition(8, 10+(j%4)*2);
                Ui.uiPrintEvent(pText.pllQuestion1[j].chName, pText.pllQuestion1[j].chText, 60);
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
            for (int j = 0; j < 4; j++)
            {
                Console.SetCursorPosition(8, 10+(j%4)*2);
                Ui.uiPrintEvent(pText.pllQuestion2[j].chName, pText.pllQuestion2[j].chText, 60);
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
            for (int j = 0; j < 9; j++)
            {
                Console.SetCursorPosition(8, 10+(j%10)*2);
                Ui.uiPrintEvent(pText.pllQuestion3[j].chName, pText.pllQuestion3[j].chText, 60);
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
                Console.SetCursorPosition(30, 10);
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

        public void ShopClose1()
        {
            for (int j = 14; j < 18; j++)
            {
                Ui.rollText(pText.shopText[j].chName, pText.shopText[j].chText, 60);
                Console.ReadLine();
            }
        }
        public void ShopClose2()
        {
            for (int j = 18; j < 21; j++)
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
            for (int j = 0; j < pText.mainEvent1.Count; j++)
            {
                Console.SetCursorPosition(1, 20+(j%4)*2);
                Ui.TextAPEvent(pText.mainEvent1[j].chText, 50);
                Console.ReadLine();
            }
            chBtn.SettingTwoChoice("기습한다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(27, 28);
            if (chBtn.choiceControlNum == 27)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 28)
            {
                endingCount +=1;
            }
        }
        #endregion
        #region 노멀이벤트
        public void Nevent001()//아니 이;건 사실 히든 이벤트다!
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
            chBtn.SettingTwoChoice("주의를 준다", "지나친다");
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
            for (int j = 0; j < pText.normalEvent004.Count; j++)
            {
                if (pText.normalEvent004[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent004[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                   
                    Ui.rollText(pText.normalEvent004[j].chName, pText.normalEvent004[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("고등어를 준다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(33, 34);
            if (chBtn.choiceControlNum == 33)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 34)
            {
                endingCount +=1;
            }
        }
        public void Nevent005()
        {
            for (int j = 0; j < 7; j++)
            {
                if (pText.normalEvent005[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent005[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent005[j].chName, pText.normalEvent005[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("음식을 준다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(35, 36);
            if (chBtn.choiceControlNum == 35)
            {
                for (int j = 7; j < pText.normalEvent005.Count; j++)
                {
                    if (pText.normalEvent005[j].chName == "시스템")
                    {
                        if (j %4 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent005[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent005[j].chName, pText.normalEvent005[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 36)
            {
                endingCount +=1;
            }
        }
        public void Nevent006()
        {
            for (int j = 0; j < pText.normalEvent006.Count; j++)
            {
                if (pText.normalEvent006[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent006[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {

                    Ui.rollText(pText.normalEvent006[j].chName, pText.normalEvent006[j].chText, 50);
                    Console.ReadLine();
                }
            }
            //안좋은 이벤트 
           
            endingCount +=1;
        }
        public void Nevent007()
        {
            for (int j = 0; j < pText.normalEvent007.Count; j++)
            {
                if (pText.normalEvent007[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent007[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {

                    Ui.rollText(pText.normalEvent007[j].chName, pText.normalEvent007[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("뭐가 있는지 살펴본다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(37, 38);
            if (chBtn.choiceControlNum == 37)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 38)
            {
                endingCount +=1;
            }
        }
        public void Nevent008()
        {
            for (int j = 0; j < pText.normalEvent008.Count; j++)
            {
                if (pText.normalEvent008[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent008[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {

                    Ui.rollText(pText.normalEvent008[j].chName, pText.normalEvent008[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("기도한다", "부순다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(39, 40);
            if (chBtn.choiceControlNum == 39)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 40)
            {
                endingCount +=1;
            }
        }
        public void Nevent009()
        {
            for (int j = 0; j < pText.normalEvent009.Count; j++)
            {
                if (pText.normalEvent009[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent009[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {

                    Ui.rollText(pText.normalEvent009[j].chName, pText.normalEvent009[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("의뢰를 받는다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(41, 42);
            if (chBtn.choiceControlNum == 41)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 42)
            {
                endingCount +=1;
            }
        }
        public void Nevent010()
        {
            for (int j = 0; j < pText.normalEvent010.Count; j++)
            {
                if (pText.normalEvent010[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent010[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {

                    Ui.rollText(pText.normalEvent010[j].chName, pText.normalEvent010[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("치안대를 부른다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(43, 44);
            if (chBtn.choiceControlNum == 43)
            {
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 44)
            {
                endingCount +=1;
            }
        }
        public void Nevent011()
        {
            for (int j = 0; j < 9; j++)
            {
                if (pText.normalEvent011[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent011[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent011[j].chName, pText.normalEvent011[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("바닥에 놓여있는 컵라면 통을 던진다", "도망친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(45, 46);
            if (chBtn.choiceControlNum == 45)
            {
                for (int j = 9; j < pText.normalEvent011.Count; j++)
                {
                    if (pText.normalEvent011[j].chName == "시스템")
                    {
                        if (j %4 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent011[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent011[j].chName, pText.normalEvent011[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 46)
            {
                endingCount +=1;
            }
        }
        public void Nevent012()
        {
            for (int j = 0; j < 5; j++)
            {
                if (pText.normalEvent012[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent012[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent012[j].chName, pText.normalEvent012[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("고개를 힘겹게 내젓는다", "힘차게 끄덕인다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(47, 48);
            if (chBtn.choiceControlNum == 47)
            {
                for (int j = 5; j < pText.normalEvent012.Count; j++)
                {
                    if (pText.normalEvent012[j].chName == "시스템")
                    {
                        if (j %4 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent012[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent012[j].chName, pText.normalEvent012[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 48)
            {
                endingCount +=1;
            }
        }
        public void Nevent013()
        {
            for (int j = 0; j < pText.normalEvent013.Count; j++)
            {
                if (pText.normalEvent013[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent013[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent013[j].chName, pText.normalEvent013[j].chText, 50);
                    Console.ReadLine();
                }
            }
            endingCount +=1;
        }
        public void Nevent014()
        {
            for (int j = 0; j < pText.normalEvent014.Count; j++)
            {
                if (pText.normalEvent014[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent014[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent014[j].chName, pText.normalEvent014[j].chText, 50);
                    Console.ReadLine();
                }
            }
            endingCount += 1;
        }
        public void Nevent015()
        {
            for (int j = 0; j < 5; j++)
            {
                if (pText.normalEvent015[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent015[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent015[j].chName, pText.normalEvent015[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("하지만 바쁘다, 떠난다", "아직도 옛일을 신경쓰고 있어? 괜찮아. ");
            chBtn.PrintChoice();
            chBtn.ControlChoice(49, 50);
            if (chBtn.choiceControlNum == 49)
            {
                for (int j = 5; j < pText.normalEvent015.Count; j++)
                {
                    if (pText.normalEvent015[j].chName == "시스템")
                    {
                        if (j %4 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent015[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent015[j].chName, pText.normalEvent015[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 50)
            {
                endingCount +=1;
            }
        }
        public void Nevent016()
        {
            for (int j = 0; j < 2; j++)
            {
                if (pText.normalEvent016[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%3)*2);
                    Ui.TextAPEvent(pText.normalEvent016[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent016[j].chName, pText.normalEvent016[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("사람인가? 도와주세요!", "괴물이다 도망쳐!");
            chBtn.PrintChoice();
            chBtn.ControlChoice(51, 52);
            if (chBtn.choiceControlNum == 51)
            {
                for (int j = 3; j < pText.normalEvent016.Count; j++)
                {
                    if (pText.normalEvent016[j].chName == "시스템")
                    {
                        if (j %9 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%3)*2);
                        Ui.TextAPEvent(pText.normalEvent016[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent016[j].chName, pText.normalEvent016[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                //hp회복
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 52)
            {
                //전투 발생
                endingCount +=1;
            }
        }
        public void Nevent017()
        {
            for (int j = 0; j < 4; j++)
            {
                if (pText.normalEvent017[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent017[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent017[j].chName, pText.normalEvent017[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("그래 함께 해볼까?", "아 미안, 시간이 없어.");
            chBtn.PrintChoice();
            chBtn.ControlChoice(53, 54);
            if (chBtn.choiceControlNum == 53)
            {
                for (int j = 4; j < pText.normalEvent017.Count; j++)
                {
                    if (pText.normalEvent017[j].chName == "시스템")
                    {
                        if (j %5 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent017[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent017[j].chName, pText.normalEvent017[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 54)
            {
                endingCount +=1;
            }
        }
        public void Nevent018()
        {
            for (int j = 0; j < 2; j++)
            {
                if (pText.normalEvent018[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent018[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent018[j].chName, pText.normalEvent018[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("당겨본다", "지나친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(55, 56);
            if (chBtn.choiceControlNum == 55)
            {
                for (int j = 2; j < 8; j++)
                {
                    if (pText.normalEvent018[j].chName == "시스템")
                    {
                        if (j %2 == 0 || j % 7 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent018[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent018[j].chName, pText.normalEvent018[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                chBtn.SettingTwoChoice("용서한다", "협박한다");
                chBtn.PrintChoice();
                chBtn.ControlChoice(57, 58);
                if (chBtn.choiceControlNum == 57)
                {
                    for (int j = 8; j < pText.normalEvent018.Count; j++)
                    {
                        if (pText.normalEvent018[j].chName == "시스템")
                        {
                            if (j %9 == 0)
                            {
                                Ui.MiddleClearUi();
                            }
                            Console.SetCursorPosition(3, 10+(j%4)*2);
                            Ui.TextAPEvent(pText.normalEvent018[j].chText, 50);
                            Console.ReadLine();
                        }
                        else
                        {
                            Ui.rollText(pText.normalEvent018[j].chName, pText.normalEvent018[j].chText, 50);
                            Console.ReadLine();
                        }
                    }
                }
                else if(chBtn.choiceControlNum ==58)
                {
                    //hp 소모
                    endingCount +=1;
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 56)
            {
                endingCount +=1;
            }
        }
        public void Nevent019()
        {
            for (int j = 0; j < 5; j++)
            {
                if (pText.normalEvent019[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent019[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent019[j].chName, pText.normalEvent019[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("당당하게 맞선다", "도망친다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(59, 60);
            if (chBtn.choiceControlNum == 59)
            {
                for (int j = 5; j < pText.normalEvent019.Count; j++)
                {
                    if (pText.normalEvent019[j].chName == "시스템")
                    {
                        if (j %5 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%5)*2);
                        Ui.TextAPEvent(pText.normalEvent019[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent019[j].chName, pText.normalEvent019[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 60)
            {
                endingCount +=1;
                //게임종료 엔딩
            }
        }
        public void Nevent020()
        {
            for (int j = 0; j < 5; j++)
            {
                if (pText.normalEvent020[j].chName == "시스템")
                {
                    if (j %4 == 0)
                    {
                        Ui.MiddleClearUi();
                    }
                    Console.SetCursorPosition(3, 10+(j%4)*2);
                    Ui.TextAPEvent(pText.normalEvent020[j].chText, 50);
                    Console.ReadLine();
                }
                else
                {
                    Ui.rollText(pText.normalEvent020[j].chName, pText.normalEvent020[j].chText, 50);
                    Console.ReadLine();
                }
            }
            chBtn.SettingTwoChoice("변명한다", "도주한다");
            chBtn.PrintChoice();
            chBtn.ControlChoice(61, 62);
            if (chBtn.choiceControlNum == 61)
            {
                for (int j = 5; j < pText.normalEvent020.Count; j++)
                {
                    if (pText.normalEvent020[j].chName == "시스템")
                    {
                        if (j %4 == 0)
                        {
                            Ui.MiddleClearUi();
                        }
                        Console.SetCursorPosition(3, 10+(j%4)*2);
                        Ui.TextAPEvent(pText.normalEvent020[j].chText, 50);
                        Console.ReadLine();
                    }
                    else
                    {
                        Ui.rollText(pText.normalEvent020[j].chName, pText.normalEvent020[j].chText, 50);
                        Console.ReadLine();
                    }
                }
                endingCount +=1;
            }
            else if (chBtn.choiceControlNum == 62)
            {
                endingCount +=1;
            }
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
                Nevent004();
            }
            else if (randomNumber == 5)
            {
                Nevent005();
            }
            else if (randomNumber == 6)
            {
                Nevent006();
            }
            else if (randomNumber == 7)
            {
                Nevent007();
            }
            else if (randomNumber == 8)
            {
                Nevent008();
            }
            else if (randomNumber == 9)
            {
                Nevent009();
            }
            else if (randomNumber == 10)
            {
                Nevent010();
            }
            else if (randomNumber == 11)
            {
                Nevent011();
            }
            else if (randomNumber == 12)
            {
                Nevent012();
            }
            else if (randomNumber == 13)
            {
                Nevent013();
            }
            else if (randomNumber == 14)
            {
                Nevent014();
            }
            else if (randomNumber == 15)
            {
                Nevent015();
            }
            else if (randomNumber == 16)
            {
                Nevent016();
            }
            else if (randomNumber == 17)
            {
                Nevent017();
            }
            else if (randomNumber == 18)
            {
                Nevent018();
            }
            else if (randomNumber == 19)
            {
                Nevent019();
            }
            else if (randomNumber == 20)
            {
                Nevent020();
            }
            //else if (randomNumber == 21)
            //{

            //}
            //else if (randomNumber == 22)
            //{

            //}
            //else if (randomNumber == 23)
            //{

            //}
            //else if (randomNumber == 24)
            //{

            //}
            //else if (randomNumber == 25)
            //{

            //}
            //else if (randomNumber == 26)
            //{

            //}
            //else if (randomNumber == 27)
            //{

            //}
            //else if (randomNumber == 28)
            //{

            //}
            //else if (randomNumber == 29)
            //{

            //}
            //else if (randomNumber == 30)
            //{

            //}

        }
    }
}
