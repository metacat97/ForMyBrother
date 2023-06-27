using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class everyText
    { 
        public List<textBase> userText = new List<textBase>(); 
        public static string userText001 = "주인공 : 잘 모르겠어.";
       
        public everyText() 
        {
            textBase utext000 = new textBase();
            utext000.InitText(1, "주인공", "나는... 집으로 돌아가는 길에");
            userText.Add(utext000);

            textBase  utext001 = new textBase();
            utext001.InitText(1, "주인공", "아아아아아아아아아아아아아아앜");
            userText.Add(utext001);

            textBase utext002 = new textBase();
            utext002.InitText(1, "주인공", "아아아-------------------앜");
            userText.Add(utext002);

            textBase utext003 = new textBase();
            utext003.InitText(1, "주인공", "그래서 언제까지 떨어져야 하는건데?");
            userText.Add(utext003);

            textBase utext004 = new textBase();
            utext004.InitText(1, "주인공", "일단 떨어지는 중이긴한데");
            userText.Add(utext004);

            textBase utext005 = new textBase();
            utext005.InitText(1, "주인공", "아무리 생각해도 말이야");
            userText.Add(utext005);

            textBase utext006 = new textBase();
            utext006.InitText(1, "주인공", "모든 것을 생각하지 않게끔");
            userText.Add(utext006);
            
            textBase utext007 = new textBase();
            utext007.InitText(1, "주인공", "그?");
            userText.Add(utext007);

            textBase utext008 = new textBase();
            utext008.InitText(1, "주인공", "래서 ");
            userText.Add(utext008);

            textBase utext009 = new textBase();
            utext009.InitText(1, "주인공", "언제까지 떨어져야 하는건데?");
            userText.Add(utext009);
        }


    }
}
