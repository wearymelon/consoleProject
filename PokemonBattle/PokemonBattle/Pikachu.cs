using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pikachu : Pokemon
    {

        int stunDamage = 40;

        public Pikachu()
            : base(2, 1, 125, 310, "Pikachu") { }

        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount >= SpecialNeed)
            {
                SpecialCount = 0;

                enemy.GetHit(100);

                return true;
            }

            else
            {
                

                return false;
            }

           
        }

        public override bool GetHit(int damage)
        {
            Health -= damage;

            return true;
           
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount > 0)
            {
                enemy.IsStunned = true;
            }

            if (SpecialCount < SpecialNeed && enemy.IsStunned == true)
            {
                enemy.GetHit(stunDamage);
            }

            if (SpecialCount < SpecialNeed)
            {
                SpecialCount++;
            }
        }

        public override string Print()
        {
            return "Pikachu";
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Pikachu is an electric type pokemon. He has the highest base damage, clocking in with 125 damage per basic strike," +
                                "\nbut lacks in health as he only has 310 health. His special attack hits for 95 damage and stuns the enemy." +
                                "\nfor the following turns in which the enemy is stunned, the enemy is dealt 40 damage as a result of the stun. \n\n" +
                                "press 4 to go to start screen or press 5 to choose another chapter.");
        }
    }
}
