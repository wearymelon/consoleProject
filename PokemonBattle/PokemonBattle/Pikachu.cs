using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Pikachu : Pokemon
    {

        int stunDamage = 40;

        public Pikachu()
            : base(2, 125, 310, "Pikachu") { }

        public override bool SpecialMove(Pokemon enemy)
        {
            if (SpecialCount == SpecialNeed)
            {
                enemy.IsStunned = true;

                SpecialCount = 0;

                enemy.GetHit(95, enemy);

                return true;
            }

            else
            {
                

                return false;
            }

           
        }

        public override bool GetHit(int damage, Pokemon enemy)
        {
            Health -= damage;

            return true;
           
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount < SpecialNeed && enemy.IsStunned == true)
            {
                enemy.Health = enemy.Health - stunDamage;
            }

            if (SpecialCount < SpecialNeed)
            {
                SpecialCount++;
            }
        }

        public override string Print()
        {
            return "Pikachu";
        }
    }
}
