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
                Console.WriteLine();
            }

            //steve's answer
            (string product, double amount, int quantity) hammer = ("Hammer", 19.99, 25);
            (string product, double amount, int quantity) nails = ("nails", 9.99, 25);
            (string product, double amount, int quantity) screws = ("screws", 1.99, 25);
            (string product, double amount, int quantity) staples = ("staples", 5.99, 25);
            (string product, double amount, int quantity) level = ("level", 39.99, 25);

            transaction.Add(hammer);
            transaction.Add(nails);
            transaction.Add(screws);
            transaction.Add(staples);
            transaction.Add(level);

            int TotalProductsSold = 0;
            double TotalRevenue = 0;
            foreach ((string product, double amount, int quantity) t in transaction)
            {
                // Logic goes here to look up quantity and amount in each transaction
                TotalProductsSold = +t.quantity;
                TotalRevenue += t.quantity * t.amount;
            }
            Console.WriteLine($"We sold {TotalProductsSold} for a total revenue of {TotalRevenue}");
        }
    }
}
