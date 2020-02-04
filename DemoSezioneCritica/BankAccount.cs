using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSezioneCritica
{
    public class BankAccount
    {
        public object padlock = new object();
        public int Balance { get; private set; }
        public void Deposit(int Amount)
        {
            lock (padlock)
            {
                Balance += Amount;
            }           
        }
        public void Withdraw(int Amount)
        {
            lock (padlock)
            {
                Balance -= Amount;
            }
        }
    }
}
