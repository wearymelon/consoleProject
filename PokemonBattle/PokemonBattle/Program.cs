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
                new Pikachu(),
                new Bulbasaur(),
                new Charmander(),
                new Squirtle(),
                new Magikarp(),
                new NathanDrake()
            };



            Random random = new Random();

            Pokemon opponent;


            bool didYouWin = false;

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

                        Console.WriteLine($"Great! Your opponent chose {opponent.Print()}.");


                        Console.WriteLine($"Your starting health is {pokemons[MyPokemon].Health} and your opponent's starting health is {opponent.Health}");


                        //

                        while (pokemons[MyPokemon].Health > 0  && opponent.Health > 0)
                        {
                            Console.WriteLine("press 1 for basic attack and press 2 for special");

                            string attackChoice = Console.ReadLine();

                            if (attackChoice == "1")
                            {


                                if (pokemons[MyPokemon].BaseAttack(opponent))
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

                            else if (attackChoice == "2")
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


                                    opponent.SpecialCount--;


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


                            if (Random.Shared.Next(3) == 1 && opponent.SpecialCount >= opponent.SpecialNeed)
                            {
                                opponent.SpecialMove(pokemons[MyPokemon]);
                            }

                            else
                            {
                                opponent.BaseAttack(pokemons[MyPokemon]);
                            }


                            if (opponent.Health <= 0 && opponent.Health < pokemons[MyPokemon].Health)
                            {
                                didYouWin = true;
                            }

                            else if (pokemons[MyPokemon].Health <= 0 && pokemons[MyPokemon].Health < opponent.Health)
                            {
                                didYouWin = false;
                            }


                            pokemons[MyPokemon].Update(opponent);

                            opponent.Update(pokemons[MyPokemon]);

                        }

                        if (didYouWin != true)
                        {
                            Console.WriteLine("You have won and triumphed over your opponent! \n");
                        }

                        else
                        {
                            Console.WriteLine("You have been defeated at the hand of your opponent! \n \n");
                        }

                        Console.WriteLine("Would you like to play again??");

                        string playAgainResponse = Console.ReadLine();


                        if (playAgainResponse == "yes")
                        {
                            startGame = "s";
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