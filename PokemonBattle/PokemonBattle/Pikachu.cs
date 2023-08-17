using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pikachu : Pokemon
    {

        public Pikachu()
            : base(125, 310) { }

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
