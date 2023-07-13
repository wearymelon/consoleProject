using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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

        public void Remove(int accountPos)
        {
            for (int i = 0; i < )
            {

            }
        }

        public int Find(string username, string password)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].checkLogIn(username, password))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
