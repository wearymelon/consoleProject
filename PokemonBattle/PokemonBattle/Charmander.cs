using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {

        int flameDamage = 45;

        bool isFlameBurning;

        public Charmander()
            : base(2, 90, 385, "Charmander") { }

        public override bool SpecialMove(Pokemon enemy)
        {

            if (SpecialCount == SpecialNeed)
            {
                SpecialCount = 0;

                isFlameBurning = true;

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
            if (Random.Shared.Next(10) == 1)
            {
                Health = Health + 30;
            }
            else
            {
                Health -= damage;
            }
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount > 0)
            {
                enemy.Health -= flameDamage;

                Console.WriteLine("Imagine burning. Couldn't be me.");
            }
            else
            {
                isFlameBurning = false;
            }

            SpecialCount--;

            if (Random.Shared.Next(4) == 1)
            {
                SpecialCount++;

                isFlameBurning = true;
            }
        }

        public override string Print()
        {
            return "Charmander";
        }

    }
}