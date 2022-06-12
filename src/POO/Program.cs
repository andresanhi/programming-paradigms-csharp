using System;

namespace POO
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Client!");
            AccountOwner owner = new("Andres", "Angulo", Guid.NewGuid().ToString());
            BankAccount account = new(owner);

            account.Deposit(500);
            if (account.Withdraw(150))
            {
                Console.WriteLine($"Your balance is: {account.GetBalance()}");
            }
            else
            {
                Console.WriteLine("your balance is less than the amount to withdraw");
            }
        }
    }
}
