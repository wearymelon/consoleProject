using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pikachu : Pokemon
    {
        int quickCount = 2;
        public Pikachu()
            : base(125, 310) { }

        public override void SpecialMove(Pokemon enemy)
        {
            enemy.IsStunned = true;

            quickCount = 0;

            enemy.GetHit(95, enemy);
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            Health -= damage;
        }

        public override void Update(Pokemon enemy)
        {
            
        }

    }
}
