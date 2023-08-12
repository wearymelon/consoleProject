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
            //Pokemon[] pokemons = new Pokemon[5];

            //Pokemon[] pokemons = new Pokemon[]
            //{
            //    new Bulbasaur(),
            //    new Pikachu(),
            //    new Charmander(),
            //    new Squirtle(),
            //    new Magikarp()
            //};

            string[] pokemons = new string[]
            {
                "Bulbasaur",
                "Pikachu",
                "Charmander",
                "Squirtle",
                "Magikarp"
            };



            Random random = new Random();

            int randomOpponent = random.Next(1, 6);

            bool isProgramRunning = true;


            while (isProgramRunning)
            {
                Console.WriteLine("Welcome to Pokemon battle! Choose your pokemon. \n Pikachu (Press 1) \n Bulbasaur (Press 2) \n Charmander (Press 3) \n Squirtle (Press 4) \n Magikarp (Press 5)");

                string PokemonChosen = Console.ReadLine();

                if (PokemonChosen == "1")
                { 
                    Console.WriteLine("press ' to confirm this pokemon. If you dont want this pokemon, press :");

                    string ConfirmPokemon = Console.ReadLine();

                    if (ConfirmPokemon == "'")
                    {
                        int MyPokemon = int.Parse(PokemonChosen);

                        if (randomOpponent == MyPokemon)
                        {
                            randomOpponent = random.Next(1, 6);
                        }

                        Console.WriteLine($"Great! Your opponent chose {pokemons[randomOpponent]}");
                    }
                    else if (ConfirmPokemon == ":")
                    {

                    }
                }
            }
        }
    }
}