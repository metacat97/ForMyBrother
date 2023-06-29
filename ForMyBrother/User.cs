﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class User : StatsBase
    {
        
        public List<items> userInven = new List<items>();
        public string user { get; private set; } //맵에서 보이는 캐릭터의 모습입니다.
        public int uxPos { get; private set; } //유저의 x 좌표를 받습니다.
        public int uyPos { get; private set;} // 유저의 y좌표를 받습니다.

        public int expMax { get; private set; }//경험치 상한치입니다.
        goblin test = new goblin();
        public User()
        {
            user = "♥";
            name = "김형준";
            level = 1;
            healthPointMax = 100;
            healthPoint = healthPointMax;
            willPowerMax = 5;
            willPower = willPowerMax;
            strong = 10;
            wisdom = 10;
            speed = 10;
            luck = 5;
            exp =  0;
            expMax = 50;
        }
       
        public void LevelUp()
        {
            level += 1;
            healthPointMax += 10;
            healthPoint = healthPointMax;
            willPowerMax += 1;
            willPower = willPowerMax;
            strong += 1;
            wisdom += 1;
            speed += 1;
            

            exp -= expMax;
            expMax += (int)(expMax*1.1f);
        }
        public void UserHit (int damage)
        {
            healthPoint -= damage;
            if (healthPoint < 0)
            {
                healthPoint = 0;
            }
        }
        public void UpStat() 
        { 
            Random rand = new Random();
            int statUp = rand.Next(1,4);
            if (statUp ==1 ){ strong += 1; }
            else if (statUp ==2 ) { wisdom +=1; }
            else if (statUp ==3 ) { speed +=1; }
            else if (statUp ==4 ) { luck +=1; }
        }
        //public void UserBuy (Shop shop)
        //{
        //    userInven.Add();
        //}
        public void setuxyPos(int y, int x)
        {
            uyPos = y; 
            uxPos = x;
        }
        public void SumxPos(int x)
        {
            uxPos += x;
        }
        public void SubxPos(int x)
        {
            uxPos -= x;
        }
        public void SumyPos(int y)
        {
            uyPos += y;
        }
        public void SubyPos(int y)
        {
            uyPos -= y;
        }
        
    }
}
