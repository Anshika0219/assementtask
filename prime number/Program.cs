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
           Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
             int i,count=0;
             for (i = 2; i < num; i++)
             {
                 if (num % i == 0)
                 {
                     count++;
                     break;
                 }
             }
             if (count == 0)
             {
                 Console.WriteLine("Prime Number");
             }
             else
             {
                 Console.WriteLine("not a Prime Number");
             }
        }
    }
}
