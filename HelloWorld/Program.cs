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

            string[] cars = { "Proton", "Perodua", "BMW", "Merc" };
            foreach (string p in cars)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");


            // C# Break

            Console.WriteLine(" This is C# Break");
            Console.WriteLine(" ");

            for (int pp = 0; pp < 10; pp++)
            {
                if (pp == 4)
                {
                    break;
                }
                    Console.WriteLine(pp);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# Continue
            Console.WriteLine(" This is C# Continue");
            Console.WriteLine(" ");

            for (int ly = 0; ly < 9; ly++)
            {
                if ( ly == 4)
                {
                    continue;
                }
                Console.WriteLine(ly);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# Arrays
            Console.WriteLine(" This is C# Arrays");
            Console.WriteLine(" ");

            string[] kereta = { "BMW","Mercs","Proton","Perodua"};
            Console.WriteLine(kereta.Length);

            int[] nomborr = { 10, 11, 12 };
            Console.WriteLine(nomborr[0]);

            string[] kereta1 = { "BMW", "Mercs", "Proton", "Perodua" };
            kereta1[0] = "Nissan";
            Console.WriteLine(kereta1[0]);


            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# Loop Through Arrays
            Console.WriteLine(" This is C# Loop Through Arrays");
            Console.WriteLine(" ");

            string[] modelkereta = {"320z","Evo 12","135","Satria" };
            for (int mk = 0; mk < modelkereta.Length; mk++)
            {
                Console.WriteLine(modelkereta[mk]);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# Foreach Array Loop
            Console.WriteLine(" This is C# Foreach Array Loop");
            Console.WriteLine(" ");

            string[] modelmotor = {"135 LC","Duke 250","NVX" };
            foreach (string kkl in modelmotor)
            {
                Console.WriteLine(kkl);
            }

            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# Sort Arrays
            Console.WriteLine(" This is C# xxxxx");
            Console.WriteLine(" ");



            Console.WriteLine("========================");
            Console.WriteLine(" ");

            // C# XXXXX
            Console.WriteLine(" This is C# xxxxx");
            Console.WriteLine(" ");



            Console.WriteLine("========================");
            Console.WriteLine(" ");


        }

    }

}
