using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank2
{
    public class Account
    {

        public int balance { get; private set; }

        private string username;

        private string password;

        public Account(string username, string password) 
        {
            balance = 0;

            this.username = username;

            this.password = password;


        }

        public void deposit(int amountOfMoney)
        {
            balance += amountOfMoney;
        }

        public void withdraw(string username, string password, int amountOfMoney)
        {
            if (checkLogIn(username, password))
            {
                balance -= amountOfMoney;
            }
        }

        public bool checkLogIn(string username, string password)
        {
            if (this.username == username && this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkLogIn(string username)
        {
            if (this.username == username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Account Copy()
        {
            Account result = new Account(username, password);

            result.balance = balance;


            return result;
        }

        public void Print()
        {
            Console.WriteLine($"{username}, {password}");
        }
    }
}
