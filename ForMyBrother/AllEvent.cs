using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class AllEvent
    {

        mainUI Ui = new mainUI();
        everyText pText = new everyText();
        
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
        }
        public void event002()
        {

        }

        public void ending001()
        {

        }
        public void ending002() 
        {
        
        }
    }
}
