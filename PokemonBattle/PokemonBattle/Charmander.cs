using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {
        public Charmander()
            : base(90, 385) { }

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