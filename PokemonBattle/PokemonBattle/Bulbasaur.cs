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

        bool isShieldActive = false;

        public Bulbasaur()
            : base(3, 1, 70, 500, "Bulbasaur") { }
        

        public override bool SpecialMove()
        {

            if (SpecialCount >= SpecialNeed)
            {
                SpecialCount--;

                return true;
            }

            else
            {
                return false;
            }
        }


        public override bool GetHit(int damage)
        {
            if (SpecialCount <= 1)
            {
                Health -= damage / 2;
            }
            else
            {
                Health -= damage;
            }

            return true;
        }


        public override void Update(Pokemon enemy)
        {
            if (SpecialCount == 0)
            {
                SpecialCount += Random.Shared.Next(3) / 2;
            }
        }

        public override string Print()
        {
            return "Bulbasaur";
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Bulbasaur is a defense type pokemon. He has a base damage of 70, and has 500 health, making him a pretty balanced pokemon." +
                                "\nHis special ability is a shield that reduces attacks thrown at him by half." +
                                "\nHe is able to use the shield 3 times before it's gone for good.\n\n" +
                                "press 4 to go to start screen or press 5 to choose another chapter.");
        }
    }
}
