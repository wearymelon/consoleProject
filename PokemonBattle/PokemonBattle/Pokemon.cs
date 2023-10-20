using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {
        public Pokemon(int specialCount, int specialNeed, int damage, int health, string pokemonName)
        {
            SpecialNeed = specialNeed;
            SpecialCount = specialCount;
            AttackDamage = damage;
            Health = health;
            InitialHealth = health;
        }


        //REMOVE WRITELINES FROM INDIVIDUAL CLASSES AND MAKE A BOOLEAN THAT CHECKS IF YOU GOT HIT INSTEAD
        //THEN YOU WOULD USE THAT BOOLEAN IN THE ABSTRACT POKEMON CLASS IN ORDER TO BE ABLE TO TELL IF
        //IT IS YOUR POKEMON IN THE MAIN PROGRAM WHILE RUNNING THE GAME

        public int SpecialNeed; 

        public int SpecialCount;

        public int AttackDamage;

        public int Health;

        public bool IsStunned;

        public bool isPlayer;

        public string PokemonName;


        private int InitialHealth;


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
            return enemy.GetHit(AttackDamage);

            if (enemy.Health <= 0)
            {
                return false;
            }
        }

        public abstract bool SpecialMove(Pokemon enemy);


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
        public abstract bool GetHit(int damage);

        public abstract string Print();

        public abstract void PrintDescription();


        public virtual void ResetInitialHealth()
        {
            Health = InitialHealth;
        }
    }
}
