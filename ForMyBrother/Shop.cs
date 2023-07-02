using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Shop
    {
        public List<items> Item = new List<items>();
        public List<items> SpecialItem = new List<items>();
        public List<items> Temp = new List<items>(); 
        public Shop() 
        {
            #region 일반 아이템
            items wood = new items();
            wood.InitItem("사과", 300, 999,1);
            Item.Add(wood);
            
            items steel = new items();
            steel.InitItem("사이다", 300, 999, 1);
            Item.Add(steel);

            items normal01 = new items();
            normal01.InitItem("감기약", 100, 3, 1);
            Item.Add(normal01);

            items normal02 = new items();
            normal02.InitItem("고등어", 100, 3, 1);
            Item.Add(normal02);

            items normal03 = new items();
            normal03.InitItem("초콜릿", 100, 3, 1);
            Item.Add(normal03);

            items normal04 = new items();
            normal04.InitItem("분노", 100, 3, 1);
            Item.Add(normal04);

            items normal05 = new items();
            normal05.InitItem("사랑", 100, 3, 1);
            Item.Add(normal05);


            items normal06 = new items();
            normal06.InitItem("영롱한 수정구", 5000, 3, 2);
            Item.Add(normal06);
            #endregion

            #region 특별한 아이템
            items Happy = new items();
            Happy.InitItem("에이~팟 프로", 2000, 1, 5);
            Item.Add(Happy);

            items Sad = new items();
            Sad.InitItem("소설:금단의 연애", 2000, 1,5);
           Item.Add(Sad);

            items Angry = new items();
            Angry.InitItem("게임잡지:히트 걸즈", 2000, 1,5);
            Item.Add(Angry);

            items Rich = new items();
            Rich.InitItem("고급 쿠키 세트", 2000, 1,5);
            Item.Add(Rich);
            //items Happy = new items();
            //Happy.InitSpItem("행복한 사람의 원념", 1000, 1);
            //SpecialItem.Add(Happy);

            //items Sad = new items();
            //Sad.InitSpItem("슬픈 사람의 원념", 1000, 1);
            //SpecialItem.Add(Sad);

            //items Angry = new items();
            //Angry.InitSpItem("분노한 사람의 원념", 1000, 1);
            //SpecialItem.Add(Angry);

            //items Rich = new items();
            //Rich.InitSpItem("부유한 사람의 원념", 1000, 1);
            //SpecialItem.Add(Rich);

            #endregion

        }

        public void Purchase(User player)
        {
            player.shopIO = 0;
            Console.SetCursorPosition(30,25);
            Console.WriteLine("사고 싶은걸 입력해주세요");
            
            Console.SetCursorPosition(30, 26);
            string userPut = Console.ReadLine();
            for (int i = 0; i < Item.Count; i++)
            {
                if (userPut == Item[i].itemName)
                {
                    if (Item[i].itemPrice > player.coin)
                    {
                        Console.SetCursorPosition(30, 27);
                        Console.WriteLine("소지금이 부족하여 퇴출당합니다.");
                        Console.SetCursorPosition(30, 25);
                        player.shopIO +=1;
                        Console.ReadKey();
                        
                    }
                    else
                    {
                        player.UserPurchace(Item[i].itemPrice);
                        player.userInven.Add(Item[i]);
                        Item[i].itemCount -= 1;
                    }
                    if (Item[i].itemCount <= 0)
                    {
                        Item.Remove(Item[i]);
                    }
                }
            }
        }

        public void MarketUi(List<items> Item)
        {

            for (int i = 0; i < Item.Count; i++)
            {
                if (Item[i].itemCode != 5)
                { 
                    Console.SetCursorPosition(30, 10+i);
                    Console.WriteLine("아이템명[{0,4}]   가격[{1,6}]", Item[i].itemName, Item[i].itemPrice);
                }
                else if (Item[i].itemCode == 5 )
                {
                    Random rand = new Random();
                    int oneshow = rand.Next(8, 11);
                    Console.SetCursorPosition(70, 10);
                    Console.WriteLine("아이템명[{0,4}]   가격[{1,6}]", Item[oneshow].itemName, Item[oneshow].itemPrice);
                }
            }
            // Console.ReadLine();
        }
        public void SpecialUi(List<items> SpecialItem)
        {
            Random rand = new Random();
            int oneshow = rand.Next(0, SpecialItem.Count);
            Console.SetCursorPosition(70, 10);
            Console.WriteLine("아이템명[{0,4}]   가격[{1,6}]", SpecialItem[oneshow].itemName, SpecialItem[oneshow].itemPrice);
           
        }
        public void PrintInventory(User player)
        {
            //Console.SetCursorPosition(30, 9);
            Console.WriteLine("유저의 소지금 = {0}", player.coin);
            for (int i = 0; i < player.userInven.Count; i++)
            {
                //Console.SetCursorPosition(30, 10+i);
                Console.WriteLine("아이템명[ {0,10}    ]   가격[ {1,6} ]", player.userInven[i].itemName, player.userInven[i].itemCount) ;
            }
            Console.ReadKey();
        }

    }
}
