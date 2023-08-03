namespace Bank2
{
    using System.Security.Cryptography.X509Certificates;
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

            bool isProgramRunning = true;

            while (isProgramRunning)
            {
                Console.WriteLine("plz log in, create an account, remove an account, or view accounts.");

                string response = Console.ReadLine();

                if (response == "log in")
                {
                    while (!LoggedIn)
                    {
                        Console.WriteLine("plz enter username.");

                        string usernameResponse = Console.ReadLine();


                        Console.WriteLine("plz enter password.");

                        string passwordResponse = Console.ReadLine();


                    bool result = bank.Login(username, password);

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

                        else if (LoggedIn)
                        {

                            /*
                             * make sure to specify which account you are reffering to in order to be able to
                             * deposit, withdraw, or transfer money from that specific account.
                            */




                            Console.WriteLine("would you like to deposit, withdraw, or transfer money?");

                            response = Console.ReadLine();

                            if (response == "deposit")
                            {
                                Console.WriteLine("how much money would you like to deposit?");

                                int AmountOfMoney = int.Parse(response);

                               // deposit(AmountOfMoney);       (make sure to put the specified account in front of deposit.)
                            }
                        }
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

                if (response == "remove")
                {
                    Console.WriteLine("please enter the username of the account that you would like to remove.");

                    string username = Console.ReadLine();


                    Console.WriteLine("Now please enter the password for the account you would like to remove.");

                    string password = Console.ReadLine();


                    int result = bank.Find(username,password);

                    if (result == -1)
                    {
                        Console.WriteLine("you cannot remove an account that does not exist.");
                    }
                    else
                    {
                        bank.Remove(result);
                    }
                }

                if (response == "view")
                {
                    bank.PrintAccounts();
                }
            }
        }
    }
}