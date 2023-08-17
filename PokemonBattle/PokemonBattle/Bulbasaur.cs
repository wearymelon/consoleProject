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

        public Bulbasaur()
            : base(70, 500) { }


        public override bool BaseAttack(Pokemon opponent)
         {
            opponent.Health = opponent.Health - AttackDamage;
            
            if (opponent.Health <= 0)
            {
                return true;
            }

            return false;
         }


    }
}
