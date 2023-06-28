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
        public void prolog()
        {
            for (int j = 0; j < 2; j++)
            {
                Ui.uiPrintEvent(pText.etc1Text[j].chName, pText.etc1Text[j].chText, 50);
                Console.ReadLine();
            }
        }
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
    }
}
