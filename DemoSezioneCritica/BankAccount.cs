using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSezioneCritica
{
    public class BankAccount
    {
        public int Balance { get; private set; }
        public void Deposit(int Amount)
        {
            Balance += Amount;
        }
        public void Withdraw(int Amount)
        {
            Balance -= Amount;
        }
    }
}
