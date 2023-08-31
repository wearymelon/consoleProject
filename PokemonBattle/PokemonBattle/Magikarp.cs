using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Magikarp : Pokemon
    {
        bool isDodging = false;

        int healCount = 2;

        public Magikarp()
            : base(30, 1000, "Magikarp") { }    

        public override void SpecialMove(Pokemon enemy)
        {
            healCount = 0;
            isDodging = true;
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            if (!isDodging)
            {
                Health -= damage;
            }

            isDodging = false;
        }

        public override void Update(Pokemon enemy)
        {
            if (healCount < 2)
            {
                Health += 10;

                Console.WriteLine("this mediocre fish has healed. Do we really care?");
            }

            healCount++;
        }

        public override string Print()
        {
            return "Magikarp";
        }
    }
}
