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
    /// <summary>
    /// sausage and potato bank
    /// </summary>
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
            if (count >= accounts.Length)
            {
                Account[] tempArray = new Account[accounts.Length * 2];

                for (int i = 0; i < accounts.Length; i++)
                {
                    tempArray[i] = accounts[i].Copy();
                }

                accounts = tempArray;
            }

            accounts[count] = new Account(username, password);

            count++;
        }

        public void Remove(string username, string password)
        {
            int accountPos = Find(username, password);

            for (int i = accountPos; i < accounts.Length - 1; i++)
            {
                accounts[i] = accounts[i + 1];
            }

            accounts[accounts.Length - 1] = null;

            if (count + 2 <= accounts.Length / 2)
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

        private int Find(string username, string password)
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

        private int Find(string username)
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

        public void withdraw(string username, string password, int amount)
        {
            accounts[Find(username, password)].withdraw(username, password, amount);
        }

        public void deposit(string username, int amount)
        {
            accounts[Find(username)].deposit(amount);
        }

        public void PrintAccounts()
        {
            for (int i = 0; i < count; i++)
            {
                accounts[i].Print();
            }
        }

        public bool Login(string username, string password)
        {
            //return whether the account exists


            int result = Find(username, password);

            if (result == -1)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public int getBalance(string username, string password)
        {
            return accounts[Find(username, password)].balance;
        }
    }
}