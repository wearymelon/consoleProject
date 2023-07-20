namespace Bank2
{
    using колбаса_с_картофелем = Bank;
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



            колбаса_с_картофелем bank = new колбаса_с_картофелем(4);
            bool LoggedIn = false;

            Console.WriteLine("hey, welcome. plz log in or create account.");

            string response = Console.ReadLine();

            if (response == "log in")
            {
                while (!LoggedIn)
                {
                    Console.WriteLine("plz enter username.");

                    string usernameResponse = Console.ReadLine();


                    Console.WriteLine("plz enter password.");

                    string passwordResponse = Console.ReadLine();


                    int result = bank.Find(usernameResponse, passwordResponse);

                    if (result == -1)
                    {
                        Console.WriteLine("this account doesn't exist. Would you like to make an account?");

                        string response2 = Console.ReadLine();

                        LoggedIn = false;

                        if (response2 == "yes")
                        {
                            response = "create";

                            LoggedIn = true;
                        }
                    }
                    else LoggedIn = true;
                }
            }

            if (response == "create")
            {
                Console.WriteLine("plz make username.");

                string newUsername = Console.ReadLine();


                Console.WriteLine("now make password.");

                string newPassword = Console.ReadLine();


                Console.WriteLine($"please confirm.\n username: {newUsername} \n password: {newPassword}");


                string confirmResponse = Console.ReadLine();

                if (confirmResponse == "yes")
                {
                    bank.Add(newUsername, newPassword);
                }


            }
        }
    }
}