using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class Bulbasaur : Pokemon
    {
        //make constructor

        bool isShieldActive = false;

        public Bulbasaur()
            : base(3, 70, 500, "Bulbasaur") { }
        

        public override bool SpecialMove(Pokemon enemy)
        {

            if (SpecialCount == SpecialNeed)
            {
                SpecialCount++;

                return true;
            }

            else
            {
                return false;
            }
        }


        public override bool GetHit(int damage)
        {
            if (SpecialCount >= 1)
            {
                Health -= damage / 2;

                SpecialCount++;
            }
            else
            {
                Health -= damage;
            }

            return true;
        }


        public override void Update(Pokemon enemy)
        {
            if (SpecialCount == 0)
            {
                SpecialCount += Random.Shared.Next(3) / 2;
            }
        }

        public override string Print()
        {
            return "Bulbasaur";
        }
    }
}
