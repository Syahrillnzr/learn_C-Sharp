using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld3
{
    class Program
    {
        static void TestMethod()
        {
            Console.WriteLine("Hey , its me");
        }

        // C# Method - Parameter

        static void fullnames(string fnames)
        {
            Console.WriteLine(fnames + " Goodman");
        }

        // C# Method - Default Parameter

        static void namaNegara(string naNegara = "Norway")
        {
            Console.WriteLine(naNegara);
        }

        // C# Method - Return Value

        static int nilaiTambah(int x)
        {
            return 5 + x;
        }

        static int nilaiXY(int x, int y)
        {
            return x + y;

        }

        // C# Named Arguments

        static void NamaAnak(string anak1, string anak2 , string anak3)
        {
            Console.WriteLine("Anak paling muda ialah " + anak3);
        }

        // C# Method Overloading

        static int PlusMethd(int a , int b)
        {
            return a + b;
        }

        static double PlusMethd(double c , double d)
        {
            return c + d;
        }

        static void Main(string[] args)
        {
            // C# Methods
            // Used to called a method that will executed when called
            // for example , this method print " Hey , Its me " 
            Console.WriteLine("C# Methods");
            Console.WriteLine(" ");
            TestMethod();
            TestMethod();
            TestMethod();
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");

            // C# Method - Parameters and Arguments
            Console.WriteLine("C# Method - Parameters and Arguments");
            Console.WriteLine(" ");
            fullnames("Liam");
            fullnames("Loykes");
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");

            // C# Method - Defaut Parameters
            Console.WriteLine("C# Method - Defaut Parameters");
            Console.WriteLine(" ");
            namaNegara("Malaysia");
            namaNegara("Gambia");
            namaNegara();
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");


            // C# Method - Return Value
            Console.WriteLine("C# Method - Return Value");
            Console.WriteLine(" ");
            Console.WriteLine(nilaiTambah(3));

            int z = nilaiXY(5, 3);
            Console.WriteLine(z);
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");

            // C# Named Arguments
            Console.WriteLine("C# Named Arguments");
            Console.WriteLine(" ");
            NamaAnak(anak2: "Ali", anak3:"Lisa",anak1:"Amir");
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");

            // C# - Method Overloading
            Console.WriteLine("C# - Method Overloading");
            Console.WriteLine(" ");

            int MyNum1 = PlusMethd(8, 9);
            double MyNum2 = PlusMethd(11.8, 0.4);

            Console.WriteLine(MyNum1);
            Console.WriteLine(MyNum2);
            Console.WriteLine(" ======================= ");

            Console.WriteLine(" ");
        }

    }

}
