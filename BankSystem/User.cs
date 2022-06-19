using System;
using System.Collections.Generic;
using System.Text;

namespace BankSystem
{
    class User
    {
        private string _userName;
        private double _balance;
        public int AccountNumber { get; private set; }

        public User(string username, int accountnumber, double balance = 0.0)
        {
            if (SetUserName(username) == 0) Console.WriteLine("Error! User Name Might be More than 3 characters!");
            if (SetUSerAccountNumber(accountnumber) == 0) Console.WriteLine("Error! Account Number Might Be More than 0!");
            SetUserBalance(balance);
        }

        public string GetUserName()
        {
            return this._userName;
        }

        public int SetUserName(string name)
        {
            if (name.Length < 3) return 0;
            else
            {
                name.Trim();
                this._userName = name;
                return 1;
            }
        }

        public double GetUserBalance()
        {
            return this._balance;
        }

        public int SetUserBalance(double balance)
        {
            if (balance == 0) return 0;
            else
            {
                this._balance += balance;
                return 1;
            }
        }

        private int SetUSerAccountNumber(int accountnumber)
        {
            if (accountnumber < 1) return 0;
            else
            {
                this.AccountNumber = accountnumber;
                return 1;
            }
        }

        public int MakeDeposit(double desposit)
        {
            if (desposit < 1) return 0;
            else
            {
                int result = this.SetUserBalance(desposit);
                this.ShowUserStats();
                return result;
            }
        }

        public int MakeWithdrawal(double withdrawal)
        {
            if (withdrawal < 0) return 0;
            else
            {
                withdrawal += 5;
                int result = SetUserBalance(-withdrawal);
                this.ShowUserStats();
                return result;
            }
        }

        public override string ToString()
        {
            return "Account Number: " + this.AccountNumber +
                " User Name: " + this.GetUserName() +
                " Balance: " + this.GetUserBalance() + " R$";
        }

        public void ShowUserStats()
        {
            Console.WriteLine(ToString());
        }

    }
}
