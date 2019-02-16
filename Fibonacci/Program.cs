using System;
using Fibonacci.Models;

namespace Fibonacci
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Which term would you like?");
            int NthTerm = int.Parse(Console.ReadLine());
            Counter counter=new Counter(NthTerm);
            Console.WriteLine(counter.SetNumbers());
        }
    }
}