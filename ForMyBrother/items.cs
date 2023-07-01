using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class items
    {
        //public List<items> itemList = default; // default: 만들었는데 언제 쓸지 모름
        public string itemName { get; private set; }
        public int itemPrice { get; private set; }
        public int itemCount;
        public int itemCode;
        
        public void InitItem(string name,  int price, int count, int code)
        {
            itemName = name;
            itemPrice = price;
            itemCount = count;
            itemCode = code;
        }
        public void InitSpItem(string name, int price, int code) 
        {
            itemName = name;
            itemPrice = price;
            itemCode = code;
        }
        //public void TotalItem()
        //{
        //    items redPotion = new items();
        //    redPotion.InitItem("빨간 포션", 10, 100);
        //    items bluePotion = new items();
        //    bluePotion.InitItem("파랑 포션", 10, 100);
        //    items greenPotion = new items();
        //    greenPotion.InitItem("초록 포션", 10, 100);
        //    items yellowPotion = new items();
        //    yellowPotion.InitItem("노란 포션", 10, 100);
        //    items whitePotion = new items();
        //    whitePotion.InitItem("하얀 포션", 10, 100);

        //    itemList = new List<items>();    // 여기서 쓰겠다고 초기화함.
        //    itemList.Add(redPotion);
        //    itemList.Add(bluePotion);
        //    itemList.Add(greenPotion);
        //    itemList.Add(yellowPotion);
        //    itemList.Add(whitePotion);
        //}


    }
}
