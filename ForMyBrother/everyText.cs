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
        #region 메인 이벤트 5개 리스트
        public List<textBase> mainEvent = new List<textBase>();
        public List<textBase> mainEvent1 = new List<textBase>();
        public List<textBase> mainEvent2 = new List<textBase>();
        public List<textBase> mainEvent3 = new List<textBase>();
        public List<textBase> mainEvent4= new List<textBase>(); 
        public List<textBase> mainEvent5= new List<textBase>();
        #endregion
        #region 노멀 이벤트 30개 리스트
        public List<textBase> normalEvent001 = new List<textBase>();
        public List<textBase> normalEvent002 = new List<textBase>();
        public List<textBase> normalEvent003 = new List<textBase>();
        public List<textBase> normalEvent004 = new List<textBase>();
        public List<textBase> normalEvent005 = new List<textBase>();
        public List<textBase> normalEvent006 = new List<textBase>();
        public List<textBase> normalEvent007 = new List<textBase>();
        public List<textBase> normalEvent008 = new List<textBase>();
        public List<textBase> normalEvent009 = new List<textBase>();
        public List<textBase> normalEvent010 = new List<textBase>();
        public List<textBase> normalEvent011 = new List<textBase>();
        public List<textBase> normalEvent012 = new List<textBase>();
        public List<textBase> normalEvent013 = new List<textBase>();
        public List<textBase> normalEvent014 = new List<textBase>();
        public List<textBase> normalEvent015 = new List<textBase>();
        public List<textBase> normalEvent016 = new List<textBase>();
        public List<textBase> normalEvent017 = new List<textBase>();
        public List<textBase> normalEvent018 = new List<textBase>();
        public List<textBase> normalEvent019 = new List<textBase>();
        public List<textBase> normalEvent020 = new List<textBase>();
        public List<textBase> normalEvent021 = new List<textBase>();
        public List<textBase> normalEvent022 = new List<textBase>();
        public List<textBase> normalEvent023 = new List<textBase>();
        public List<textBase> normalEvent025 = new List<textBase>();
        public List<textBase> normalEvent026 = new List<textBase>();
        public List<textBase> normalEvent027 = new List<textBase>();
        public List<textBase> normalEvent028 = new List<textBase>();
        public List<textBase> normalEvent029 = new List<textBase>();
        public List<textBase> normalEvent030 = new List<textBase>();
        #endregion
        public List<textBase> etc1Text = new List<textBase>();//기타1 리스트
        public List<textBase> etc2Text = new List<textBase>();//기타2 리스트
        public List<textBase> shopText = new List<textBase>();//상점 대화 리스트

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

            #region 상점 대사
            textBase shopText000 = new textBase();
            shopText000.InitText(5, "상점", "어서오세요.");
            shopText.Add(shopText000);

            textBase shopText001 = new textBase();
            shopText001.InitText(5, "상점", "어서오세요~");
            shopText.Add(shopText001);

            textBase shopText002 = new textBase();
            shopText002.InitText(5, "상점", "손님은 오랜만이네요/");
            shopText.Add(shopText002);

            textBase shopText003 = new textBase();
            shopText003.InitText(5, "상점", "너는... 이세계인이겠죠?");
            shopText.Add(shopText003);

            textBase shopText004 = new textBase();
            shopText004.InitText(5, "상점", "제 이름은 모이라예요.");
            shopText.Add(shopText004);

            textBase shopText005 = new textBase();
            shopText005.InitText(5, "모이라", "아.. 차를 준비해봤어요.");
            shopText.Add(shopText005);

            textBase shopText006 = new textBase();
            shopText006.InitText(5, "모이라", "지난 번에는 예상치 못한 손님이 방문했는데");
            shopText.Add(shopText006);

            textBase shopText007 = new textBase();
            shopText007.InitText(5, "모이라", "제대로 된 대접을 해드리지 못해서 얼마나 아쉬웠는지~");
            shopText.Add(shopText007);

            textBase shopText008 = new textBase();
            shopText008.InitText(5, "모이라", "마침 잘 오셨어요.");
            shopText.Add(shopText008);

            textBase shopText009 = new textBase();
            shopText009.InitText(5, "모이라", "널 기다리고 있었거든요.");
            shopText.Add(shopText009);

            textBase shopText010 = new textBase();
            shopText010.InitText(5, "모이라", "이 소리가 들리나요?");
            shopText.Add(shopText010);

            textBase shopText011 = new textBase();
            shopText011.InitText(5, "모이라", "당신을 위한 상품이 지금 막 태어나려던 참이거든요.");
            shopText.Add(shopText011);

            textBase shopText012 = new textBase();
            shopText012.InitText(5, "모이라", "같이 보시겠어요?");
            shopText.Add(shopText012);

            textBase shopText013 = new textBase();
            shopText013.InitText(5, "모이라", "어디보자~");
            shopText.Add(shopText013);

            textBase shopText014 = new textBase();
            shopText014.InitText(5, "모이라", "자, 당신도 바빠지겠네요.");
            shopText.Add(shopText014);

            textBase shopText015 = new textBase();
            shopText015.InitText(5, "모이라", "이제 또 어떤 울림들이 이 세계를 흔들까요.");
            shopText.Add(shopText015);

            textBase shopText016 = new textBase();
            shopText016.InitText(5, "모이라", "그리고 너, 언젠가 또 놀러오세요?");
            shopText.Add(shopText016);

            textBase shopText017 = new textBase();
            shopText017.InitText(5, "모이라", "세계의 의지가 당신을 이끌거에요.");
            shopText.Add(shopText017);
            #endregion

            #region 주인공 대사 모음집
            textBase utext000 = new textBase();
            utext000.InitText(1, "주인공", "일단 집을 나왔는데");
            userText.Add(utext000);

            textBase  utext001 = new textBase();
            utext001.InitText(1, "주인공", "어쩐다...");
            userText.Add(utext001);

            textBase utext002 = new textBase();
            utext002.InitText(1, "주인공", "솥은 깨트렸고, 배는 이미 가라앉혔으니..");
            userText.Add(utext002);

            textBase utext003 = new textBase();
            utext003.InitText(1, "주인공", "(무작정 길을 걷고 있다)");
            userText.Add(utext003);

            textBase utext004 = new textBase();
            utext004.InitText(1, "주인공", "읔...........");
            userText.Add(utext004);

            textBase utext005 = new textBase();
            utext005.InitText(1, "주인공", "(기억을 회상하며) ");
            userText.Add(utext005);

            textBase utext006 = new textBase();
            utext006.InitText(1, "주인공", "낭비할 시간이 없겠어");
            userText.Add(utext006);
            
            textBase utext007 = new textBase();
            utext007.InitText(1, "주인공", "얼른 나아가자");
            userText.Add(utext007);

            textBase utext008 = new textBase();
            utext008.InitText(1, "주인공", "모든 것은 동생을 위해");
            userText.Add(utext008);

            textBase utext009 = new textBase();
            utext009.InitText(1, "주인공", "어느쪽으로 갈까?");
            userText.Add(utext009);
            #endregion


            #region 중요 이벤트 대사 모음
            textBase mainEvent001 = new textBase();
            mainEvent001.InitText(2, "시스템", "당신은 길을 걷다가 ");
            mainEvent1.Add(mainEvent001);

            #endregion

            #region 노멀 이벤트 
            #region 노멀1
            textBase NET000 = new textBase();//NET001은 NormalEventText
            NET000.InitText(2, "시스템", "당신은 상점에서 샀던 수정구에 이상이 있음을 느껴서 보게 된다.");
            normalEvent001.Add(NET000);

            textBase NET001 = new textBase();//NET001은 NormalEventText
            NET001.InitText(10, "사장惡", "솔직히...우리들에게 이런 일을 맡긴다고 했을 땐... ");
            normalEvent001.Add(NET001);

            textBase NET002 = new textBase();
            NET002.InitText(10, "사장惡", "저도 참 장난하나 싶었는데 이게 또 이렇게 결과가 돌아오네요?");
            normalEvent001.Add(NET002);

            textBase NET003 = new textBase();
            NET003.InitText(10, "사장惡", "그런데 말입니다...");
            normalEvent001.Add(NET003);

            textBase NET004 = new textBase();
            NET004.InitText(10, "사장惡", "...그런데 말입니다!");
            normalEvent001.Add(NET004);

            textBase NET005 = new textBase();
            NET005.InitText(10, "사장惡", "이 음습한 로이스오래비와 빌어먹을 해골 대가리 씨");
            normalEvent001.Add(NET005);

            textBase NET006 = new textBase();
            NET006.InitText(10, "사장惡", "언제 우리가 직접 간다고 말이나 했나요?");
            normalEvent001.Add(NET006);

            textBase NET007 = new textBase();
            NET007.InitText(10, "사장惡", "이 따위로 엿을 먹이나요?");
            normalEvent001.Add(NET007);

            textBase NET008 = new textBase();
            NET008.InitText(10, "사장惡", "제 발로 이세계인을 죽이라구요? 게다가 저까지요? ");
            normalEvent001.Add(NET008);

            textBase NET009 = new textBase();
            NET009.InitText(10, "로이스", "혹시.. 후달리나?");
            normalEvent001.Add(NET009);

            textBase NET010 = new textBase();
            NET010.InitText(10, "사장惡", "하! 하! 하! 낮말은 새가 듣고, 밤말은 쥐가 듣는다더니...");
            normalEvent001.Add(NET010);

            textBase NET011 = new textBase();
            NET011.InitText(10, "사장惡", "우리 말은 왠 해골바가지가 엿듣네요!");
            normalEvent001.Add(NET011);

            textBase NET012 = new textBase();
            NET012.InitText(10, "사장惡", "후달리냐고요 ?");
            normalEvent001.Add(NET012);

            textBase NET013 = new textBase();
            NET013.InitText(10, "사장惡", "네! 개쫄리는데요 ?");
            normalEvent001.Add(NET013);

            textBase NET014 = new textBase();
            NET014.InitText(10, "사장惡", "니네가 하는 짓이 대놓고 개판이라 안 쫄릴 수가 없네요!");
            normalEvent001.Add(NET014);

            textBase NET015 = new textBase();
            NET015.InitText(10, "사장惡", "말해 봐. 누가 시킨 거야. ");
            normalEvent001.Add(NET015);

            textBase NET016 = new textBase();
            NET016.InitText(10, "사장惡", "누구 배 불리려고 이딴 수작 부리는 거냐고. ");
            normalEvent001.Add(NET016);

            textBase NET017 = new textBase();
            NET017.InitText(10, "로이스", "너~~는 우리가 고작 돈따위나 벌자고 이러는 줄 아는구나.");
            normalEvent001.Add(NET017);

            textBase NET018 = new textBase();
            NET018.InitText(10, "로이스", "멍~~청해라");
            normalEvent001.Add(NET018);

            textBase NET019 = new textBase();
            NET019.InitText(10, "사장惡", "조용!!!!!!!!");
            normalEvent001.Add(NET019);

            textBase NET020 = new textBase();
            NET020.InitText(10, "사장惡", "하! 하! 하! 또라이 새끼...");
            normalEvent001.Add(NET020);

            textBase NET021 = new textBase();
            NET021.InitText(10, "부하1", "...저기 심장 괜찮아---?  ---병원 가볼까 ---?");
            normalEvent001.Add(NET021);

            textBase NET022 = new textBase();
            NET022.InitText(10, "부하2", "돌아갔군요... ");
            normalEvent001.Add(NET022);

            textBase NET023 = new textBase();
            NET023.InitText(10, "부하2", "이렇게 가다간 심장이 남아나질 않겠어요");
            normalEvent001.Add(NET023);

            textBase NET024 = new textBase();
            NET024.InitText(10, "부하2", "사장님 이제 어쩌실 건가요");
            normalEvent001.Add(NET024);

            textBase NET025 = new textBase();
            NET025.InitText(10, "부하1", "---죽일--- 준비를--- 해야겠지 ");
            normalEvent001.Add(NET025);

            textBase NET026 = new textBase();
            NET026.InitText(10, "사장惡", "하! 시간이 없습니다. 준비하죠");
            normalEvent001.Add(NET026);

            textBase NET027 = new textBase();
            NET027.InitText(10, "부하들", "네..");
            normalEvent001.Add(NET027);

            #endregion

            #endregion

            #region etc1 처음 메인화면 시스템 대사 모음집
            textBase etcText000 = new textBase();
            etcText000.InitText(3, "시스템", "(소리가 들려온다)");
            etc1Text.Add(etcText000);
            textBase etcText001 = new textBase();
            etcText001.InitText(3, "시스템", "오늘은 무엇을 하실 계획인가요?");
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

