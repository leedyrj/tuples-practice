using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transaction = new List<(string, double, int)>();

            transaction.Add(("Computers", 1999.99, 3));
            transaction.Add(("Phones", 999.99, 7));
            transaction.Add(("Games", 59.99, 42));
            transaction.Add(("DVD's", 24.99, 24));
            transaction.Add(("Tablets", 575.99, 13));

            foreach ((string product, double amount, int quantity) t in transaction)
            {
                // Logic goes here to look up quantity and amount in each transaction
                Console.WriteLine($"{t.product} sold today: {t.quantity}");
                Console.WriteLine($"Total revenue:{t.quantity * t.amount}");
            }

        }
    }
}
