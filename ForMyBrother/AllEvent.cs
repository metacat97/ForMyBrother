using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class AllEvent
    {
        public int endingCount { get; set; }
        mainUI Ui = new mainUI();
        everyText pText = new everyText();
        choiceButton chBtn = new choiceButton(); //chBtn은 choiceButton의 약자 입니다.
        #region 프롤로그 이벤트
        public void Prololog()
        {
            for (int j = 0; j < 15; j++)
            {
                Ui.uiPrintEvent(pText.prololog[j].chName, pText.prololog[j].chText,60);
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
            chBtn.ControlThree(11, 12, 13);
            if (chBtn.choiceControlNum == 11)
            {
                player.UpStat();
            }
            else if(chBtn.choiceControlNum == 12)
            {
                player.UpStat();
            }
            else if(chBtn.choiceControlNum== 13) 
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
            chBtn.ControlThree(14, 15, 16);
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
            chBtn.ControlThree(17, 18, 19);
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
        #region 메인 이벤트
        public void event001()
        {
            for (int j = 0; j < 10; j++)
            {
                Ui.rollText(pText.userText[j].chName, pText.userText[j].chText,50);
                Console.ReadLine();
            }
            chBtn.SettingTwoChoice("몸에 힘을 주고 팔을 벌린다.", "모르겠다 그냥 포기하자");
            chBtn.PrintChoice();
            chBtn.ControlChoice(9,10);
            if (chBtn.choiceControlNum == 9)
            {
                endingCount = 1;
            }
            else if (chBtn.choiceControlNum == 10)
            { 
                endingCount = 2;
            }

        }
        public void event002()
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
    }
}
