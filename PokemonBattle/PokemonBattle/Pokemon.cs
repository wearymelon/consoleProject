using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {
        public Pokemon(int damage, int health)
        {
            AttackDamage = damage;
            Health = health;
        }

        public int AttackDamage;

        public int Health;

        //public bool Stunned;

        /// <summary>
        /// Attacking the enemy Pokemon
        /// </summary>
        /// <param name="enemy">the enemy</param>
        /// <returns></returns>
        public bool BaseAttack(Pokemon enemy)
        {
            enemy.Health = enemy.Health - AttackDamage;

            if (enemy.Health <= 0)
            {
                return true;
            }

            return false;
        }

        public abstract bool SpecialAttack(Pokemon enemy);


        public virtual void AIAttack(Pokemon enemy, Random rand)
        {
            if (rand.Next(2) == 0)
            {
                BaseAttack(enemy);
            }
            else
            {
                SpecialAttack(enemy);
            }

        }

        /// <summary>
        /// happens every turn no matter what you do (use this for persistant effects like poison)
        /// </summary>
        /// <param name="enemy"></param>
        public abstract void Update(Pokemon enemy);

        /// <summary>
        /// When you get hit by an enemy
        /// </summary>
        /// <param name="damage">how much the enemy attemps to damage you by</param>
        /// <param name="enemy">the enemy damaging you</param>
        public abstract void GetHit(int damage, Pokemon enemy);


    }
}
