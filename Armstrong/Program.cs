using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, r = 0, sum = 0, t;
            Console.WriteLine("Enter Number ");
            n = int.Parse(Console.ReadLine());
            t = n;
            while(n!=0)
            {
                r = n % 10;
                sum = sum + r * r * r;
                n= n / 10;
            }
            if (sum == t)
                Console.WriteLine("given number is armstrong");
            else
                Console.WriteLine("given number is not armstrong");
        }

    }
}
