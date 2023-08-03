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
                    Console.WriteLine("plz enter username.");

                    string username = Console.ReadLine();


                    Console.WriteLine("plz enter password.");

                    string password = Console.ReadLine();


                    bool result = bank.Login(username, password);

                    if (!result)
                    {
                        Console.WriteLine("this account doesn't exist. Would you like to make an account?");

                        string response2 = Console.ReadLine();

                        LoggedIn = false;

                        if (response2 == "yes")
                        {
                            response = "create";

                        }
                    }
                    else
                    {
                        LoggedIn = true;
                    }

                    while (LoggedIn)
                    {

                        /*
                         * make sure to specify which account you are reffering to in order to be able to
                         * deposit, withdraw, or transfer money from that specific account.
                        */

                        Console.WriteLine("would you like to deposit, withdraw, transfer, view funds, or log out?");

                        response = Console.ReadLine();

                        if (response == "deposit")
                        {
                            Console.WriteLine("how much money would you like to deposit?");

                            bank.deposit(username, int.Parse(Console.ReadLine()));
                        }

                        if (response == "withdraw")
                        {
                            Console.WriteLine("how much money would you like to withdraw?");

                            bank.withdraw(username, password, int.Parse(Console.ReadLine()));
                        }

                        if (response == "transfer")
                        {
                            Console.WriteLine("how much money would you like to transfer?");

                            int amount = int.Parse(Console.ReadLine());

                            Console.WriteLine("who would you like to transfer money to?");

                            string receiver = Console.ReadLine();

                            bank.transfer(username, password, amount, receiver);
                        }

                        if (response == "view")
                        {
                            Console.WriteLine(bank.getBalance(username, password).ToString());
                        }

                        if (response == "log out")
                        {
                            LoggedIn = false;
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


                    if (bank.Login(username, password))
                    {
                        bank.Remove(username, password);
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