using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[5] { 100, 200, 300, 400, 500 };
            for (int i = 0; i <number.Length; i++)
            {
                Console.WriteLine($"   {number[i]  }");
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            string[] name = new string[5] { "Uddhav", "pavan", "Rahul", "Anil", "Sachin" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"   {name[i]}");
            }
        }
    }
}
