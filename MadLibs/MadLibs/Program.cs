namespace MadLibs
{
    internal class Program
    {

       /// <summary>
       /// Console.WriteLine("Whats your favorite fruit?");
       /// string reply = Console.ReadLine();
       /// Console.WriteLine($"I hate {reply}");
       /// </summary>
                    


        /// <summary>
        /// Ask the user for a noun, verb, adverb, adjective, and another nown.
        /// 
        /// Create a sentence or two with the given words.
        /// </summary>
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me a noun");
            string nounReply = Console.ReadLine();

            Console.WriteLine("Please give me a verb");
            string verbReply = Console.ReadLine();

            Console.WriteLine("Please give me an adverb");
            string adverbReply = Console.ReadLine();

            Console.WriteLine("Please give me another noun");
            string anotherNounReply = Console.ReadLine();


            Console.WriteLine($"my {nounReply} were {verbReply} very {adverbReply} throughout my beautiful {anotherNounReply}");
        }
    }
}