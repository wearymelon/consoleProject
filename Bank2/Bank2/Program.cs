namespace Bank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //make a bank class vV
            //bank has an array of accounts (account is another class) vV
            //account has general info (money, username, password) vV

            //balance, username, and password SHOULD NOT be public. vV

            //make menu to login and deposit/withdraw/transfer money

            //make the account array work the same was as shopping list (expand vV/contract vV) vV

            Console.WriteLine("hey, welcome. plz log in or create account.");

            string response = Console.ReadLine();


            if (response == "log in")
            {
                Console.WriteLine("plz enter username.");

                string userResponse = Console.ReadLine();
            }

            else if (response == "create")
            {
                Console.WriteLine("plz make username.");

                string newUsername = Console.ReadLine();


                Console.WriteLine("now make password.");

                string newPassword = Console.ReadLine();


                Console.WriteLine($"please confirm.\n username: {newUsername} \n password: {newPassword}");
            }
        }
    }
}