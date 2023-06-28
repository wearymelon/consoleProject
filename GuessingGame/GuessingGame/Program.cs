namespace GuessingGame
{
    internal class Program
    {

        /// <summary>
        /// 
        /// Have the user enter a number between 1 - 100.
        /// Tell the user if the number is too high, too low, or correct.
        /// If the user takes too many tries, the user loses.
        /// Ask the user if they want to play again
        /// 
        /// 
        /// 
        /// Console.WriteLine("Give me your favorite number");
        /// int number = int.Parse(Console.ReadLine());
        /// 
        /// </summary>

        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);


            bool isProgramRunning = true;

            while (isProgramRunning)
            {
                int counter = 0;

                randomNumber = random.Next(1, 101);

                while (counter < 5)
                {

                    Console.WriteLine("Choose a number between 1 - 100");
                    int number = int.Parse(Console.ReadLine());

                    if (number < randomNumber)
                    {
                        Console.WriteLine("Too low, try again");
                    }
                    else if (number > randomNumber)
                    {
                        Console.WriteLine("Too high, try again");
                    }
                    else if (number == randomNumber)
                    {
                        Console.WriteLine("Nice, you got it right. Pat yourself on your back you Shakesperian");

                        break;
                    }

                    counter++;


                }

                Console.WriteLine($"The number was {randomNumber}");


                Console.WriteLine("would you like to play again?");
                string answer = Console.ReadLine();

                if (answer == "yes")
                {
                    isProgramRunning = true;

                    Console.Clear();
                }
                else
                {
                    isProgramRunning= false;

                    Console.Clear();
                }
            }

        }
    }
}