namespace arrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int something[5];
            int[] something = new int[10];

            int evenNumbers = 2;

            for (int i = 0; i < something.Length; i++)
            {
                something[i] = evenNumbers;

                evenNumbers = evenNumbers + 2;
            } 



            for (int i = 0; i < something.Length; i++)
            {
                bool isDivBy4 = something[i] % 4 == 0;

                if (isDivBy4 == true)
                {
                    something[i] = 0;
                }

                
            }



            for (int i = 1; i < something.Length; i ++)
            {
                something[i - 1] = something[i];
            }

            something[9] = 0;


            for (int i = 0; i < something.Length; i++)
            {
                Console.WriteLine(something[i]);
            }


        }
    }
}