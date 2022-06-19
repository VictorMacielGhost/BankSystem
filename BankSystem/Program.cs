using System;

namespace BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            User User = new User("null", 1, 0);
            Console.WriteLine("Type The account Number: ");
            int numberAcount = int.Parse(Console.ReadLine());
            Console.WriteLine("Type The User name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The account will have initial balance? (y/n)");
            string action = Console.ReadLine();
            if (action.Equals("n"))
            {
                User User1 = new User(userName, numberAcount);
                User = User1;
            }
            else if(action.Equals("y"))
            {
                Console.WriteLine("Type The How Much The User will have of initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                User User1 = new User(userName, numberAcount, balance);
                User = User1;
            }
            else Console.WriteLine("Error! Only can be used y or N !");
            User.ShowUserStats();
            Console.WriteLine("Insert The Value Of the Deposit: ");
            double deposit = double.Parse(Console.ReadLine());
            User.MakeDeposit(deposit);
            Console.WriteLine("Insert the value of the WithDrawal: ");
            double withdrawal = double.Parse(Console.ReadLine());
            User.MakeWithdrawal(withdrawal);
        }
    }
}
