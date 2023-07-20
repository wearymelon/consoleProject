using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public class Bank
    {
        private Account[] accounts;

        private int count = 0;

        public Bank(int accountAmount)
        {
            accounts = new Account[accountAmount];
        }

        public void Add(string username, string password)
        {
            if(count >= accounts.Length)
            {
                Account[] tempArray = new Account[accounts.Length * 2];
                
                for(int i = 0; i < accounts.Length; i ++)
                {
                    tempArray[i] = accounts[i].Copy();
                }

                accounts = tempArray;
            }

            accounts[count] = new Account(username,password);

            count++;
        }

        public void Remove(int accountPos)
        {
            for (int i = accountPos; i < accounts.Length - 1; i++)
            {
                accounts[i] = accounts[i + 1];
            }

            accounts[accounts.Length - 1] = null;

            if (count <= accounts.Length / 2)
            {
                Account[] tempArray = new Account[accounts.Length / 2];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = accounts[i].Copy();
                }

                accounts = tempArray;
            }

            count--;
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

        public int Find(string username)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].checkLogIn(username))
                {
                    return i;
                }
            }
            return -1;
        }

        public void transfer(string username, string password, int AmountOfMoney, string receiver)
        {
            accounts[Find(username, password)].withdraw(username, password, AmountOfMoney);

            accounts[Find(receiver)].deposit(AmountOfMoney);
        }


    }
}