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
            wood.InitItem("나무", 300, 10);
            Item.Add(wood);
            
            items steel = new items();
            steel.InitItem("철강   ", 300, 10);
            Item.Add(steel);

            items normal01 = new items();
            normal01.InitItem("노말 아이템1", 100, 10);
            Item.Add(normal01);

            items normal02 = new items();
            normal02.InitItem("노말 아이템2", 100, 10);
            Item.Add(normal02);

            items normal03 = new items();
            normal03.InitItem("노말 아이템3", 100, 10);
            Item.Add(normal03);

            items normal04 = new items();
            normal04.InitItem("노말 아이템4", 100, 10);
            Item.Add(normal04);

            #endregion

            #region 특별한 아이템
            items LifeTree = new items();
            LifeTree.InitSpItem("생명의나무", 1000, 1);
            SpecialItem.Add(LifeTree);

            #endregion

        }

        public void Purchase(User player)
        {
            Console.SetCursorPosition(30,20);
            Console.WriteLine("사고 싶은걸 입력해주세요");
            
            Console.SetCursorPosition(30, 22);
            string userPut = Console.ReadLine();
            for (int i = 0; i < Item.Count; i++)
            {
                if (userPut == Item[i].itemName)
                {
                    player.userInven.Add(Item[i]);
                    Item.Remove(Item[i]);
                }
            }
        }
        public void MarketUi(List<items> Item)
        {
            for (int i = 0; i < Item.Count; i++)
            {
                Console.SetCursorPosition(30,10+i);
                Console.WriteLine("아이템명[ {0,10}    ]   가격[ {1,6} ]", Item[i].itemName, Item[i].itemPrice);
            }
           // Console.ReadLine();
        }
        public void PrintInventory(User player)
        {
            Console.WriteLine("아이템명[ {0,10}    ]   가격[ {1,6} ]", player.userInven[0].itemName, player.userInven[0].itemPrice);
            Console.WriteLine("아이템명[ {0}    ]   가격[ {1} ]", player.userInven[1].itemName, player.userInven[1].itemPrice);


        }

    }
}
