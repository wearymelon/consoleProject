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
                return false;
            }

            
            //if you can do your special attack, do it and return true
            //if you can't, print why and return false.
            //do this for all pokemon
        }

        public override bool GetHit(int damage)
        {
            
            if (!isDodging)
            {
                Health -= damage;

                return true;
            }
            else
            {
                isDodging = false;

                return false;
            }

        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount < SpecialNeed)
            {
                Health += 10;
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
