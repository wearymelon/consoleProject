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

        int remainingShield = 3;
        bool isShieldActive = false;

        public Bulbasaur()
            : base(70, 500) { }


        public override bool SpecialMove(Pokemon enemy)
        {
            remainingShield++;

            return false;
        }


        public override void GetHit(int damage, Pokemon enemy)
        {
            if (remainingShield >= 1)
            {
                Health -= damage / 2;

                remainingShield--;
            }
            else
            {
                Health -= damage;
            }


        }


        //////// MAKE UPDATE FUNCTION NEXT TIME YES YES EYS YES YES

    }
}
