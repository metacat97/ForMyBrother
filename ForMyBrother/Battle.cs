using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForMyBrother
{
    public class Battle
    {
        //User player = new User();
        public void startBattle(User player)
        {
            Random randcoin = new Random();
            int otherCoin = randcoin.Next(100, 500);
            //player.UserHit(10);
            //ConsoleKeyInfo UserInput = Console.ReadKey();
            //if (UserInput.Key == ConsoleKey.Enter)
            //{

            //}

            Console.Clear();
            goblin mob1 = new goblin();
            mob1.Init("고블린", 20, 10,10);
            
            Console.WriteLine("몬스터 접근   ");
            while (true)
            {

                if (mob1.Hp <= 0)
                {
                    
                    Console.WriteLine("\n{0}의 체력이 0이 되어 싸움에서 승리하였습니다.",
                        mob1.Name);
                    player.UserSetCoin(otherCoin);
                    Console.WriteLine("\n{0}의 코인을 획득했습니다",otherCoin);
                    player.UserSetExp(mob1.Exp);
                    Console.WriteLine("\n{0}경험치 획득", mob1.Exp);
                    if(player.exp == player.expMax) 
                    { 
                        player.LevelUp();
                        Console.WriteLine("플레이어 레벨업!!!");
                    }
                    break;
                }
                else if (player.healthPoint <= 0)
                {
                    Console.WriteLine("사용자의 체력이 {0}이 되어 게임을 종료합니다",
                        player.healthPoint);
                    break;
                }
                Thread.Sleep(1000);

                mob1.HitDamage(player.strong);
                Console.WriteLine("유저의 공격 {0}의 데미지를 입혔다.", player.strong);
                Thread.Sleep(1100);
                player.UserHit(mob1.Str);
                Console.WriteLine("고블린의 공격 {0}의 데미지를 입혔다", mob1.Str);
                
            }
            Console.WriteLine("현재 사용자의 체력 = {0} --- 의지 ={1}", player.healthPoint, player.willPower);
            Console.WriteLine("Press any key");
            Console.ReadLine();

        }

    }
}
