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


        public override void SpecialMove(Pokemon enemy)
        {
            remainingShield++;
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


        public override void Update(Pokemon enemy)
        {
            if (remainingShield == 0)
            {
                remainingShield += Random.Shared.Next(3) / 2;
            }
        }


        //////// MAKE UPDATE FUNCTION NEXT TIME YES YES EYS YES YES

    }
}
