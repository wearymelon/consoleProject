/*
 * Make number
 * say no or yes to robot
 * if he guess
 * he win
 * if not
 * he lose
 * 5 tries
 */


namespace reverseGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int randomNumber;


            bool isGameRunning = true;

            while (isGameRunning)
            {
                int min = 1;

                int max = 100;

                int counter = 0;
                
                randomNumber = randomGenerator.Next(1, 101);

                while (counter < 5)
                {

                    Console.WriteLine($"my guess is {randomNumber}");
                    string answer = Console.ReadLine();


                    if (answer == "too high")
                    {
                        max = randomNumber;

                        randomNumber = randomGenerator.Next(min, max);
                    }
                    else if (answer == "too low")
                    {
                        min = randomNumber;

                        randomNumber = randomGenerator.Next(min + 1, max);
                    }
                    else
                    {
                        break;
                    }


                    counter++;
                }

                Console.WriteLine("You got pretty lucky there, didn't you. Don't worry, if your not scared enough to play again, here. Wanna play again?");
                string response = Console.ReadLine();
                
                
                if(response == "yes")
                {
                    Console.Clear(); 

                    isGameRunning = true;
                }
                else
                {
                    isGameRunning = false;
                }

            }

        }
    }
}