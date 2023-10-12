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

        int flameEffect = 20;

        bool isFlameBurning;



        public Charmander()
            : base(2, 1, 90, 385, "Charmander") { }

        public override bool SpecialMove()
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

            if (isFlameBurning == true)
            {
                enemy.Health -= flameEffect;
            }
        }

        public override string Print()
        {
            return "Charmander";
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Charmander is a fire type pokemon. He has a base damage of 90, and has 385 health, making him more of an attack type." +
                "\nHis special ability allows him to spit a fireball at you that deals 45 damage." +
                "\nThe fireball then starts to effect the opponent every turn, dealing 20 damage." +
                "\nHe has 2 uses, but there is a 25% chance that he recieves an extra use every turn.");
        }

    }
}