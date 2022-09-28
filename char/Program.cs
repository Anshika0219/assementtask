using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            Console.WriteLine("enter a charcter");
            char value = Convert.ToChar(Console.ReadLine());
            Boolean result = str.Contains(value);
            Console.WriteLine(result);
        }
        }
    }

