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

        int squirtCount = 3;
        bool isSquirtActive = false;
        public Squirtle()
              : base(80, 460, "Squirtle") { }

        public override void SpecialMove(Pokemon enemy)
        {
            squirtCount = 0;
            isSquirtActive = true;
        }

        public override void GetHit(int damage, Pokemon enemy)
        {
            Health -= damage;
        }

        public override void Update(Pokemon enemy)
        {

            if (squirtCount < 2)
            {
                if (originalEnemyAttack == -1)
                {
                    originalEnemyAttack = enemy.AttackDamage;
                }
                enemy.AttackDamage = originalEnemyAttack * 85 / 100;


                Console.WriteLine("Squirtle has now reduced the opponents attack damage by 15% for 2 turns. Deal with it!");
            }
            else
            {
                enemy.AttackDamage = originalEnemyAttack;
            }

            squirtCount++;

        }

        public override string Print()
        {
            return "Squirtle";
        }
    }
}
