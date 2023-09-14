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
           : base(1, 20, 800, "Nathan Drake") { }

        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount >= SpecialNeed)
            {
                for (int i = 0; i < SpecialCount; i++)
                {

                    if (Random.Shared.Next(1, 101) <= 43)
                    {
                        enemy.GetHit(50, enemy);
                    }
                }

                return true;
            }

            else
            {
                Console.WriteLine("insufficient amount of turns played since last special move.");

                return false;
            }


            SpecialCount = 0;
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            if (Random.Shared.Next(7) == 1)
            {
                Health += dodgeRecoveryAmount;
            }
            else
            {
                if (Random.Shared.Next(15) == 1)
                {
                    Health -= damage * 2;

                    Console.WriteLine($"You hit Nate with a very rough punch and he has taken double the damage. He is now at {Health} health.");
                }
                else
                {
                    if (Random.Shared.Next(75) == 1)
                    {
                        Health = 0;

                        Console.WriteLine("You did it! You killed the most powerful man on the roster by chance. Congrats!");
                    }
                    else
                    {
                        Health -= damage;

                        if (isPlayer == true)
                        {
                            Console.WriteLine($"you have been damaged! You are now at {Health} health.");
                        }
                        else
                        {
                            Console.WriteLine($"you have damaged Nathan Drake! He is now at {Health} health.");
                        }

                        
                    }
                }
            }
        }

        public override void Update(Pokemon enemy)
        {
            if (Random.Shared.Next(10) == 1)
            {
                SpecialCount = 7;

                Console.WriteLine("Nathan Drake found a full new mag out of nowhere! He can now brutally kill the small animal facing him!");
            }

            if (Random.Shared.Next(20) == 1)
            {
                this.AttackDamage = this.AttackDamage * 2;

                Console.WriteLine("Nathan Drake has found armor piercing rounds, so now his bullets do double damage!");
            }

            if (Random.Shared.Next(50) == 1)
            {
                Health = Health + 1000;

                Console.WriteLine("Nathan Drake has found a healing totem randomly in his pocket! He now has gained more health than he originally had before this battle! 1000!");
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
    }
}
