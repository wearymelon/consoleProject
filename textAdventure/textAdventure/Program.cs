using System.Runtime.InteropServices;

namespace textAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joe is about to fall off a cliff? What should you do?");


            string choice1 = "1. let him fall";
            string choice2 = "2. Grab his hand and try to pull him up";


            Console.WriteLine(choice1);
            Console.WriteLine(choice2);

            string answer = Console.ReadLine();


            if (answer == "1")
            {
                Console.WriteLine("You let him fall and shouted, 'plz take care of Joe jr. for me!!!!'");

                choice1 = "1. say no";
                choice2 = "2. say sure";

                Console.WriteLine(choice1);
                Console.WriteLine(choice2);

                answer = Console.ReadLine();


                if (answer == "1")
                {
                    Console.WriteLine("You run away and get back in your 4x4. You drive along the trail until you get to a big hole in the road that bigger than your car as the road collapsed in on itself in the thick jungle. What do you do?");

                    choice1 = "1. drive as fast as you can, hoping you can clear the gap";
                    choice2 = "2. get out of the car and try to find another way around";

                    Console.WriteLine(choice1);
                    Console.WriteLine(choice2);

                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        Console.WriteLine("you died. You didn't clear the gap and your 4x4 ended up falling into the whole and exploding along with u at the bottom.");

                        Environment.Exit(0);
                    }

                    else if (answer == "2")
                    {
                        Console.WriteLine("you died. You got stuck in an trap set by Joe's wife as she knows u let him die.");


                        Environment.Exit(0);
                    }
                }

                else if (answer == "2")
                {
                    Console.WriteLine("you get back in your 4x4 and drive to the shore of the uncharted island that you are on looking for the boat you came here on to take you back home. Which way do you go?");

                    choice1 = "1. go left";
                    choice2 = "2. go right";

                    Console.WriteLine(choice1);
                    Console.WriteLine(choice2);

                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        Console.WriteLine("you died. You got shot by Joe's wife who was waiting in the boat, knowing you let him die.");
                    
                        Environment.Exit(0);
                    }

                    else if (answer == "1")
                    {
                        Console.WriteLine("you died. You ran into quicksand and you've never watched a youtube tutorial on how to get out so u sink and suffocate.");
                    
                        Environment.Exit(0);
                    }
                }
            }









            else if(answer == "2")
            {
                Console.WriteLine("You grabbed his hand and you slipped off the edge, causing both of you to fall of the cliff. At the bottom of the fall there is a river, do you dive head first of leg first?");

                choice1 = "1. head first";
                choice2 = "2. leg first";

                Console.WriteLine(choice1);
                Console.WriteLine(choice2);

                answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("you died");

                    Environment.Exit(0);
                }

                else if (answer == "2")
                {
                    Console.WriteLine("you have enough time to tell Joe to go leg first and both of you end up landing in the water leg first. You get to the shore in pain from the impact, though realizing that you are lucky to be alive. You and Joe both survived, but you guys see a cave to your left and the continuation of the river towards the right. Which do you choose to go down?");
                    
                    choice1 = "1. go down the cave to your left";
                    choice2 = "2. go along the river to your right";

                    Console.WriteLine(choice1);
                    Console.WriteLine(choice2);

                    answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        Console.WriteLine("as you go down the cave, many spiders waiting in their webs touch your skin irritating you, as the small spiders keep biting you and making you feel uncomfortable as Joe is going through the same. Up ahead is another split, one has a pit of snakes that you could run through in two seconds, and the other continues along a normal path, but with even more spiders in their webs. Which do you choose?");

                        choice1 = "1. go down path with the continued spider webs";
                        choice2 = "2. run through the snake pit in hopes that you can live through a bite or two";

                        Console.WriteLine(choice1);
                        Console.WriteLine(choice2);

                        answer = Console.ReadLine();

                        if (answer == "1")
                        {
                            Console.WriteLine("you died. You run down the continued path of spider webs and you keep gitten bit until you eventually collapse and have a seizure due to the poison. Joe can't help you as he is useless.");
                            
                            Environment.Exit(0);
                        }

                        else if (answer == "2")
                        {
                            Console.WriteLine("you died. You run through the snake pit, but the snakes wrap ur legs along with Joe's and both of you get stuck and die due to getting biteen by like 20 snakes.");

                            Environment.Exit(0);
                        }
                    }

                    else if (answer == "2")
                    {
                        Console.WriteLine("you died. you decide to go down along the river in hopes of finding an exit out of the ravine you fell in. As you start to see light, You and Joe run towards it in hopes of it leading to the beach. Once you get to the light, you see an hungry crocodile, ready to eat anyone who dares go through. You try to back up, but then you realize that the walls of the cave are collapsing. Whichever way you decide to go, you are going to end up dying.");

                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}