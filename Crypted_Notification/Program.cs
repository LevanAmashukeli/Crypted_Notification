using System;
using System.Collections.Generic;
using System.Linq;

namespace Crypted_Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to enter? : ");
            int n = int.Parse(Console.ReadLine());

            int[] N = new int[n];
            int[] K = { 1, 2, 3, 4, 5 };
            int Count = 0;

            Console.WriteLine("Enter numbers for massive: ");
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("{0}) ", i + 1);
                N[i] = Int32.Parse(Console.ReadLine());
            }

            IEnumerable<int> both = N.Intersect(K);

            foreach (int id in both)
            {
                Count++;
            }
            if (Count >= 2) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
