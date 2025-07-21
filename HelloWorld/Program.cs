using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // C# Foreach Loop

            Console.WriteLine(" This is C# Foreach Loop");
            Console.WriteLine(" ");

            string [] cars = {"Proton" ,"Perodua","BMW","Merc"};
            foreach (string p in cars) 
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");

        }

    }

}
