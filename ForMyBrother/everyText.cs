using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class everyText
    { 
        public List<textBase> prololog = new List<textBase>();
        public List<textBase> pllQuestion = new List<textBase>();//프롤로그 질문 스크립트 담아놓은 리스트입니다.
        public List<textBase> userText = new List<textBase>(); 
        public List<textBase> mainEvent = new List<textBase>(); 
        public List<textBase> etc1Text = new List<textBase>();
        public List<textBase> etc2Text = new List<textBase>();
        public everyText()
        {
            #region 프롤로그
            textBase pll000 = new textBase();//prololog = pll 로 줄여서 변수 선언 했습니다.
            pll000.InitText(2, "누군가", "   안녕하세요.  ○○○님           ");
            prololog.Add(pll000);

            textBase pll001 = new textBase();
            pll001.InitText(2, "누군가", "아..(lament) 염치없지만 제 소개는 나중에 해드리겠습니다.");
            prololog.Add(pll001);

            textBase pll002 = new textBase();
            pll002.InitText(2, "누군가", "정말 혼란스러우시겠지만 시간이 없어서 본론만 말씀드릴게요");
            prololog.Add(pll002);

            textBase pll003 = new textBase();
            pll003.InitText(2, "누군가", "지금부터 당신은 스카실 마을의 딜라 브레타가 되서");
            prololog.Add(pll003);

            textBase pll004 = new textBase();
            pll004.InitText(2, "누군가", "브레타의 동생 '딜라 로스토'에게 염원이 담긴 물건을 주셨으면 합니다.");
            prololog.Add(pll004);

            textBase pll005 = new textBase();
            pll005.InitText(2, "누군가", "일의 시작에 앞서 최소한의 조작 방법과 할 일들을 안내해드리겠습니다.");
            prololog.Add(pll005);

            textBase pll007 = new textBase();
            pll007.InitText(2, "누군가", "우선 이벤트 대화는 한 번 밖에 들을 수 없으니 주의해주세요.");
            prololog.Add(pll007);
            
            textBase pll008 = new textBase();
            pll008.InitText(2, "누군가", "이벤트는 총 25회를 보시거나");
            prololog.Add(pll008);

            textBase pll009 = new textBase();
            pll009.InitText(2, "누군가", "특정 이벤트 분기에서 조건을 달성하시는 경우");
            prololog.Add(pll009);

            textBase pll010 = new textBase();
            pll010.InitText(2, "누군가", "당신의 HP 혹은 WP가 '0'이 되실 경우에는 사망하시게 되어");
            prololog.Add(pll010);

            textBase pll00 = new textBase();
            pll00.InitText(2, "누군가", "게임이 끝나게 됩니다.");
            prololog.Add(pll00);

            textBase pll011 = new textBase();
            pll011.InitText(2, "누군가", "지금부터 당신의 특성을 결정하실 수 있는 질문 4가지를 드릴겁니다.");
            prololog.Add(pll011); 
            
            textBase pll012 = new textBase();
            pll012.InitText(2, "누군가", " 편하게 골라주세요.        ");
            prololog.Add(pll012);

            textBase pll013 = new textBase();
            pll013.InitText(2, "누군가", "...................그러면");
            prololog.Add(pll013);

            textBase pll014 = new textBase();
            pll014.InitText(2, "누군가", "당신에게 행운이 있기를........");
            prololog.Add(pll014);
            #endregion
            #region 프롤로그 스텟 선택 질문
            textBase pllQ000 = new textBase();//prolologQuestion = pllQ 로 줄여서 변수 선언 했습니다.
            pllQ000.InitText(2, "질문", "당신은 길을 걷다가 파란 슬리퍼 한 짝을 발견했다.");
            pllQuestion.Add(pllQ000);

            textBase pllQ001 = new textBase();
            pllQ001.InitText(2, "질문", "누구의 슬리퍼일까?");
            pllQuestion.Add(pllQ001);

            textBase pllQ002 = new textBase();
            pllQ002.InitText(2, "질문", "사람은 언제 죽는다고 생각하는가?");
            pllQuestion.Add(pllQ002);

            textBase pllQ003 = new textBase();
            pllQ003.InitText(2, "답변1", "여러 가지 상황을 고려해 봐야 한다.");
            pllQuestion.Add(pllQ003);

            textBase pllQ004 = new textBase();
            pllQ004.InitText(2, "답변2", "모두에게 잊혔을 때 죽었다고 볼 수 있다.");
            pllQuestion.Add(pllQ004);

            textBase pllQ005 = new textBase();
            pllQ005.InitText(2, "답변3", "모르겠고, 지금 죽을 것 같다.");
            pllQuestion.Add(pllQ005);

            textBase pllQ007 = new textBase();
            pllQ007.InitText(2, "질문", "사막을 걷다가 모래 폭풍 사이로 사람의 모습이 보였다.");
            pllQuestion.Add(pllQ007);

            textBase pllQ008 = new textBase();
            pllQ008.InitText(2, "질문", "가까이 다가가니 말을 걸어온다.");
            pllQuestion.Add(pllQ008);

            textBase pllQ009 = new textBase();
            pllQ009.InitText(2, "질문", "자신은 사막의 탑을 정복한 이경민이라 소개한다.");
            pllQuestion.Add(pllQ009);

            textBase pllQ010 = new textBase();
            pllQ010.InitText(2, "질문", "마을로 돌아가는 길을 잃어서 곤란해 하던 중인데");
            pllQuestion.Add(pllQ010);

            textBase pllQ011 = new textBase();
            pllQ011.InitText(2, "질문", "도움을 받을 수 있는지 물어보며 괴로운 표정을 짓는다.");
            pllQuestion.Add(pllQ011);

            textBase pllQ012 = new textBase();
            pllQ012.InitText(2, "질문", "어떻게 하면 좋을까?");
            pllQuestion.Add(pllQ012);

            textBase pllQ013 = new textBase();
            pllQ013.InitText(2, "답변1", "당장 도와준다");
            pllQuestion.Add(pllQ013);

            textBase pllQ014 = new textBase();
            pllQ014.InitText(2, "답변2", "사과하고 그냥 지나친다");
            pllQuestion.Add(pllQ014);

            textBase pllQ015 = new textBase();
            pllQ015.InitText(2, "답변3", "물러나라!!");
            pllQuestion.Add(pllQ015);

            #endregion

            #region 주인공 대사 모음집
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
            utext004.InitText(1, "주인공", "읔...........");
            userText.Add(utext004);

            textBase utext005 = new textBase();
            utext005.InitText(1, "주인공", "2");
            userText.Add(utext005);

            textBase utext006 = new textBase();
            utext006.InitText(1, "주인공", "3");
            userText.Add(utext006);
            
            textBase utext007 = new textBase();
            utext007.InitText(1, "주인공", "4");
            userText.Add(utext007);

            textBase utext008 = new textBase();
            utext008.InitText(1, "주인공", "5");
            userText.Add(utext008);

            textBase utext009 = new textBase();
            utext009.InitText(1, "주인공", "6");
            userText.Add(utext009);
            #endregion


            #region 중요 이벤트 대사 모음
            textBase mainEvent100 = new textBase();
            mainEvent100.InitText(2, "시스템", "당신은 길을 걷다가 ");
            #endregion


            #region etc1 처음 메인화면 시스템 대사 모음집
            textBase etcText000 = new textBase();
            etcText000.InitText(3, "시스템", "어서오세요");
            etc1Text.Add(etcText000);
            textBase etcText001 = new textBase();
            etcText001.InitText(3, "시스템", "오늘은 무엇을 하실 계획이신가요?");
            etc1Text.Add(etcText001);
            #endregion

            #region etc2 
            textBase etc2Text000 = new textBase();
            etc2Text000.InitText(3, "시스템", "어서오세요1");
            etc2Text.Add(etc2Text000);

            textBase etc2Text001 = new textBase();
            etc2Text001.InitText(3, "시스템", "어서오세요12");
            etc2Text.Add(etc2Text001);
            textBase etc2Text002 = new textBase();
            etc2Text002.InitText(3, "시스템", "어서오세요2");
            etc2Text.Add(etc2Text002);
            textBase etc2Text003 = new textBase();
            etc2Text003.InitText(3, "시스템", "어서오세요3");
            etc2Text.Add(etc2Text003);
            #endregion


        }


    }
}

