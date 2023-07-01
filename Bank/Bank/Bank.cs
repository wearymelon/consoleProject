using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        private Account[] accounts;

        private int count = 0;

        public Bank(int accountAmount)
        {
            accounts = new Account[accountAmount];
        }

        public void Add(Account account)
        {    

            if(count >= accounts.Length)
            {
                Console.WriteLine("You suck. No space buddy.");

                return;
            }

            accounts[count] = account;

            count++;
        }


    }
}
