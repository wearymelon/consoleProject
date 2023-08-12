using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Squirtle : Pokemon
    {
        public Squirtle()
        {
            Health = 460;

            AttackDamage = 80;
        }

        public override bool Attack(Pokemon opponent)
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
