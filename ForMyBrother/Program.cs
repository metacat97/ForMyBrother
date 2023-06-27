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
            User user = new User();
            mainUI ui = new mainUI();
            Shop showItems = new Shop();
            Map map = new Map();

            //showItems.addItem();
            //ui.setUi();//콘솔창 크기 고정
            //ui.PrintUi();//처음 도화지 출력
            //ui.PrintTitle(); // 타이틀 로고 출력
            //button.PrintButton();//버튼 첫 출력
            //button.ControlButton();//버튼 제어 기능 - 게임 종료를 누르면 break

            //ui.PrintUi(); //다시 출력
            //ui.PrintStatus(user.healthPoint, user.willPower, user.strong, user.wisdom, user.speed, user.luck); //능력치 변환 ui 테스트 
            //user.LevelUp(); //테스트 레벨업 
            //Console.ReadLine();
            //ui.PrintStatus(user.healthPoint, user.willPower, user.strong, user.wisdom, user.speed, user.luck);// 다시 스텟 출력
           // Console.ReadLine();
            ui.resizeUi(60, 38); //사이즈 재조정
            map.drawMap();

        }
    }
}
