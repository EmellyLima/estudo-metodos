using System;
using System.Collections.Generic;
using System.Text;
using Exceçoes.Entities.Excepition;

namespace Exceçoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdraLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdraLimit;
        }

        public void Deposit(double amount)
        {
             Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > Balance)
            {
                throw new DomainAccount("The amount exceeds withdraw limit");
            }
            if(amount <= 0)
            {
                throw new DomainAccount("The amount exceeds withdraw limit");
            }
            if(Balance < WithdrawLimit)
            {
                throw new DomainAccount(" Not enough balance");
            }
            
             Balance -= amount;
        }

    }
}
