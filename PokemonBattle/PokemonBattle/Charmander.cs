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

        bool isFlameBurning;

        public Charmander()
            : base(90, 385) { }

        public override void SpecialMove(Pokemon enemy)
        {
            flameCounter = 2;

            isFlameBurning = true;
        }
    }
}