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
              : base(3, 80, 460, "Squirtle") { }

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
                Console.WriteLine("insufficient amount of turns played since last special move.");

                return false;
            }
        }

        public override void GetHit(int damage, Pokemon enemy, bool isPlayer)
        {
            Health -= damage;
            

            if (isPlayer == true)
            {
                Console.WriteLine($"you have been damaged! You are now at {Health} health.");
            }
            else
            {
                Console.WriteLine($"you have damaged Squirtle! He is now at {Health} health.");    
            }
            
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


                Console.WriteLine("Squirtle has now reduced the opponents attack damage by 15% for 2 turns. Deal with it!");
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
