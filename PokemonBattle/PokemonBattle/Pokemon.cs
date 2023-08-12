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
        public abstract bool Attack(Pokemon pokemon);
    }
}
