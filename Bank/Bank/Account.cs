using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bank
{
    public class Account
    {

        private int balance;

        private string username;

        private string password;

        public Account(string username, string password) 
        {
            balance = 0;

            this.username = username;

            this.password = password;


        }

        public void deposit(string username, string password, int amountOfMoney)
        {
            if(checkLogIn(username, password))
            {
                balance += amountOfMoney;
            }
        }

        public void withdraw(string username, string password, int amountOfMoney)
        {
            if (checkLogIn(username, password))
            {
                balance -= amountOfMoney;
            }
        }

        public void transfer(string username, string password, int amountOfMoney)
        {

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
    }
}
