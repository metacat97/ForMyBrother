using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class everyText
    {   //test source tree
        public List<textBase> prololog = new List<textBase>();
        public List<textBase> pllQuestion1 = new List<textBase>();//프롤로그 질문 스크립트 담아놓은 리스트입니다.
        public List<textBase> pllQuestion2 = new List<textBase>();//프롤로그 질문 스크립트 담아놓은 리스트입니다.
        public List<textBase> pllQuestion3 = new List<textBase>();//프롤로그 질문 스크립트 담아놓은 리스트입니다.

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
        public List<textBase> normalEvent001 = new List<textBase>();//히든으로 노선 변경
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
        //public List<textBase> normalEvent021 = new List<textBase>();
        //public List<textBase> normalEvent022 = new List<textBase>();
        //public List<textBase> normalEvent023 = new List<textBase>();
        //public List<textBase> normalEvent024 = new List<textBase>();
        //public List<textBase> normalEvent025 = new List<textBase>();
        //public List<textBase> normalEvent026 = new List<textBase>();
        //public List<textBase> normalEvent027 = new List<textBase>();
        //public List<textBase> normalEvent028 = new List<textBase>();
        //public List<textBase> normalEvent029 = new List<textBase>();
        //public List<textBase> normalEvent030 = new List<textBase>();
        #endregion
        public List<textBase> etc1Text = new List<textBase>();//기타1 리스트
        public List<textBase> etc2Text = new List<textBase>();//기타2 리스트
        public List<textBase> shopText = new List<textBase>();//상점 대화 리스트

        public List<textBase> ending01 = new List<textBase>();
        public List<textBase> ending02 = new List<textBase>();
        public List<textBase> ending03 = new List<textBase>();
        public List<textBase> ending04 = new List<textBase>();
        public List<textBase> ending05 = new List<textBase>();
        public List<textBase> ending06 = new List<textBase>();
        public List<textBase> ending07 = new List<textBase>();
        public List<textBase> ending08 = new List<textBase>();


        public everyText()
        {
            #region 프롤로그
            textBase pll000 = new textBase();//prololog = pll 로 줄여서 변수 선언 했습니다.
            pll000.InitText(2, "누군가", "안녕하세요.");
            prololog.Add(pll000);

            textBase pll001 = new textBase();
            pll001.InitText(2, "누군가", "......");
            prololog.Add(pll001);

            textBase pll002 = new textBase();
            pll002.InitText(2, "누군가", "......");
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
            pll009.InitText(2, "누군가", "특정 이벤트에서 조건을 달성하시는 경우");
            prololog.Add(pll009);

            textBase pll010 = new textBase();
            pll010.InitText(2, "누군가", "마지막으로 당신의 HP 혹은 WP가 '0'이 되실 경우에는");
            prololog.Add(pll010);

            textBase pll00 = new textBase();
            pll00.InitText(2, "누군가", "사망하시게 되어 게임이 끝나게 됩니다.");
            prololog.Add(pll00);

            textBase pll011 = new textBase();
            pll011.InitText(2, "누군가", "지금부터 연습을 하실 수 있게끔 질문 3가지를 드릴겁니다.");
            prololog.Add(pll011); 
            
            textBase pll012 = new textBase();
            pll012.InitText(2, "누군가", " 편하게 골라주세요.        ");
            prololog.Add(pll012);

            textBase pll013 = new textBase();
            pll013.InitText(2, "누군가", "..............그러면");
            prololog.Add(pll013);

            textBase pll014 = new textBase();
            pll014.InitText(2, "누군가", "당신에게 행운이 있기를..........");
            prololog.Add(pll014);
            #endregion

            #region 프롤로그 스텟 선택 질문
            textBase pllQ000 = new textBase();//prolologQuestion = pllQ 로 줄여서 변수 선언 했습니다.
            pllQ000.InitText(2, "질문", "당신은 길을 걷다가 파란 슬리퍼 한 짝을 발견했다.");
            pllQuestion1.Add(pllQ000);

            textBase pllQ001 = new textBase();
            pllQ001.InitText(2, "    ", "누구의 슬리퍼일까?");
            pllQuestion1.Add(pllQ001);

            textBase pllQ002 = new textBase();
            pllQ002.InitText(2, "질문", "사람은 언제 죽는다고 생각하는가?");
            pllQuestion2.Add(pllQ002);

            textBase pllQ003 = new textBase();
            pllQ003.InitText(2, "답변1", "여러 가지 상황을 고려해 봐야 한다.");
            pllQuestion2.Add(pllQ003);

            textBase pllQ004 = new textBase();
            pllQ004.InitText(2, "답변2", "모두에게 잊혔을 때 죽었다고 볼 수 있다.");
            pllQuestion2.Add(pllQ004);

            textBase pllQ005 = new textBase();
            pllQ005.InitText(2, "답변3", "모르겠고, 지금 죽을 것 같다.");
            pllQuestion2.Add(pllQ005);

            textBase pllQ007 = new textBase();
            pllQ007.InitText(2, "질문", "사막을 걷다가 모래 폭풍 사이로 사람의 모습이 보였다.");
            pllQuestion3.Add(pllQ007);

            textBase pllQ008 = new textBase();
            pllQ008.InitText(2, "　　", "가까이 다가가니 말을 걸어온다.");
            pllQuestion3.Add(pllQ008);

            textBase pllQ009 = new textBase();
            pllQ009.InitText(2, "　　", "자신은 사막의 탑을 정복한 이경민이라 소개한다.");
            pllQuestion3.Add(pllQ009);

            textBase pllQ010 = new textBase();
            pllQ010.InitText(2, "　　", "마을로 돌아가는 길을 잃어서 곤란해 하던 중인데");
            pllQuestion3.Add(pllQ010);

            textBase pllQ011 = new textBase();
            pllQ011.InitText(2, "　　", "도움을 받을 수 있는지 물어보며 괴로운 표정을 짓는다.");
            pllQuestion3.Add(pllQ011);

            textBase pllQ012 = new textBase();
            pllQ012.InitText(2, "　　", "어떻게 하면 좋을까?");
            pllQuestion3.Add(pllQ012);

            textBase pllQ013 = new textBase();
            pllQ013.InitText(2, "답변1", "당장 도와준다");
            pllQuestion3.Add(pllQ013);

            textBase pllQ014 = new textBase();
            pllQ014.InitText(2, "답변2", "사과하고 그냥 지나친다");
            pllQuestion3.Add(pllQ014);

            textBase pllQ015 = new textBase();
            pllQ015.InitText(2, "답변3", "물러나라!!");
            pllQuestion3.Add(pllQ015);

            #endregion

            #region 상점 대사
            textBase shopText000 = new textBase();
            shopText000.InitText(5, "상점", "어서오세요.");
            shopText.Add(shopText000);

            textBase shopText001 = new textBase();
            shopText001.InitText(5, "상점", "어서오세요~");
            shopText.Add(shopText001);

            textBase shopText002 = new textBase();
            shopText002.InitText(5, "상점", "손님은 오랜만인 것 같아요!");
            shopText.Add(shopText002);

            textBase shopText003 = new textBase();
            shopText003.InitText(5, "상점", "선생님은... 처음 부임하신거죠?");
            shopText.Add(shopText003);

            textBase shopText004 = new textBase();
            shopText004.InitText(5, "상점", "제 이름은 모이라예요.");
            shopText.Add(shopText004);

            textBase shopText005 = new textBase();
            shopText005.InitText(5, "모이라", "아.. 차를 준비해봤어요.");
            shopText.Add(shopText005);

            textBase shopText006 = new textBase();
            shopText006.InitText(5, "모이라", "지난 번에는 예상치 못한 손님들이 방문했는데");
            shopText.Add(shopText006);

            textBase shopText007 = new textBase();
            shopText007.InitText(5, "모이라", "제대로 된 대접을 해드리지 못해서 얼마나 아쉬웠는지~");
            shopText.Add(shopText007);

            textBase shopText008 = new textBase();
            shopText008.InitText(5, "모이라", "마침 잘 오셨어요.");
            shopText.Add(shopText008);

            textBase shopText009 = new textBase();
            shopText009.InitText(5, "모이라", "선생님을 기다리고 있었거든요.");
            shopText.Add(shopText009);

            textBase shopText010 = new textBase();
            shopText010.InitText(5, "모이라", "이 소리가 들리나요?");
            shopText.Add(shopText010);

            textBase shopText011 = new textBase();
            shopText011.InitText(5, "모이라", "선생님을 위한 상품이 지금 막 나오려던 참이거든요.");
            shopText.Add(shopText011);

            textBase shopText012 = new textBase();
            shopText012.InitText(5, "모이라", "같이 보시겠어요?");
            shopText.Add(shopText012);

            textBase shopText013 = new textBase();
            shopText013.InitText(5, "모이라", "어디보자~");
            shopText.Add(shopText013);

            textBase shopText014 = new textBase();
            shopText014.InitText(5, "모이라", "읏챠, 선생님도 바빠지겠네요.");
            shopText.Add(shopText014);

            textBase shopText015 = new textBase();
            shopText015.InitText(5, "모이라", "이제 또 어떤 사건들이 이 마을을 흔들까요.");
            shopText.Add(shopText015);

            textBase shopText016 = new textBase();
            shopText016.InitText(5, "모이라", "그리고 선생님, 언젠가 또 놀러 와주세요?");
            shopText.Add(shopText016);

            textBase shopText017 = new textBase();
            shopText017.InitText(5, "모이라", "세계의 의지가 선생님을 이끌거에요.");
            shopText.Add(shopText017);

            textBase shopText018 = new textBase();
            shopText018.InitText(5, "모이라", "선생님, 돈이 없으면 못산답니다.");
            shopText.Add(shopText018);

            textBase shopText019 = new textBase();
            shopText019.InitText(5, "모이라", "언젠가 또 놀러오세요?");
            shopText.Add(shopText019);

            textBase shopText020 = new textBase();
            shopText020.InitText(5, "모이라", "세계의 의지가 선생님을 이끌거에요.");
            shopText.Add(shopText020);


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
            #region 중요1
            textBase mainEvent101 = new textBase();
            mainEvent101.InitText(2, "시스템", "집을 나서려는 순간");
            mainEvent1.Add(mainEvent101);

            

            #endregion


            #region 중요2
            textBase mainEvent201 = new textBase();
            mainEvent201.InitText(2, "시스템", "");
            mainEvent2.Add(mainEvent201);

            #endregion


            #endregion

            #region 노멀 이벤트 

            #region noevent2
            textBase noEvent201 = new textBase();
            noEvent201.InitText(11, "시스템", " 숲 속에서 정적을 깨는 알 수 없는 울부짖음이 들렸다.");
            normalEvent002.Add(noEvent201);

            textBase noEvent202 = new textBase();
            noEvent202.InitText(11, "시스템", " 당신은 소리가 난 곳으로 조심스럽게 다가갔다.");
            normalEvent002.Add(noEvent202);

            textBase noEvent203 = new textBase();
            noEvent203.InitText(11, "시스템", " 먼 발치에서 살펴보니 불량배들이 상점 주인을 괴롭히고 있었다.");
            normalEvent002.Add(noEvent203);

            textBase noEvent204 = new textBase();
            noEvent204.InitText(11, "시스템", " 그들은 당신을 전혀 신경을 쓰지 않고 있다.");
            normalEvent002.Add(noEvent204);
            //선택지 -> 기습한다 , 지나간다
            #endregion

            #region noevent3
            textBase noEvent301 = new textBase();
            noEvent301.InitText(11, "시스템", "당신은 에버핫 이라는 마을을 지나게 되었다.");
            normalEvent003.Add(noEvent301);

            textBase noEvent302 = new textBase();
            noEvent302.InitText(11, "시스템", "그곳은 혹한이 몰아쳐도 부글부글거리며 뜨겁게 끓어오르는");
            normalEvent003.Add(noEvent302);

            textBase noEvent303 = new textBase();
            noEvent303.InitText(11, "시스템", "온천으로 유명하다고 했다. 그러나 유명하다는 것 치고는");
            normalEvent003.Add(noEvent303);

            textBase noEvent304 = new textBase();
            noEvent304.InitText(11, "시스템", "관광객이 보이지 않았고, 마을 사람들은");
            normalEvent003.Add(noEvent304);

            textBase noEvent305 = new textBase();
            noEvent305.InitText(11, "시스템", "커다란 돌탑을 쌓고 그것에 기도를 올리고 있었다.");
            normalEvent003.Add(noEvent305);

            textBase noEvent306 = new textBase();
            noEvent306.InitText(11, "시스템", "커다란 돌탑은 새카만 돌들로 이루어져 있는데,");
            normalEvent003.Add(noEvent306);

            textBase noEvent307 = new textBase();
            noEvent307.InitText(11, "시스템", "당신은 그것이 석탄이라는 것을 알아챈다.");
            normalEvent003.Add(noEvent307);
            //지나친다, 무슨 일입니까?

            textBase noEvent308 = new textBase();
            noEvent308.InitText(11, "시스템", "당신의 물음에 세월의 흔적이 얼굴에 새겨진 노파가 답했다.");
            normalEvent003.Add(noEvent308);

            textBase noEvent309 = new textBase();
            noEvent309.InitText(11, "시스템", "우리 마을의 명물...부글거리는 온천이 더는 끓지 않는다오.");
            normalEvent003.Add(noEvent309);

            textBase noEvent310 = new textBase();
            noEvent310.InitText(11, "시스템", "물도 차갑게 식어버렸고, 그 탓에 손님들도 끊겼고 말이오");
            normalEvent003.Add(noEvent310);

            textBase noEvent311 = new textBase();
            noEvent311.InitText(11, "시스템", "이대로는 마을 사람들이 모두 굶어 죽을지도 모른다오.");
            normalEvent003.Add(noEvent311);

            textBase noEvent312 = new textBase();
            noEvent312.InitText(11, "시스템", "그래서 이렇게 신께 기도를 올리고 있는 게요");
            normalEvent003.Add(noEvent312);

            textBase noEvent313 = new textBase();
            noEvent313.InitText(11, "시스템", "그 때, 한 소녀가 당신에게 다가와 속삭였다.");
            normalEvent003.Add(noEvent313);

            textBase noEvent314 = new textBase();
            noEvent314.InitText(11, "시스템", "모험가님 잠시 시간좀 내주시겠어요?");
            normalEvent003.Add(noEvent314);
            //그래 얼마든지  , 귀찮게 굴지 마

            textBase noEvent315 = new textBase();
            noEvent315.InitText(11, "시스템", "당신은 소녀와 함께 사람들에게서 살짝 멀어졌다.");
            normalEvent003.Add(noEvent315);

            textBase noEvent316 = new textBase();
            noEvent316.InitText(11, "시스템", "소녀는 사람들의 눈치를 살핀 뒤, 당신에게 아주 작은 목소리로 속삭였다");
            normalEvent003.Add(noEvent316);

            textBase noEvent317 = new textBase();
            noEvent317.InitText(11, "시스템", "저는 기도로 이 문제가 해결될 거라고 생각지는 않아요.");
            normalEvent003.Add(noEvent317);

            textBase noEvent318 = new textBase();
            noEvent318.InitText(11, "시스템", "제게 생각이 있는데... 혹시 도와주실 수 있어요?");
            normalEvent003.Add(noEvent318);
            //뭔가 알고 있니?

            textBase noEvent319 = new textBase();
            noEvent319.InitText(11, "시스템", "그녀는 당신의 소매를 잡고, 마을 뒤편의 들판으로 안내했다.");
            normalEvent003.Add(noEvent319);

            textBase noEvent320 = new textBase();
            noEvent320.InitText(11, "시스템", "그곳에는 거대한 구덩이가 있었고 작은 돌들이 발자국 처럼");
            normalEvent003.Add(noEvent320);

            textBase noEvent321 = new textBase();
            noEvent321.InitText(11, "시스템", "어디론가 이어져 있었다. 소녀는 구덩이를 내려다보며 말했다.");
            normalEvent003.Add(noEvent321);

            textBase noEvent322 = new textBase();
            noEvent322.InitText(11, "시스템", "제가 살짝 내려가봤는데요");
            normalEvent003.Add(noEvent322);

            textBase noEvent323 = new textBase();
            noEvent323.InitText(11, "시스템", "그녀는 품에 갖고 있던 자그마한 양피지를 꺼냈다.");
            normalEvent003.Add(noEvent323);

            textBase noEvent324 = new textBase();
            noEvent324.InitText(11, "시스템", "그 양피지에는 조약하지만, 구덩이의 구조를 알 수 있는 그림이 그려져 있었다.");
            normalEvent003.Add(noEvent324);

            textBase noEvent325 = new textBase();
            noEvent325.InitText(11, "시스템", "소녀는 양피지의 그림을 짚으며, 이 구덩이가 온천의 ");
            normalEvent003.Add(noEvent325);

            textBase noEvent326 = new textBase();
            noEvent326.InitText(11, "시스템", "아래로 이어져 있는 것 같다고 했다. 그리고 그곳에서 ");
            normalEvent003.Add(noEvent326);

            textBase noEvent327 = new textBase();
            noEvent327.InitText(11, "시스템", "'뭔가'가 온천을 데워주고 있었던 것이라며, 이곳에서");
            normalEvent003.Add(noEvent327);

            textBase noEvent328 = new textBase();
            noEvent328.InitText(11, "시스템", "탈출한 무엇인가를 찾아달라고 했다.");
            normalEvent003.Add(noEvent328);
            //이어진 돌들을 찾는다

            textBase noEvent329 = new textBase();
            noEvent329.InitText(11, "시스템", "당신은 구덩이에서부터 이어진 돌들을 따라 걸었다.");
            normalEvent003.Add(noEvent329);

            textBase noEvent330 = new textBase();
            noEvent330.InitText(11, "시스템", "돌들을 따라 한 시간쯤 걸었을까. 조금씩 조금씩");
            normalEvent003.Add(noEvent330);

            textBase noEvent331 = new textBase();
            noEvent331.InitText(11, "시스템", "더워지는 것 같았다. 그리고 얼마 뒤에 당신은 그것이");
            normalEvent003.Add(noEvent331);

            textBase noEvent332 = new textBase();
            noEvent332.InitText(11, "시스템", "기분 탓이 아니라는 것을 알아챘다");
            normalEvent003.Add(noEvent332);

            textBase noEvent333 = new textBase();
            noEvent333.InitText(11, "시스템", "당신의 앞에서 라바 골렘이 걸어가고 있었던 것이다.");
            normalEvent003.Add(noEvent333);
            //말을 걸어본다, 공격한다

            textBase noEvent334 = new textBase();
            noEvent334.InitText(11, "시스템", "당신은 걸어가는 라바 골렘의 앞을 가로막고 말을 걸었다.");
            normalEvent003.Add(noEvent334);

            textBase noEvent335 = new textBase();
            noEvent335.InitText(11, "시스템", "거대한 라바 골렘은 고개를 갸웃했는데,");
            normalEvent003.Add(noEvent335);

            textBase noEvent336 = new textBase();
            noEvent336.InitText(11, "시스템", "당신의 말을 기다리는 것처럼 보인다.");
            normalEvent003.Add(noEvent336);
            //구덩이에 있던 게 너냐?
            textBase noEvent337 = new textBase();
            noEvent337.InitText(11, "시스템", "당신은 구덩이에 있던 게 너냐고 물었다.");
            normalEvent003.Add(noEvent337);

            textBase noEvent338 = new textBase();
            noEvent338.InitText(11, "시스템", "페로로질라는 침이 흐르는 고개를 끄덕였다.");
            normalEvent003.Add(noEvent338);
            //왜 빠져나왔나?

            textBase noEvent339 = new textBase();
            noEvent339.InitText(11, "시스템", "왜 빠져나왔냐는 물음에, 페로로질라는 당신을 가만히");
            normalEvent003.Add(noEvent339);

            textBase noEvent340 = new textBase();
            noEvent340.InitText(11, "시스템", "바라보았다. 그리고 한참만에 대답을 내놓았다");
            normalEvent003.Add(noEvent340);


            textBase noEvent341 = new textBase();
            noEvent341.InitText(11, "시스템", "명령이 끝났다. 내가 받은 명령. 구덩이에 누워 있어라");
            normalEvent003.Add(noEvent341);

            textBase noEvent342 = new textBase();
            noEvent342.InitText(11, "시스템", "그 시간이 끝났다.");
            normalEvent003.Add(noEvent342);

            textBase noEvent343 = new textBase();
            noEvent343.InitText(11, "시스템", "페로로질라의 말이 끝나자, 어느새 당신 곁에 다가온 소녀가 말했다");
            normalEvent003.Add(noEvent343);

            textBase noEvent344 = new textBase();
            noEvent344.InitText(11, "시스템", "음... 옛날 옛적에, 골 콩트라는 사람이 추위를 많이 타서");
            normalEvent003.Add(noEvent344);

            textBase noEvent345 = new textBase();
            noEvent345.InitText(11, "시스템", "온천을 만들었다고 들었었는데...");
            normalEvent003.Add(noEvent345);

            textBase noEvent346 = new textBase();
            noEvent346.InitText(11, "시스템", "골 콩트는 온천을 만드는 데 사용했던 재료가, 아마도");
            normalEvent003.Add(noEvent346);

            textBase noEvent347 = new textBase();
            noEvent347.InitText(11, "시스템", "저 페로로질라 였던 모양이다.");
            normalEvent003.Add(noEvent347);
            //다시 돌아가
            textBase noEvent348 = new textBase();
            noEvent348.InitText(11, "시스템", "당신은 페로로질라에게 다시 돌아가라고 말했다.");
            normalEvent003.Add(noEvent348);

            textBase noEvent349 = new textBase();
            noEvent349.InitText(11, "시스템", "그러나 페로로질라 당신의 말을 들은 체도 하지 않고, 거대한 턱을 치켜들었다.");
            normalEvent003.Add(noEvent349);
            //승리시 이벤트 조건 달성  패배시 

            //패배시 출력
            textBase noEvent350 = new textBase();
            noEvent350.InitText(11, "시스템", "당신은 페로로 질라의 뜨거운 화염을 피해 달아났다.");
            normalEvent003.Add(noEvent350);

            textBase noEvent351 = new textBase();
            noEvent351.InitText(11, "시스템", "다행스럽게도 그것은 도망치는 당신을 쫓아오지 않았다.");
            normalEvent003.Add(noEvent351);
            #endregion

            #region noevent4
            textBase noEvent401 = new textBase();
            noEvent401.InitText(11, "시스템", "무료로 회 떠드립니다! 즉성 회! 신선한 회");
            normalEvent004.Add(noEvent401);

            textBase noEvent402 = new textBase();
            noEvent402.InitText(11, "시스템", "직접 잡은 생선이면 더 좋습니다!");
            normalEvent004.Add(noEvent402);

            textBase noEvent403 = new textBase();
            noEvent403.InitText(11, "시스템", "앳된 얼굴의 요리사가 활기차게 마을 거리를 돌아다니다가 ");
            normalEvent004.Add(noEvent403);

            textBase noEvent404 = new textBase();
            noEvent404.InitText(11, "시스템", "당신에게 웃는 얼굴로 다가왔다");
            normalEvent004.Add(noEvent404);

            textBase noEvent405 = new textBase();
            noEvent405.InitText(11, "학생", "안녕하십니까? 저는 이 앞의 순은 철갑상어 여관에서 ");
            normalEvent004.Add(noEvent405);

            textBase noEvent406 = new textBase();
            noEvent406.InitText(11, "학생", "견습 요리사로 일하고 있습니다.요즘은 고등어 요리를 공부 중인데");
            normalEvent004.Add(noEvent406);

            textBase noEvent407 = new textBase();
            noEvent407.InitText(11, "학생", " 개인적으로 매번 구매하기가 쉽지 않아서요. 요리는 공짜로 해드릴테니 ");
            normalEvent004.Add(noEvent407);

            textBase noEvent408 = new textBase();
            noEvent408.InitText(11, "학생", "혹시 고등어가 있다면 하나 주실 수 있으신가요?");
            normalEvent004.Add(noEvent408);


            #endregion

            #region noevent5
            textBase noEvent501 = new textBase();
            noEvent501.InitText(11, "시스템", "당신에게 이즈미가 다가와 소매를 붙들었다.");
            normalEvent005.Add(noEvent501);

            textBase noEvent502 = new textBase();
            noEvent502.InitText(11, "시스템", "이즈미는 입 속에 뭔가를 우물거리며 말했다.");
            normalEvent005.Add(noEvent502);

            textBase noEvent503 = new textBase();
            noEvent503.InitText(11, "이즈미", "즈기 슨생닝.. 호시 머글거 이써요?");
            normalEvent005.Add(noEvent503);

            textBase noEvent504 = new textBase();
            noEvent504.InitText(11, "시스템", "그녀의 입을 보니, 민트색 액체가 흘러 내리고 있었다. ");
            normalEvent005.Add(noEvent504);

            textBase noEvent505 = new textBase();
            noEvent505.InitText(11, "시스템", "그녀는 그것을 꿀꺽 삼켜버리더니, 다시 말했다.");
            normalEvent005.Add(noEvent505);

            textBase noEvent506 = new textBase();
            noEvent506.InitText(11, "이즈미", "배가 고파서 그런데 먹을걸 주면 ");
            normalEvent005.Add(noEvent506);

            textBase noEvent507 = new textBase();
            noEvent507.InitText(11, "이즈미", "도움이 될만한 물건을 드릴게요!");
            normalEvent005.Add(noEvent507);
            //준다 안준다
            textBase noEvent508 = new textBase();
            noEvent508.InitText(11, "이즈미", "그녀는 해맑게 웃으며 당신에게 감사하다고 말했다.");
            normalEvent005.Add(noEvent508);

            textBase noEvent509 = new textBase();
            noEvent509.InitText(11, "이즈미", "그리고 주머니에서 구슬을 하나 꺼내 내밀었다.");
            normalEvent005.Add(noEvent509);


            textBase noEvent510 = new textBase();
            noEvent510.InitText(11, "이즈미", "이게 도움이 되면 좋겠네요!");
            normalEvent005.Add(noEvent510);


            textBase noEvent511 = new textBase();
            noEvent511.InitText(11, "이즈미", "그럼 나중에 또 봐요!");
            normalEvent005.Add(noEvent511);


            textBase noEvent512 = new textBase();
            noEvent512.InitText(11, "시스템", "그녀는 음식을 입에 넣고 떠나갔다.");
            normalEvent005.Add(noEvent512);

           

            #endregion

            #region noevent6
            textBase noEvent601 = new textBase();
            noEvent601.InitText(11, "시스템", "당신에게 문득 따갑고 가려운 느낌이 들었다.");
            normalEvent006.Add(noEvent601);

            textBase noEvent602 = new textBase();
            noEvent602.InitText(11, "시스템", "아무래도 낡은 코트 때문에 벼룩이 생긴 것 같다");
            normalEvent006.Add(noEvent602);
            //불에 태운다, 세게 턴다(힘확률 영향)

            textBase noEvent603 = new textBase();
            noEvent603.InitText(11, "시스템", "당신은 불로 태워야 겠다는 생각이 들었으나 불을 지필 물건이 없다.");
            normalEvent006.Add(noEvent603);
            

            textBase noEvent604 = new textBase();
            noEvent604.InitText(11, "시스템", "당신은 낡은 코트를 꺼내어 있는 힘껏 털었다.");
            normalEvent006.Add(noEvent604);


            textBase noEvent605 = new textBase();
            noEvent605.InitText(11, "시스템", "그러나 생각만큼 효과가 좋지는 못했고, 당신은 가려움에");
            normalEvent006.Add(noEvent605);


            textBase noEvent606 = new textBase();
            noEvent606.InitText(11, "시스템", "고통받으며 혈압이 올라 그만 쓰러지고 말았다.");
            normalEvent006.Add(noEvent606);

            textBase noEvent607 = new textBase();
            noEvent607.InitText(11, "시스템", "당신은 정신을 잃고 쓰러졌다.");
            normalEvent006.Add(noEvent607);




            #endregion
            
            #region noevent7
            textBase noEvent701 = new textBase();
            noEvent701.InitText(11, "시스템", "당신은 길에서 살짝 벗어난 위치에 부서진 차를 발견했다.");
            normalEvent007.Add(noEvent701);

            textBase noEvent702 = new textBase();
            noEvent702.InitText(11, "시스템", "차는 약간 손상되었지만, 잘 포장된 화물들이 있다.");
            normalEvent007.Add(noEvent702);
            //뭐가 있는지 살펴본다   다른 곳으로 간다
            #endregion 

            #region noevent8
            textBase noEvent801 = new textBase();
            noEvent801.InitText(11, "시스템", "길 가에 작은 조각상 앞에 사람들이 모여 기도를 올리고 있었다.");
            normalEvent008.Add(noEvent801);

            textBase noEvent802 = new textBase();
            noEvent802.InitText(11, "시스템", "당신이 의아한 표정으로 바라보자, 한 노파가 다가 왔다.");
            normalEvent008.Add(noEvent802);

            textBase noEvent803 = new textBase();
            noEvent803.InitText(11, "노파", "저 조각상으로 말할 것 같으면... 우리를 돌봐주는");
            normalEvent008.Add(noEvent803);

            textBase noEvent804 = new textBase();
            noEvent804.InitText(11, "노파", "수호신을 기리는 조각이란다");
            normalEvent008.Add(noEvent804);

            textBase noEvent805 = new textBase();
            noEvent805.InitText(11, "노파", "너도 정성껏 기도를 드리면, 축복을 내려주실지도 모르지.");
            normalEvent008.Add(noEvent805);
            //기도한다, 지나간다, 부순다
            #endregion

            #region noevent9
            textBase noEvent901 = new textBase();
            noEvent901.InitText(11, "시스템", "당신은 마을의 게시판에 공고를 붙이고 있는");
            normalEvent009.Add(noEvent901);

            textBase noEvent902 = new textBase();
            noEvent902.InitText(11, "시스템", "정의실현부 학생을 발견했다. 공고를 붙인 학생은 옆구리에 ");
            normalEvent009.Add(noEvent902);

            textBase noEvent903 = new textBase();
            noEvent903.InitText(11, "시스템", "몇 장의 양피지를 끼고, 서둘러 떠나갔다.");
            normalEvent009.Add(noEvent903);

            textBase noEvent904 = new textBase();
            noEvent904.InitText(11, "시스템", "당신은 학생이 붙인 양피지를 확인했다.");
            normalEvent009.Add(noEvent904);

            textBase noEvent905 = new textBase();
            noEvent905.InitText(11, "시스템", "티테트 광산의 불량배들이 점령해서 골치입니다");
            normalEvent009.Add(noEvent905);

            textBase noEvent906 = new textBase();
            noEvent906.InitText(11, "시스템", "불량배들을 몰아내주세요.");
            normalEvent009.Add(noEvent906);
            //의뢰를 받는다>전투발생, 하지 않는다 > 스킵 
            //textBase noEvent907 = new textBase();
            //noEvent907.InitText(11, "시스템", "당신은 게시판의 의뢰를 무시하고 다른곳으로 향했다.");
            //normalEvent009.Add(noEvent907);

            #endregion

            #region noevent10
            textBase noEvent1001 = new textBase();
            noEvent1001.InitText(11, "시스템", "비가 부슬부슬 내리며 공기가 축축하게 젖은 어느 오후");
            normalEvent010.Add(noEvent1001);

            textBase noEvent1002 = new textBase();
            noEvent1002.InitText(11, "시스템", "어디선가 물건이 부서지는 소리가 들린다");
            normalEvent010.Add(noEvent1002);

            textBase noEvent1003 = new textBase();
            noEvent1003.InitText(11, "시스템", "그곳에서는 성인 남성 2명이 싸우고 있었는데");
            normalEvent010.Add(noEvent1003);

            textBase noEvent1004 = new textBase();
            noEvent1004.InitText(11, "시스템", "하! 빨리 덤벼 없애주마!");
            normalEvent010.Add(noEvent1004);

            textBase noEvent1005 = new textBase();
            noEvent1005.InitText(11, "시스템", "그들의 소란에 어느순간 사람들이 모여 구경하기 시작했다.");
            normalEvent010.Add(noEvent1005);
            //구경한다, 치안대를 부른다, 지나간다,
            #endregion

            #region noevent11

            textBase noEvent1101 = new textBase();
            noEvent1101.InitText(11, "시스템", "당신은 길을 헤매고 어딘지도 모르는 채 시간을 허비한다.");
            normalEvent011.Add(noEvent1101);

            textBase noEvent1102 = new textBase();
            noEvent1102.InitText(11, "시스템", "그러던 중 머리 위에서 누군가의 목소리가 들려온다");
            normalEvent011.Add(noEvent1102);

            textBase noEvent1103 = new textBase();
            noEvent1103.InitText(11, "아루", "어머머, 여기 불쌍한 미아가 있네?");
            normalEvent011.Add(noEvent1103);

            textBase noEvent1104 = new textBase();
            noEvent1104.InitText(11, "시스템", "부드럽지만 조롱하는 목소리가 들려왔다, 나는 근처 건물 옥상에서 나를 내려다본 소녀와 눈이 마주친다");
            normalEvent011.Add(noEvent1104);

            textBase noEvent1105 = new textBase();
            noEvent1105.InitText(11, "시스템", "무언가 위협적으로 말하는듯하지만 다리가 떨리며 긴장을 하고있는 것이 느껴진다.");
            normalEvent011.Add(noEvent1105);

            textBase noEvent1106 = new textBase();
            noEvent1106.InitText(11, "아루", "한-한심한 바보가 우리 구역을 헤매고 있는 것 같네");
            normalEvent011.Add(noEvent1106);

            textBase noEvent1107 = new textBase();
            noEvent1107.InitText(11, "아루", "이 황폐하고 아무것도 없어보이는 이 골목길은 이래뵈도 우리 흥신소 68의 관할하야!");
            normalEvent011.Add(noEvent1107);

            textBase noEvent1108 = new textBase();
            noEvent1108.InitText(11, "아루", "그-그러니...너는...이제...어...그러니까 우리의 소유물...어라? 어디까지 읽었지?");
            normalEvent011.Add(noEvent1108);

            textBase noEvent1109 = new textBase();
            noEvent1109.InitText(11, "시스템", "그녀는 어리숙하 게 손에 무언가를 든 채 중얼거리듯이 말한다.");
            normalEvent011.Add(noEvent1109);

            //바닥에 놓여있는 컵라면통을 던진다 하단의 대사후 이벤트 종료
            //도망친다이벤트 종료

            textBase noEvent1110 = new textBase();
            noEvent1110.InitText(11, "아루", "꺄악, 지금 뭐하는거야!! 이거 뭐야? 끈적거려!");
            normalEvent011.Add(noEvent1110);

            textBase noEvent1111 = new textBase();
            noEvent1111.InitText(11, "시스템", "당신은 간신히 도망치는데 성공했다");
            normalEvent011.Add(noEvent1111);

            #endregion

            #region noevent12
            textBase noEvent1201 = new textBase();
            noEvent1201.InitText(11, "시스템", "당신은 힘이 다해 바닥에 넘어진다.");
            normalEvent012.Add(noEvent1201);


            textBase noEvent1202 = new textBase();
            noEvent1202.InitText(11, "시스템", "누군가가 급하게 달려와 당신을 등에 업는다");
            normalEvent012.Add(noEvent1202);


            textBase noEvent1203 = new textBase();
            noEvent1203.InitText(11, "시스템", "당신은 무언가 작고 따뜻한 등에 업힌 것에 부끄럽다");
            normalEvent012.Add(noEvent1203);


            textBase noEvent1204 = new textBase();
            noEvent1204.InitText(11, "이오리", "서,선생님? 어디서 어떤 녀석이 이렇게 만든거야!?");
            normalEvent012.Add(noEvent1204);


            textBase noEvent1205 = new textBase();
            noEvent1205.InitText(11, "이오리", "걱정하지 마. 선생님 내가 그들이 저지른 일에 대해 처벌할게!");
            normalEvent012.Add(noEvent1205);


            //고개를 힘겹게 내젓는다 아래 대사 후 이벤트 종료.
            //고개를 힘차게 끄덕인다바로 이벤트 종료

            textBase noEvent1206 = new textBase();
            noEvent1206.InitText(11, "이오리", "걱정마, 가벼운 벌을 줄거야, 학생답게 행동하는 법을 알도록.");
            normalEvent012.Add(noEvent1206);
            #endregion

            #region noevent13
            textBase noEvent1301 = new textBase();
            noEvent1301.InitText(11, "시스템", "당신은 편의점 앞 쓰레기통에 걸려넘어진다.");
            normalEvent013.Add(noEvent1301);


            textBase noEvent1302 = new textBase();
            noEvent1302.InitText(11, "시스템", "누군가 총총 걸어오는 소리가 들려온다.");
            normalEvent013.Add(noEvent1302);


            textBase noEvent1303 = new textBase();
            noEvent1303.InitText(11, "미야코", "서-선생님?");
            normalEvent013.Add(noEvent1303);


            textBase noEvent1304 = new textBase();
            noEvent1304.InitText(11, "시스템", "미야코는 앉아서 부상이나 출혈이 있는지 확인합니다.");
            normalEvent013.Add(noEvent1304);


            textBase noEvent1305 = new textBase();
            noEvent1305.InitText(11, "미야코", "선생님! 무슨 일이 일었던거에요? 다쳤어요?");
            normalEvent013.Add(noEvent1305);


            textBase noEvent1306 = new textBase();
            noEvent1306.InitText(11, "선생님", "배-배고파");
            normalEvent013.Add(noEvent1306);


            textBase noEvent1307 = new textBase();
            noEvent1307.InitText(11, "시스템", "하지만 그 순간 미야코의 뱃속에서도 당신의 뱃속과 같은 소리가 울려퍼진다.");
            normalEvent013.Add(noEvent1307);

            textBase noEvent1308 = new textBase();
            noEvent1308.InitText(11, "미야코", "그-근처의 쓰레기통을 찾아보도록 하죠, 아직 남아있는 곳이 있을 수 있어요");
            normalEvent013.Add(noEvent1308);


            textBase noEvent1309 = new textBase();
            noEvent1309.InitText(11, "시스템", "미야코와 함께 폐기를 찾았다, 미야코와의 사이가 깊어진것같다!");
            normalEvent013.Add(noEvent1309);

            #endregion

            #region noevent14
            textBase noEvent1401 = new textBase();
            noEvent1401.InitText(11, "시스템", "당신은 들개에 쫓기다 쓰레기통을 휘둘렀지만 생각보다 무거워 넘어집니다.");
            normalEvent014.Add(noEvent1401);


            textBase noEvent1402 = new textBase();
            noEvent1402.InitText(11, "시스템", "당신 앞에 서 있는 몸집이 작은 소녀가 소매를 잡아당겨 멍함에서 벗어날 수 있습니다.");
            normalEvent014.Add(noEvent1402);


            textBase noEvent1403 = new textBase();
            noEvent1403.InitText(11, "미유", "아, 안녕 미유! 정말 미안해, 거기서 못 봤어.");
            normalEvent014.Add(noEvent1403);


            textBase noEvent1404 = new textBase();
            noEvent1404.InitText(11, "미유", "저-저는 괜찮아요 선생님... 아무도 눈치 못채는게 익숙해서...");
            normalEvent014.Add(noEvent1404);

            textBase noEvent1405 = new textBase();
            noEvent1405.InitText(11, "시스템", "미유는 시선을 아래로 내리깔고 치마자락을 만지작거린다");
            normalEvent014.Add(noEvent1405);

            textBase noEvent1406 = new textBase();
            noEvent1406.InitText(11, "선생님", "그-그래? 미안하니까 그 혹시 밥은 먹었니?");
            normalEvent014.Add(noEvent1406);

            textBase noEvent1407 = new textBase();
            noEvent1407.InitText(11, "시스템", "미유는 누군가 자신에게 놀란듯 눈을 동그랗게 뜨고 당신을 올려다봅니다");
            normalEvent014.Add(noEvent1407);
            textBase noEvent1408 = new textBase();
            noEvent1408.InitText(11, "미유", "정-정말인가요 선생님?");
            normalEvent014.Add(noEvent1408);

            textBase noEvent1409 = new textBase();
            noEvent1409.InitText(11, "시스템", "당신은 그녀의 어깨를 꽉 쥐어줍니다.");
            normalEvent014.Add(noEvent1409);

            textBase noEvent1410 = new textBase();
            noEvent1410.InitText(11, "선생님", "물론이지! 가자!");
            normalEvent014.Add(noEvent1410);

            textBase noEvent1411 = new textBase();
            noEvent1411.InitText(11, "시스템", "하지만 당신은 지갑을 갖고오지않았다는 사실을 잊고있었다");
            normalEvent014.Add(noEvent1411);

            textBase noEvent1412 = new textBase();
            noEvent1412.InitText(11, "시스템", "미유와 같이 모래를 주워먹었다, 미유와 관계가 깊어진것같다.");
            normalEvent014.Add(noEvent1412);

            #endregion

            #region noevent15
            textBase noEvent1501 = new textBase();
            noEvent1501.InitText(11, "시스템", "과자와 음료수가 든 봉지를 들고 편의점을 나오니 입구 근처에 낯익은 인물이 서 있는 것이 보였다.");
            normalEvent015.Add(noEvent1501);


            textBase noEvent1502 = new textBase();
            noEvent1502.InitText(11, "사오리", "서-선생님...여-여기서 만날줄은 몰랐어");
            normalEvent015.Add(noEvent1502);

            textBase noEvent1503 = new textBase();
            noEvent1503.InitText(11, "선생님", "사오리, 오랜만이야. 잘 지냈어?");
            normalEvent015.Add(noEvent1503);

            textBase noEvent1504 = new textBase();
            noEvent1504.InitText(11, "사오리", "괘-괜찮다, 그냥 일상에서 잠시 쉬고 있을 뿐이야.");
            normalEvent015.Add(noEvent1504);

            textBase noEvent1505 = new textBase();
            noEvent1505.InitText(11, "시스템", "나는 그녀의 주위에서 우울한 공기를 느낄 수 있었고 그녀는 그녀의 마음에 뭔가가 있는 것 같았다.");
            normalEvent015.Add(noEvent1505);

            //하지만 내인생이 바쁘다, 떠난다  이벤트 종료
            //아직도 옛일 신경쓰고있어? 난 괜찮아.추가 대화 후 종료


            textBase noEvent1506 = new textBase();
            noEvent1506.InitText(11, "사오리", "...선생이야 말로 제대로 신경써");
            normalEvent015.Add(noEvent1506);

            textBase noEvent1507 = new textBase();
            noEvent1507.InitText(11, "시스템", "사오리의 표정이 아까보다는 좋은 것 같다");
            normalEvent015.Add(noEvent1507);

            #endregion

            #region noevent16
            textBase noEvent1601 = new textBase();
            noEvent1601.InitText(11, "시스템", "뜨거운 태양이 내리쬐는 사막을 지나는데 저 멀리 낯익은 모습이 보였다.");
            normalEvent016.Add(noEvent1601);

            textBase noEvent1602 = new textBase();
            noEvent1602.InitText(11, "선생님", "누-누가 좀 도와줘!");
            normalEvent016.Add(noEvent1602);

            textBase noEvent1603 = new textBase();
            noEvent1603.InitText(11, "시스템", "눈앞에서 무언가 검은형태의 것이 다가오는 것으로 보인다, 저건?");
            normalEvent016.Add(noEvent1603);

            //괴물이다! 도망쳐!!  전투발생 후 이벤트 종료
            //사람인가? 도와주세요!대화이벤트 진행

            textBase noEvent1604 = new textBase();
            noEvent1604.InitText(11, "선생님", "시-시로코?");
            normalEvent016.Add(noEvent1604);

            textBase noEvent1605 = new textBase();
            noEvent1605.InitText(11, "시로코", "응");
            normalEvent016.Add(noEvent1605);

            textBase noEvent1606 = new textBase();
            noEvent1606.InitText(11, "선생님", "무-물 좀");
            normalEvent016.Add(noEvent1606);

            textBase noEvent1607 = new textBase();
            noEvent1607.InitText(11, "시로코", "선생, 단련 부족");
            normalEvent016.Add(noEvent1607);

            textBase noEvent1608 = new textBase();
            noEvent1608.InitText(11, "선생님", "뭐?우-우선 물을 좀");
            normalEvent016.Add(noEvent1608);

            textBase noEvent1609 = new textBase();
            noEvent1609.InitText(11, "시로코", "나를 잡으면 줄게, 뛰어");
            normalEvent016.Add(noEvent1609);

            textBase noEvent1610 = new textBase();
            noEvent1610.InitText(11, "시스템", "시로코와 미친듯이 달리기 연습했다, 건강해진것같다.");
            normalEvent016.Add(noEvent1610);
            //최대체력 10+

            #endregion

            #region noevent17
            textBase noEvent1701 = new textBase();
            noEvent1701.InitText(11, "시스템", "아리스가 흥분하며 내가 달려온다");
            normalEvent017.Add(noEvent1701);


            textBase noEvent1702 = new textBase();
            noEvent1702.InitText(11, "아리스", "선생님, 모두 함께 새로운 프로그램을 개발했습니다!");
            normalEvent017.Add(noEvent1702);


            textBase noEvent1703 = new textBase();
            noEvent1703.InitText(11, "아리스", "플레이어가 다양한 시나리오에서 다양한 캐릭터와 상호 작용할 수 있는 가상 시뮬레이션입니다!");
            normalEvent017.Add(noEvent1703);


            textBase noEvent1704 = new textBase();
            noEvent1704.InitText(11, "시스템", "그녀는 기대감을 가지고 당신에게로 향합니다.");
            normalEvent017.Add(noEvent1704);



            //그래 함께 해볼까?  대사 진행
            //아 미안, 시간이 없어.이벤트종료


            textBase noEvent1705 = new textBase();
            noEvent1705.InitText(11, "아리스", "좋아요! 선생님 이쪽으로 와주세요!");
            normalEvent017.Add(noEvent1705);

            textBase noEvent1706 = new textBase();
            noEvent1706.InitText(11, "시스템", "그녀는 당신을 빈 교실로 안내하고 컴퓨터 앞에 앉힙니다.");
            normalEvent017.Add(noEvent1706);

            textBase noEvent1707 = new textBase();
            noEvent1707.InitText(11, "시스템", "아리스와 놀랍고 똥겜같은 게임으로 즐거운 시간을 보냅니다.");
            normalEvent017.Add(noEvent1707);


            textBase noEvent1708 = new textBase();
            noEvent1708.InitText(11, "시스템", "아리스와의 관계가 좋아졌다");
            normalEvent017.Add(noEvent1708);

            #endregion

            #region noevent18
            textBase noEvent1801 = new textBase();
            noEvent1801.InitText(11, "시스템", "당신은 길을 걷다가 수상하게 튀어나온 줄을 바라봅니다.");
            normalEvent018.Add(noEvent1801);


            textBase noEvent1802 = new textBase();
            noEvent1802.InitText(11, "선생님", "이게 뭐지?");
            normalEvent018.Add(noEvent1802);


            //당겨본다
            //당겨본다

            textBase noEvent1803 = new textBase();
            noEvent1803.InitText(11, "시스템", "갑자스럽게 치익하는 소리와 함께 거대한 폭발이 일어났다");
            normalEvent018.Add(noEvent1803);

            textBase noEvent1804 = new textBase();
            noEvent1804.InitText(11, "시스템", "하루카는 그것을 보고 당황하기 시작했고 눈물이 얼굴을 타고 흘러내렸다.");
            normalEvent018.Add(noEvent1804);


            textBase noEvent1805 = new textBase();
            noEvent1805.InitText(11, "하루카", "죄-죄송합니다...제-제발 게헨나 학원에서 제적시키지 말아주세요!!");
            normalEvent018.Add(noEvent1805);
            textBase noEvent1806 = new textBase();
            noEvent1806.InitText(11, "시스템", "다행히도 폭발은 기적적으로 빗겨나갔다 당신은 하루카를 쳐다본다");
            normalEvent018.Add(noEvent1806);

            textBase noEvent1807 = new textBase();
            noEvent1807.InitText(11, "하루카", "다-다시는 이런 일이 안 일어나게...아-아니 선생을 제거하면 목격자가 없으니까...");
            normalEvent018.Add(noEvent1807);

            textBase noEvent1808 = new textBase();
            noEvent1808.InitText(11, "시스템", "슬슬, 가만놔두면 위험해보인다");
            normalEvent018.Add(noEvent1808);

            //협박한다 체력 피해를 입고 이벤트 종료
            //용서해준다다음 대사로 이동


            textBase noEvent1809 = new textBase();
            noEvent1809.InitText(11, "하루카", "하-하지만 내가 모든 걸 망쳤는데...규칙도 어겨버렸는데...");
            normalEvent018.Add(noEvent1809);


            textBase noEvent1810 = new textBase();
            noEvent1810.InitText(11, "시스템", "하루카를 달래주며 인생삼담까지 해주었다.");
            normalEvent018.Add(noEvent1810);


            textBase noEvent1811 = new textBase();
            noEvent1811.InitText(11, "시스템", "지갑이 얇아지긴 했지만 하루카는 웃는얼굴로 떠났다.");
            normalEvent018.Add(noEvent1811);

            textBase noEvent1812 = new textBase();
            noEvent1812.InitText(11, "시스템", "하루카와의 관게가 좋아진 것 같다.");
            normalEvent018.Add(noEvent1812);

            #endregion

            #region noevent19
            textBase noEvent1901 = new textBase();
            noEvent1901.InitText(11, "시스템", "눈앞에서 탱크가 폭발하며 누군가가 착지한다.");
            normalEvent019.Add(noEvent1901);

            textBase noEvent1902 = new textBase();
            noEvent1902.InitText(11, "와카모", "후후후♥ 선생님, 당신은 저를 오래 기다리게 만들었습니다.");
            normalEvent019.Add(noEvent1902);

            textBase noEvent1903 = new textBase();
            noEvent1903.InitText(11, "시스템", "당신은 무언가 불길한 느낌이 들어 벗어나려고한다.");
            normalEvent019.Add(noEvent1903);

            textBase noEvent1904 = new textBase();
            noEvent1904.InitText(11, "와카모", "우후후⋯ 후후후후후⋯");
            normalEvent019.Add(noEvent1904);

            textBase noEvent1905 = new textBase();
            noEvent1905.InitText(11, "와카모", "하아, 이 흘러넘치는 행복⋯ 저를 이렇게 만들어버린 책임, 져 주.세.요? ");
            normalEvent019.Add(noEvent1905);

            //도망친다 --게임오버
            //당당하게 맞선다  --이벤트진행

            textBase noEvent1906 = new textBase();
            noEvent1906.InitText(11, "시스템", "당신은 당당하게 와카모의 손을 잡는다");
            normalEvent019.Add(noEvent1906);

            textBase noEvent1907 = new textBase();
            noEvent1907.InitText(11, "와카모", "어머 비록 폭염과 화약 연기가 자욱하다고 해도⋯⋯");
            normalEvent019.Add(noEvent1907);

            textBase noEvent1908 = new textBase();
            noEvent1908.InitText(11, "와카모", "네에, 저 와카모⋯. 절대로  이 손을 놓치지 않을 거랍니다♥");
            normalEvent019.Add(noEvent1908);

            textBase noEvent1909 = new textBase();
            noEvent1909.InitText(11, "시스템", "와카모에게 붙들려 데이트로 하루를 보냈다");
            normalEvent019.Add(noEvent1909);

            textBase noEvent1910 = new textBase();
            noEvent1910.InitText(11, "시스템", "중간에 경찰학원에게 쫓기기도 했지만 와카모와 인연이 깊어진것같다!");
            normalEvent019.Add(noEvent1910);

            #endregion

            #region noevent20
            textBase noEvent2001 = new textBase();
            noEvent2001.InitText(11, "시스템", "식당에서 나오자 어딘선가 서늘한 기운이 느껴진다");
            normalEvent020.Add(noEvent2001);


            textBase noEvent2002 = new textBase();
            noEvent2002.InitText(11, "유우카", "선・생・님・?");
            normalEvent020.Add(noEvent2002);

            textBase noEvent2003 = new textBase();
            noEvent2003.InitText(11, "시스템", "그녀의 손에는 요금고지서가 쥐고있었다");
            normalEvent020.Add(noEvent2003);

            textBase noEvent2004 = new textBase();
            noEvent2004.InitText(11, "유우카", "선생님? 정말이상하네요 이번달 지출이 생각보다 많아요?");
            normalEvent020.Add(noEvent2004);

            textBase noEvent2005 = new textBase();
            noEvent2005.InitText(11, "시스템", "유우카는 입이 웃고있는데 눈이 전혀 웃고있지않았다");
            normalEvent020.Add(noEvent2005);


            //변명한다 선택지 효과없음
            //도주한다 선택지 효과없음

            textBase noEvent2006 = new textBase();
            noEvent2006.InitText(11, "유우카", "정말이지…어른이면서 어린이처럼 굴려하시고 안되겠네요");
            normalEvent020.Add(noEvent2006);

            textBase noEvent2007 = new textBase();
            noEvent2007.InitText(11, "유우카", "타의 모범이 되어야 할 교육자로서 참으세요");
            normalEvent020.Add(noEvent2007);

            textBase noEvent2008 = new textBase();
            noEvent2008.InitText(11, "시스템", "모든 돈을 압수당했다");
            normalEvent020.Add(noEvent2008);

            #endregion

            #region noevent21~30 //쓰지 못한 것들
            //textBase noEvent2101 = new textBase();
            //noEvent2101.InitText(11, "시스템", "");
            //normalEvent008.Add(noEvent2101);

            //#endregion

            //#region noevent22
            //textBase noEvent2201 = new textBase();
            //noEvent2201.InitText(11, "시스템", "");
            //normalEvent022.Add(noEvent2201);

            //#endregion

            //#region noevent23
            //textBase noEvent2301 = new textBase();
            //noEvent2301.InitText(11, "시스템", "");
            //normalEvent023.Add(noEvent2301);

            //#endregion

            //#region noevent24
            //textBase noEvent2401 = new textBase();
            //noEvent2401.InitText(11, "시스템", "");
            //normalEvent024.Add(noEvent2401);

            //#endregion

            //#region noevent25
            //textBase noEvent2501 = new textBase();
            //noEvent2501.InitText(11, "시스템", "");
            //normalEvent025.Add(noEvent2501);

            //#endregion

            //#region noevent26
            //textBase noEvent2601 = new textBase();
            //noEvent2601.InitText(11, "시스템", "");
            //normalEvent026.Add(noEvent2601);

            //#endregion

            //#region noevent27
            //textBase noEvent2701 = new textBase();
            //noEvent2701.InitText(11, "시스템", "");
            //normalEvent027.Add(noEvent2701);

            //#endregion

            //#region noevent28
            //textBase noEvent2801 = new textBase();
            //noEvent2801.InitText(11, "시스템", "");
            //normalEvent028.Add(noEvent2801);

            //#endregion

            //#region noevent29
            //textBase noEvent2901 = new textBase();
            //noEvent2901.InitText(11, "시스템", "");
            //normalEvent029.Add(noEvent2901);

            //#endregion

            //#region noevent30
            //textBase noEvent3001 = new textBase();
            //noEvent3001.InitText(11, "시스템", "");
            //normalEvent030.Add(noEvent3001);
            #endregion
            #endregion

            #region 엔딩 대사 모음
            #region ending1
            textBase ending101 = new textBase();
            ending101.InitText(11, "시스템", "엔딩1. 행복한 결말");
            ending01.Add(ending101);

            #endregion

            #region ending2
            textBase ending201 = new textBase();
            ending201.InitText(11, "시스템", "엔딩2. 불행한 결말");
            ending02.Add(ending201);

            #endregion

            #region ending3
            textBase ending301 = new textBase();
            ending301.InitText(11, "시스템", "");
            ending03.Add(ending301);

            #endregion

            #region ending4
            textBase ending401 = new textBase();
            ending401.InitText(11, "시스템", "");
            ending04.Add(ending401);

            #endregion

            #region ending5
            textBase ending501 = new textBase();
            ending501.InitText(11, "시스템", "");
            ending05.Add(ending501);

            #endregion

            #region ending6
            textBase ending601 = new textBase();
            ending601.InitText(11, "시스템", "");
            ending06.Add(ending601);

            #endregion

            #region ending7
            textBase ending701 = new textBase();
            ending701.InitText(11, "시스템", "");
            ending07.Add(ending701);

            #endregion

            #region ending8
            textBase ending801 = new textBase();
            ending801.InitText(11, "시스템", "");
            ending08.Add(ending801);

            #endregion

     

            #endregion

            #region etc1 처음 메인화면 시스템 대사 모음집
            textBase etcText000 = new textBase();
            etcText000.InitText(3, "선생님", "...");
            etc1Text.Add(etcText000);
            textBase etcText001 = new textBase();
            etcText001.InitText(3, "선생님", "오늘은 무엇을 하면 좋을까?");
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

            #region 히든1:그들의 속사정
            textBase NET000 = new textBase();//NET001은 NormalEventText
            NET000.InitText(2, "시스템", "당신은 상점에서 샀던 수정구에 이상이 있음을 느껴서 보게 된다.");
            normalEvent001.Add(NET000);

            textBase NET001 = new textBase();//NET001은 NormalEventText
            NET001.InitText(10, "사장", "솔직히...우리들에게 이런 일을 맡긴다고 했을 땐... ");
            normalEvent001.Add(NET001);

            textBase NET002 = new textBase();
            NET002.InitText(10, "사장", "저도 참 장난하나 싶었는데 이게 또 이렇게 결과가 돌아오네요?");
            normalEvent001.Add(NET002);

            textBase NET003 = new textBase();
            NET003.InitText(10, "사장", "그런데 말입니다...");
            normalEvent001.Add(NET003);

            textBase NET004 = new textBase();
            NET004.InitText(10, "사장", "...그런데 말입니다!");
            normalEvent001.Add(NET004);

            textBase NET005 = new textBase();
            NET005.InitText(10, "사장", "이 음습한 기생오라비와 빌어먹을 해골 대가리 씨");
            normalEvent001.Add(NET005);

            textBase NET006 = new textBase();
            NET006.InitText(10, "사장", "언제 우리가 직접 간다고 말이나 했나요?");
            normalEvent001.Add(NET006);

            textBase NET007 = new textBase();
            NET007.InitText(10, "부하1", "사장..누구한테 얘기하는거야?");
            normalEvent001.Add(NET007);

            textBase NET008 = new textBase();
            NET008.InitText(10, "로이스", "(공간이 일렁이며)사장아...아쉽지만 계약서에 적혀있었단다? ");
            normalEvent001.Add(NET008);

            textBase NET009 = new textBase();
            NET009.InitText(10, "부하2", "어디서부터 들은 거지...? ");
            normalEvent001.Add(NET009);

            textBase NET010 = new textBase();
            NET010.InitText(10, "부하1", "이건 문제가 될 수 있어...");
            normalEvent001.Add(NET010);

            textBase NET011 = new textBase();
            NET011.InitText(10, "사장", "하! 하! 하! 낮말은 새가 듣고, 밤말은 쥐가 듣는다더니... 우리 말은 왠 해골바가지가 엿듣네요!");
            normalEvent001.Add(NET011);

            textBase NET012 = new textBase();
            NET012.InitText(10, "사장", "제가 무슨 잘못을 했길래 이 따위로 엿을 먹이나요? ");
            normalEvent001.Add(NET012);

            textBase NET013 = new textBase();
            NET013.InitText(10, "사장", "이세계인을 죽이라구요? 게다가 저까지 동원해서?  ");
            normalEvent001.Add(NET013);

            textBase NET014 = new textBase();
            NET014.InitText(10, "사장", "해골 대가리 씨! 제가 돌 대가리로 보이나요?");
            normalEvent001.Add(NET014);

            textBase NET015 = new textBase();
            NET015.InitText(10, "로이스", "혹시 후달리나?");
            normalEvent001.Add(NET015);

            textBase NET016 = new textBase();
            NET016.InitText(10, "사장", "후달리냐고요?");
            normalEvent001.Add(NET016);

            textBase NET017 = new textBase();
            NET017.InitText(10, "사장", "네! 개쫄리는데요 ? ");
            normalEvent001.Add(NET017);

            textBase NET018 = new textBase();
            NET018.InitText(10, "사장", "니네가 하는 짓이 대놓고 개판이라 안 쫄릴 수가 없네요! ");
            normalEvent001.Add(NET018);

            textBase NET019 = new textBase();
            NET019.InitText(10, "사장", "제가 염원을 필요로 하는 이세계인의 마을로 들어간다? ");
            normalEvent001.Add(NET019);

            textBase NET020 = new textBase();
            NET020.InitText(10, "사장", "그리고 만약 그곳에서 무슨 일이 생긴다?");
            normalEvent001.Add(NET020);

            textBase NET021 = new textBase();
            NET021.InitText(10, "사장", "염원의 정보를 가지고 있는 제가? ");
            normalEvent001.Add(NET021);

            textBase NET022 = new textBase();
            NET022.InitText(10, "사장", "한순간에 3개의 염원을 얻게 되는 것은 누구일까요! ");
            normalEvent001.Add(NET022);

            textBase NET023 = new textBase();
            NET023.InitText(10, "사장", "곧 염원전쟁이 벌어질지도 모르는 이 시기에?");
            normalEvent001.Add(NET023);

            textBase NET024 = new textBase();
            NET024.InitText(10, "사장", "하! 하! 하! 너무나도 노골적이라서 두 번 말할 가치도 없네요!");
            normalEvent001.Add(NET024);

            textBase NET025 = new textBase();
            NET025.InitText(10, "사장", "말해봐. 누가 시킨 거야. 누구 배 불리려고 이딴 수작 부리는 거냐고");
            normalEvent001.Add(NET025);

            textBase NET026 = new textBase();
            NET026.InitText(10, "스컬", "이런이런---");
            normalEvent001.Add(NET026);

            textBase NET027 = new textBase();
            NET027.InitText(10, "로이스", "하하하---");
            normalEvent001.Add(NET027);

            textBase NET028 = new textBase();
            NET028.InitText(10, "로이스", "아---");
            normalEvent001.Add(NET028);

            textBase NET029 = new textBase();
            NET029.InitText(10, "로이스", "무슨 말을 그렇게 흥분하면서 하나 했는데---");
            normalEvent001.Add(NET029);

            textBase NET030 = new textBase();
            NET030.InitText(10, "로이스", "그 반듯한 돌 머리로 굴린 게 고작 그거야?");
            normalEvent001.Add(NET030);

            textBase NET031 = new textBase();
            NET031.InitText(10, "로이스", "너~~는 우리가 고작 돈 따위나 벌자고 이러는 줄 아는구나");
            normalEvent001.Add(NET031);

            textBase NET032 = new textBase();
            NET032.InitText(10, "로이스", "멍~~청해라---");
            normalEvent001.Add(NET032);

            textBase NET033 = new textBase();
            NET033.InitText(10, "사장", "조용!!!!!!!");
            normalEvent001.Add(NET033);

            textBase NET034 = new textBase();
            NET034.InitText(10, "로이스", "난 네가 어떻게 생각하든 상관 안 해");
            normalEvent001.Add(NET034);

            textBase NET035 = new textBase();
            NET035.InitText(10, "로이스", "염원 전쟁? 배후? 돈? 편하게 생각해. 하지만 서로 약속은 지키자고.");
            normalEvent001.Add(NET035);

            textBase NET036 = new textBase();
            NET036.InitText(10, "로이스", "스컬.");
            normalEvent001.Add(NET036);

            textBase NET037 = new textBase();
            NET037.InitText(10, "스컬", "네. 자 다시 한 번 계약서를 보시죠.");
            normalEvent001.Add(NET037);

            textBase NET038 = new textBase();
            NET038.InitText(10, "스컬", "요점만 말하면 우리는 돌덩이 사무소에게 가장 부유했던 염원의 정보를.");
            normalEvent001.Add(NET038);

            textBase NET039 = new textBase();
            NET039.InitText(10, "스컬", "돌덩이 사무소는 그 대가로 우리가 원할 때 이세계인의 마을에 가서 염원을 찾아온다는 거죠.");
            normalEvent001.Add(NET039);

            textBase NET040 = new textBase();
            NET040.InitText(10, "스컬", "분명히 여기 사장씨, 마티나씨, 바다 씨의 서명과 저희 로이스 단잔임의 서명이 적혀 있습니다. ");
            normalEvent001.Add(NET040);

            textBase NET041 = new textBase();
            NET041.InitText(10, "바다", "염원에 대한 정보를 그 마을에서 구해온다는 소리는 못 들었습니다. 게다가 직접 가져오라뇨");
            normalEvent001.Add(NET041);

            textBase NET042 = new textBase();
            NET042.InitText(10, "스컬", "모호하게 쓰여져 있긴 하죠.");
            normalEvent001.Add(NET042);

            textBase NET043 = new textBase();
            NET043.InitText(10, "스컬", "그렇다고 이 계약서의 내용이 지금 상황에 맞지 않는 건 아닙니다.");

            textBase NET044 = new textBase();
            NET044.InitText(10, "마티나", "---누구 마음대로--- ");
            normalEvent001.Add(NET044);

            textBase NET045 = new textBase();
            NET045.InitText(10, "로이스", "돌덩이가 곧 특허 전쟁이니 뭐니 호들갑을 떨며 후다닥 서명했잖아? 염원에 대한 정보가 급하다며.");
            normalEvent001.Add(NET045);

            textBase NET046 = new textBase();
            NET046.InitText(10, "바다", "우리가 직접 찾으러 간다는 말도 없었죠.돌덩이 사무소만 갈 뿐");
            normalEvent001.Add(NET046);

            textBase NET047 = new textBase();
            NET047.InitText(10, "스컬", "약관을 잘 확인해 보셨어야죠. 여기 보세요.");
            normalEvent001.Add(NET047);

            textBase NET048 = new textBase();
            NET048.InitText(10, "마티나", "---뭐가 있다는 거야---");
            normalEvent001.Add(NET048);

            textBase NET049 = new textBase();
            NET049.InitText(10, "스컬", "제 안경을 빌려드리죠. 자, 크게 보세요");
            normalEvent001.Add(NET049);

            textBase NET050 = new textBase();
            NET050.InitText(10, "마티나", "---이 계약서에 서명한 자는 반드시 도서관에서 책을 찾아와야 한다--- ");
            normalEvent001.Add(NET050);

            textBase NET051 = new textBase();
            NET051.InitText(10, "바다", "같잖은 짓. 이렇게까지 우리를 건드려 놓고 좋은 꼴은 못 볼 텐데?");
            normalEvent001.Add(NET051);

            textBase NET052 = new textBase();
            NET052.InitText(10, "바다", "이제 와서 우리가 순순히 이런 거짓 계약을 따를 것 같나?");
            normalEvent001.Add(NET052);

            textBase NET053 = new textBase();
            NET053.InitText(10, "스컬", "이런이런---");
            normalEvent001.Add(NET053);

            textBase NET054 = new textBase();
            NET054.InitText(10, "로이스", "이게 말이지. 그냥 계약서가 아니거든---");
            normalEvent001.Add(NET054);

            textBase NET055 = new textBase();
            NET055.InitText(10, "로이스", "아, 뭐라 했더라 스컬?");
            normalEvent001.Add(NET055);

            textBase NET056 = new textBase();
            NET056.InitText(10, "스컬", "내일의 약속입니다.");
            normalEvent001.Add(NET056);

            textBase NET057 = new textBase();
            NET057.InitText(10, "로이스", "맞아. 내일의 약속! 이름은 별로지만 ");
            normalEvent001.Add(NET057);

            textBase NET058 = new textBase();
            NET058.InitText(10, "사장", "어쨌든 이 계약서에 적힌 내용을 이행하지 않으면 서명한 사람에게서 아무거나 빼 올 수 있다? ");
            normalEvent001.Add(NET058);

            textBase NET059 = new textBase();
            NET059.InitText(10, "로이스", "원하는 만큼 말이야.");
            normalEvent001.Add(NET059);

            textBase NET060 = new textBase();
            NET060.InitText(10, "사장", "---헛소리!");
            normalEvent001.Add(NET060);

            textBase NET061 = new textBase();
            NET061.InitText(10, "로이스", "스컬.");
            normalEvent001.Add(NET061);

            textBase NET062 = new textBase();
            NET062.InitText(10, "스컬", "자 바다씨의 심장입니다.");
            normalEvent001.Add(NET062);

            textBase NET063 = new textBase();
            NET063.InitText(10, "바다", "커흑...");
            normalEvent001.Add(NET063);

            textBase NET064 = new textBase();
            NET064.InitText(10, "마티나", "---바다!...");
            normalEvent001.Add(NET064);

            textBase NET065 = new textBase();
            NET065.InitText(10, "스컬", "꽤나 돈 좀 들이셨군요. 이런 고급진 시술까지 받고.");
            normalEvent001.Add(NET065);

            textBase NET066 = new textBase();
            NET066.InitText(10, "스컬", "자, 다시 돌려드렸습니다.");
            normalEvent001.Add(NET066);

            textBase NET067 = new textBase();
            NET067.InitText(10, "로이스", "봤지? 돌 덩이. 난 네가 어떻게 생각하든 상관없는데 약속만 지켜주면 좋겠어.");
            normalEvent001.Add(NET067);

            textBase NET068 = new textBase();
            NET068.InitText(10, "로이스", "그리고 행복했던 사람의 염원은 윗선에서 하달한 명령이니 가야 하잖아? 어차피 마을에 가야 하는 건데 그렇게 열 내지 말라고.");
            normalEvent001.Add(NET068);

            textBase NET069 = new textBase();
            NET069.InitText(10, "사장", "하나만 물어보지!");
            normalEvent001.Add(NET069);

            textBase NET070 = new textBase();
            NET070.InitText(10, "사장", "그렇다면 너는 뭘 위해  이런 일을 하는거지 ");
            normalEvent001.Add(NET070);

            textBase NET071 = new textBase();
            NET071.InitText(10, "로이스", "세상과 인간의 아름다움을 연주할 거야");
            normalEvent001.Add(NET071);

            textBase NET072 = new textBase();
            NET072.InitText(10, "로이스", "우리가 지닌 외로움의 경계를 무너트려줄---");
            normalEvent001.Add(NET072);

            textBase NET073 = new textBase();
            NET073.InitText(10, "스컬", "그럼 오늘 안에 처리해 주시길.");
            normalEvent001.Add(NET073);

            textBase NET074 = new textBase();
            NET074.InitText(10, "사장", "---아름다움---? 외로움---?");
            normalEvent001.Add(NET074);

            textBase NET075 = new textBase();
            NET075.InitText(10, "사장", "하! 하! 하! 또라이 새끼---");
            normalEvent001.Add(NET075);


            textBase NET076 = new textBase();
            NET076.InitText(10, "로이스", "---바다 심장 괜찮아---? --병원 가볼까?");
            normalEvent001.Add(NET076);

            textBase NET077 = new textBase();
            NET077.InitText(10, "사장", "이거! 아주 된통 당했습니다!");
            normalEvent001.Add(NET077);

            textBase NET078 = new textBase();
            NET078.InitText(10, "바다", "---정말 괜찮겠습니까. 아무런 준비 없이 저희가 가도---");
            normalEvent001.Add(NET078);

            textBase NET079 = new textBase();
            NET079.InitText(10, "사장", "여러분 단순하게 생각하자구요. 심각해지지 맙시다!");
            normalEvent001.Add(NET079);

            textBase NET080 = new textBase();
            NET080.InitText(10, "사장", "저희는 하려고 한 일을 할 뿐");
            normalEvent001.Add(NET080);

            textBase NET081 = new textBase();
            NET081.InitText(10, "부하들", "네..");
            normalEvent001.Add(NET081);
            #endregion

        }


    }
}

