using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class NathanDrake : Pokemon
    {

        int dodgeRecoveryAmount = 35;

        public NathanDrake()
           : base(7, 1, 35, 800, "Nathan Drake") { }


        
        public override bool SpecialMove()
        {
            if (SpecialCount >= SpecialNeed)
            {
                SpecialCount = 0;

                return true;
            }

            else
            {
                return false;
            }
        }

        public override bool GetHit(int damage)
        {
            if (Random.Shared.Next(7) == 1)
            {
                Health += dodgeRecoveryAmount;

                

                return false;
            }
            else
            {
                if (Random.Shared.Next(15) == 1)
                {
                    Health -= damage * 2;
                }
                else
                {
                    if (Random.Shared.Next(75) == 1)
                    {
                        Health = 0;
                    }
                    else
                    {
                        Health -= damage;

                        
                        
                    }
                }

                return true;
            }
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount > 0)
            {
                for (int i = 0; i < SpecialCount; i++)
                {

                    if (Random.Shared.Next(1, 101) <= 43)
                    {
                        enemy.GetHit(60);
                    }
                }
            }

            if (Random.Shared.Next(10) == 1)
            {
                SpecialCount = 7;
            }

            if (Random.Shared.Next(20) == 1)
            {
                this.AttackDamage = this.AttackDamage * 2;
            }

            if (Random.Shared.Next(50) == 1)
            {
                Health = Health + 1000;
            }   

            if (SpecialCount < 7)
            {
                SpecialCount++;
            }
        }

        public override string Print()
        {
            return "Nathan Drake";
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Nathan Drake is a shooter type (PAID DLC). He has a base damage of 35, and has 800 health, which makes him seem like a defense type," +
                "\nbut hs special ability makes him a heavy hitter on the attacking end. His special ablitity allows him to shoot his opponent with 7 bullets" +
                "\nfrom his desert eagle, doing 50 damage each. There is a 43 percent chance (my r6 headshot percentage(who cares?(fr))) of any certain bullet hitting the opponent," +
                "\n meaning his special damage can range from 0 damage to 350 damage, depending on if he aims well enough on his turn. He shoots all of the bullets available" +
                "\nin one turn, and gains a bullet back at the end of every turn." +
                "\nEvery turn, there are different factors that can come into play. There is a 14% chance of him dodging an attack and gaining 35 health from it," +
                "\nthere is also a 7% chance that he takes double damage from his opponent, there is a 1.3% chance of him dropping dead," +
                "\nthere is a 10% chance of him gaining 7 bullets back in one turn, there is a 5% of him dealing double damage to his opponent," +
                "\nAnd finally there is a 2% chance of him gaining 1000 health. He is the most unpredictable and strongest pokemon on this list.");
        }
    }
}