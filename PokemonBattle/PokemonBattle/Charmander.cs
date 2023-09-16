using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Charmander : Pokemon
    {

        int flameDamage = 45;

        bool isFlameBurning;



        public Charmander()
            : base(2, 90, 385, "Charmander") { }

        public override bool SpecialMove(Pokemon enemy)
        {

            if (SpecialCount == SpecialNeed)
            {
                SpecialCount = 0;

                isFlameBurning = true;

                return true;
            }
            else
            {
                return false;
            }
            
        }

        public override bool GetHit(int damage)
        {
            if (Random.Shared.Next(10) == 1)
            {
                Health = Health + 30;

                return false;
            }
            else
            {
                Health -= damage;

                return true;
            }
        }

        public override void Update(Pokemon enemy)
        {
            if (SpecialCount > 0)
            {
                enemy.Health -= flameDamage;

                
            }
            else
            {
                isFlameBurning = false;
            }

            SpecialCount--;

            if (Random.Shared.Next(4) == 1)
            {
                SpecialCount++;

                isFlameBurning = true;
            }
        }

        public override string Print()
        {
            return "Charmander";
        }

    }
}