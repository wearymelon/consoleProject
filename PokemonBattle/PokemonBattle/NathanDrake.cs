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
           : base(7, 1, 20, 800, "Nathan Drake") { }


        
        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount >= SpecialNeed)
            {
                for (int i = 0; i < SpecialCount; i++)
                {

                    if (Random.Shared.Next(1, 101) <= 43)
                    {
                        enemy.GetHit(50);
                    }
                }

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
    }
}
