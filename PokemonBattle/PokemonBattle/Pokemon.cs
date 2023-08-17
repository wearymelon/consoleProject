using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {

        public int AttackDamage;

        public int Health;


        /// <summary>
        /// Attacking the enemy Pokemon
        /// </summary>
        /// <param name="enemy"></param>
        /// <returns></returns>
        public abstract bool BaseAttack(Pokemon enemy);

        


        public abstract void Update(Pokemon enemy);

    }
}
