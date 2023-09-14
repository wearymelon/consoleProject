using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Magikarp : Pokemon
    {
        public bool isDodging = false;

        public Magikarp()
            : base(2, 30, 1000, "Magikarp") { }    

        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount == SpecialNeed)
            {
                SpecialCount = 0;
                isDodging = true;

                return true;
            }
            else
            {
                Console.WriteLine("insufficient amount of turns played since last special move.");

                return false;
            }

            
            //if you can do your special attack, do it and return true
            //if you can't, print why and return false.
            //do this for all pokemon
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            if (!isDodging)
            {
                Health -= damage;

                if (isPlayer == true)
                {
                    Console.WriteLine($"you have been damaged! You are now at {Health} health.");

                }
                else
                {
                    Console.WriteLine($"you have damaged Magikarp! He is now at {Health} health.");
                }
            }

            isDodging = false;
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount < SpecialNeed)
            {
                Health += 10;

                Console.WriteLine("this mediocre fish has healed. Do we really care?");
            }
            if (SpecialCount < SpecialNeed)
            {
                SpecialCount++;
            }
        }

        public override string Print()
        {
            return "Magikarp";
        }
    }
}
