using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CS_Step219
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string number = Convert.ToString(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\guvin\source\repos\CS_Step219\log.txt", true))
            {
                file.WriteLine(number);
            }
            using (StreamReader file = new StreamReader(@"C:\Users\guvin\source\repos\CS_Step219\log.txt"))
            {
                Console.WriteLine("\n\nThe numbers currently logged to the text file are:\n" + file.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
