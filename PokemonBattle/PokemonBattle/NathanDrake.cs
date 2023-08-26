using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class NathanDrake : Pokemon
    {
        int ammoAmount = 0;

        public NathanDrake()
           : base(20, 800) { }

        public override void SpecialMove(Pokemon enemy)
        {
            for (int i = 0; i < ammoAmount; i++)
            {


                if (Random.Shared.Next(1, 101) <= 43)
                {
                    enemy.GetHit(50, enemy);
                }
            }

            ammoAmount = 0;
        }

        public override void Update(Pokemon enemy)
        {
            if (Random.Shared.Next(10) == 1)
            {
                ammoAmount = 7;

                Console.WriteLine("Nathan Drake found a full new mag out of nowhere! He can now brutally kill the small animal facing him!");
            }

            
        }
    }
}
