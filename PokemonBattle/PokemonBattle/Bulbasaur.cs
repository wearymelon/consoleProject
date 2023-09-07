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
            : base(3, 70, 500, "Bulbasaur") { }
        

        public override bool SpecialMove(Pokemon enemy)
        {

            if (SpecialCount == SpecialNeed)
            {
                SpecialCount++;

                return true;
            }

            else
            {
                Console.WriteLine("insufficient amount of turns played since last special move.");

                return false;
            }
        }


        public override void GetHit(int damage, Pokemon enemy)
        {
            if (SpecialCount >= 1)
            {
                Health -= damage / 2;

                SpecialCount++;
            }
            else
            {
                Health -= damage;
            }
        }


        public override void Update(Pokemon enemy)
        {
            if (SpecialCount == 0)
            {
                SpecialCount += Random.Shared.Next(3) / 2;

                Console.WriteLine("Did he get the extra shield??? Find out next time on dragon ba- nah I'm kidding he prolly got it.");
            }
        }

        public override string Print()
        {
            return "Bulbasaur";
        }
    }
}
