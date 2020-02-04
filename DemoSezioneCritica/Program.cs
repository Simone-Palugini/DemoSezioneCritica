using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoSezioneCritica
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tasks = new List<Task>();
            var ba = new BankAccount();

            for (int i = 0; i < 10; i++)
            {
                Tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        ba.Deposit(100);
                    }
                }));

                Tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        ba.Withdraw(100);
                    }
                }));

                Task.WaitAll(Tasks.ToArray());

                Console.WriteLine($"Final balanvce is {ba.Balance}.");

                Console.ReadLine();
            }
        }
    }
}
