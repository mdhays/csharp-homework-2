using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("../../example.txt");
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string output = new string(inputArray);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
