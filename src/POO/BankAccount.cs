using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class BankAccount
    {
        private double Balance = 0;
        public AccountOwner Owner { get; set; }

        public BankAccount(AccountOwner owner)
        {
            this.Owner = owner;
        }
        public void Deposit(double value)
        {
            this.Balance += value;
            Console.WriteLine("Your deposit was made satisfactorily");
        }
        public bool Withdraw(double value)
        {
            bool result = false;
            if (Balance >= value)
            {
                this.Balance -= value;
                result = true;
            }
            return result;
        }
        public double GetBalance()
        {
            return this.Balance;
        }
    }
}
