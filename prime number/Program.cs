using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //...........prime number..............
           for (int i = 1; i <= 100; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
