using System.Runtime.CompilerServices;

namespace PokemonBattle
{
    internal class Program
    {
        //make classes for each pokemon type
        //each pokemon type should do different thing for its attack (different ways of getting number, different ranges, etc)

        //have pokemon array
        //have user choose from list of available pokemon which ones to add to their array

        static void Main(string[] args)
        {

            Pokemon[] pokemons = new Pokemon[]
            { 
                new Bulbasaur(),
                new Pikachu(),
                new Charmander(),
                new Squirtle(),
                new Magikarp(),
                new NathanDrake()
            };



            Random random = new Random();

            Pokemon opponent;

            bool isProgramRunning = true;




            while (isProgramRunning)
            {
                Console.WriteLine("press LITERALLY ANY KEY OTHER THAN THIS SH*T -> ~ to start the game");

                string startGame = Console.ReadLine();

                if (startGame != "~")
                {
                    Console.WriteLine("Welcome to Pokemon battle! Choose your pokemon. \n Pikachu (Press 1) \n Bulbasaur (Press 2) \n Charmander (Press 3) \n Squirtle (Press 4) \n Magikarp (Press 5) \n Nathan Drake (Press 6)");

                    string PokemonChosen = Console.ReadLine();

                    int MyPokemon = int.Parse(PokemonChosen) - 1;

                    Console.WriteLine("press 1 to confirm this pokemon. If you dont want this pokemon, press 2");

                    string ConfirmPokemon = Console.ReadLine();

                    if (ConfirmPokemon == "1")
                    {
                        opponent = pokemons[random.Next(0, pokemons.Length)];

                        Console.WriteLine($"Great! Your opponent chose {opponent.Print()}");


                        //

                        while (pokemons[MyPokemon].Health > 0  && opponent.Health > 0)
                        {
                            Console.WriteLine("Would you like to do a basic attack or a special move?");

                            string attackChoice = Console.ReadLine();

                            if (attackChoice == "basic")
                            {
                                pokemons[MyPokemon].BaseAttack(opponent);

                                if (opponent.GetHit(pokemons[MyPokemon].AttackDamage))
                                {
                                    Console.WriteLine($"{opponent.Print()} has taken damage! They are now at {opponent.Health} health. \n");   
                                }

                                //Don't use this line, this was just Nikita's experiment:
                                //Console.WriteLine($"you have " + (opponent.GetHit(pokemons[MyPokemon].AttackDamage, pokemons[MyPokemon]) ? "hit" : "not hit") + " your opponent");


                                if (pokemons[MyPokemon].GetHit(opponent.AttackDamage))
                                {
                                    Console.WriteLine($"Opponent is making a move... You have taken damage! You are now at {pokemons[MyPokemon].Health} health. \n");
                                }
                            }

                            else if (attackChoice == "special")
                            {

                                if (pokemons[MyPokemon].SpecialCount > 0)
                                {

                                    pokemons[MyPokemon].SpecialMove(opponent);



                                    Console.WriteLine($"You have performed your special move! You are at {pokemons[MyPokemon].Health} health and your opponent is at {opponent.Health} health. \n");

                                    Console.WriteLine($"You have {pokemons[MyPokemon].SpecialCount} special uses left before cooldown is required. \n");

                                }

                                else
                                {
                                    Console.WriteLine("You do not have any special uses left! Cooldown is now required.  \n");
                                }

                                if (opponent.SpecialCount > 0)
                                {
                                    opponent.SpecialMove(pokemons[MyPokemon]);


                                    Console.WriteLine($"The opponent has used their special move!  You are at {pokemons[MyPokemon].Health} health and your opponent is at {opponent.Health} health. \n");
                                }
                                else
                                {
                                    Console.WriteLine("Your opponent has tried to use their specal move on you but they are out of uses and need to let it cooldown. Looks like you get to catch a break! \n");
                                }
                            }

                            if (pokemons[MyPokemon].Health <= 0 || opponent.Health <= 0)
                            {
                                continue;
                            }


                            if (Random.Shared.Next(2) == 1 && opponent.SpecialCount >= opponent.SpecialNeed)
                            {
                                opponent.SpecialMove(pokemons[MyPokemon]);
                            }

                            else
                            {
                                opponent.BaseAttack(pokemons[MyPokemon]);
                            }
                        }

                       

                    }
                    else if (ConfirmPokemon == "2")
                    {
                        ;
                    }
                }
            }
        }
    }
}