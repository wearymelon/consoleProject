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

        public override bool SpecialMove(Pokemon enemy)
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

            if (SpecialCount < SpecialNeed)
            {
                SpecialCount++;
            }
        }

        public override string Print()
        {
            return "Squirtle";
        }
    }
}
