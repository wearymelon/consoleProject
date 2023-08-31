using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {
        int flameCounter = 0;

        int flameDamage = 45;

        bool isFlameBurning;

        public Charmander()
            : base(90, 385, "Charmander") { }

        public override void SpecialMove(Pokemon enemy)
        {
            flameCounter = 2;

            isFlameBurning = true;
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
            if (flameCounter > 0)
            {
                enemy.Health -= flameDamage;

                Console.WriteLine("Imagine burning. Couldn't be me.");
            }
            else
            {
                isFlameBurning = false;
            }

            flameCounter--;

            if (Random.Shared.Next(4) == 1)
            {
                flameCounter++;

                isFlameBurning = true;
            }
        }

        public override string Print()
        {
            return "Charmander";
        }

    }
}