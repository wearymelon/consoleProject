using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {
        public Pokemon(int damage, int health, string pokemonName)
        {
            AttackDamage = damage;
            Health = health;
        }

        public int AttackDamage;

        public int Health;

        public bool IsStunned;

        public string PokemonName;


        /// <summary>
        /// Attacking the enemy Pokemon
        /// </summary
        /// 
      /* "I did not pikachoose this"
       * `;-.          ___,
          `.`\_...._/`.-"`
            \        /      ,
            / .  .   \    .' `-._
           |)  .    ()\  /   _.'
           \  -'-     ,; '. <
           / ,    / ,  |.-'.-'
          (_/    (_/ ,;|.<`
            (_,-'`> .'
    */
        /// <param name="enemy">the enemy</param>
        /// <returns></returns>
        public bool BaseAttack(Pokemon enemy)
        {
            enemy.GetHit(AttackDamage, this);

            if (enemy.Health <= 0)
            {
                return true;
            }

            return false;
        }

        public abstract void SpecialMove(Pokemon enemy);


        public virtual void AIAttack(Pokemon enemy, Random rand)
        {
            if (rand.Next(2) == 0)
            {
                BaseAttack(enemy);
            }
            else
            {
                SpecialMove(enemy);
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

        public abstract string Print();
      
    }
}
