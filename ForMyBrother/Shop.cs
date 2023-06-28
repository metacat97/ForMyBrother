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
        List<items> SpecialItem = new List<items>();
        public Shop() 
        {
            #region 일반 아이템
            items wood = new items();
            wood.InitItem("나무", 300, 10);
            Item.Add(wood);
            
            items steel = new items();
            steel.InitItem("철강", 300, 10);
            Item.Add(steel);
            #endregion

            #region 특별한 아이템
            items LifeTree = new items();
            LifeTree.InitSpItem("생명의나무", 1000, 1);
            SpecialItem.Add(LifeTree);

            #endregion

        }
    }
}
