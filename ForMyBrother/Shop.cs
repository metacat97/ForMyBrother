using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Shop
    {
        List<items> Item = new List<items>();

        //items setItem1 = new items();

        public Shop() 
        {

            items wood = new items();
            wood.InitItem("나무", 300, 10);
            Item.Add(wood);
            
            items steel = new items();
            steel.InitItem("철강", 300, 10);
            Item.Add(steel);

            

        }
        public void addItem()
        {
            Console.WriteLine("{0}", Item[0].itemPrice);
            Console.WriteLine("{0}",Item[1].itemName);

        }

    }
}
