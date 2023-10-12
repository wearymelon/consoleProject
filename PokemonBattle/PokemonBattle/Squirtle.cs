using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    internal class Squirtle : Pokemon
    {
        int originalEnemyAttack = -1;

        bool isSquirtActive = false;
        public Squirtle()
              : base(3, 1, 80, 460, "Squirtle") { }

        public override bool SpecialMove()
        {

            if (SpecialCount == SpecialNeed)
            {
                SpecialCount = 0;
                isSquirtActive = true;

                return true;
            }

            else
            {
                return false;
            }
        }

        public override bool GetHit(int damage)
        {
            Health -= damage;

            return true;
        }

        public override void Update(Pokemon enemy)
        {

            if (SpecialCount < 2)
            {
                if (originalEnemyAttack == -1)
                {
                    originalEnemyAttack = enemy.AttackDamage;
                }
                enemy.AttackDamage = originalEnemyAttack * 85 / 100;
            }
            else
            {
                enemy.AttackDamage = originalEnemyAttack;
            }
        }

        public override string Print()
        {
            return "Squirtle";
        }

        public override void PrintDescription()
        {
            Console.WriteLine("Squirtle is a water type pokemon. He has a base damage of 80, and has 460 health, leaning him more towards a defense type." +
                "\nHis special ability is to squirt at enemies, therefore reducing their attack damage by 15% for 3 turns." +
                "\nOnce he uses all 3 of his special uses, he won't be able to anymore.");
        }
    }
}
