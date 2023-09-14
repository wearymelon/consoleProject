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
            : base(2, 125, 310, "Pikachu") { }

        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount == SpecialNeed)
            {
                enemy.IsStunned = true;

                SpecialCount = 0;

                enemy.GetHit(95, enemy);

                return true;
            }

            else
            {
                Console.WriteLine("insufficient amount of turns played since last special move.");

                return false;
            }

           
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            Health -= damage;


            if (isPlayer == true)
            {
                Console.WriteLine($"you have been damaged! You are now at {Health} health.");
            }
            else
            {
                Console.WriteLine($"you have damaged Pikachu! He is now at {Health} health.");
            }
           
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount < SpecialNeed && enemy.IsStunned == true)
            {
                enemy.Health = enemy.Health - stunDamage;

                Console.WriteLine("you have been damaged due to pikachu's stun damage.");
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
    }
}
