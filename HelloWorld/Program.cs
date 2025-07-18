using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Car!");
            Console.WriteLine(3 + 3);

            // this comment
            Console.WriteLine("Hehehehe");

            Console.WriteLine("HAHAHAHA");  // print HAHAHAHA

            /* HWHWHW
             * HDHADHA
            */

            string name = "Neymar Jr";
            Console.WriteLine(name);


            int myNum = 15;
            const int myNum2 = 35;

            Console.WriteLine((myNum + 5) * 2);


            Console.Write(name + " is " + myNum2 + " years old.");
            Console.WriteLine(" ");
            Console.WriteLine("========================");

            // Type Casting

            int myNombor = 12;
            double myDoubleNombor = myNombor;

            Console.WriteLine(myNombor);
            Console.WriteLine(myDoubleNombor);
            Console.WriteLine("========================");


            // Explict Casting

            double myDouble = 9.78;
            int myInt = (int)myDouble;

            Console.WriteLine(myDouble);
            Console.WriteLine(myInt);
            Console.WriteLine("========================");

            // Type conversion

            Console.WriteLine(" This is Type C# Conversion Tutorial ");
            Console.WriteLine(" ");

            int myIntNom = 10;
            double myDoubleSpecial = 2.20;
            bool myBoolHa = true;

            Console.WriteLine(Convert.ToString(myIntNom));
            Console.WriteLine(Convert.ToInt32(myDoubleSpecial));
            Console.WriteLine(Convert.ToString(myBoolHa));
            Console.WriteLine("========================");

            // user Input
            Console.WriteLine(" This is User C# Input Tutorial ");

            Console.WriteLine(" ");
            Console.Write("Enter your username: ");

            string username = Console.ReadLine();

            Console.WriteLine("Your username is: " + username + " :)");


            Console.WriteLine(" ");
            Console.Write("Please enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age + " years old older and wiser...");
            Console.WriteLine("========================");

            //Operator

            // a) Artithemetic

            Console.WriteLine(" This is C# Artithemetic Tutorial ");
            Console.WriteLine(" ");

            int x = 10 + 12;
            Console.WriteLine(x);

            int sum1 = 12 + 3;
            int sum2 = sum1 + 30;
            int sum3 = sum2 + sum2;
            Console.WriteLine(sum3);


            int xy = 10 + 2;
            xy++;
            Console.WriteLine(xy);
            Console.WriteLine("========================");

            // b) Assignment

            Console.WriteLine(" This is C# Assigment Tutorial ");
            Console.WriteLine(" ");

            int ty = 3;
            ty += 1;
            Console.WriteLine(ty);


            int xc = 3;
            xc += 1;
            Console.WriteLine(xc);
            Console.WriteLine("========================");


            // c) Comparison

            Console.WriteLine(" This is C# Comparison Tutorial ");
            Console.WriteLine(" ");

            int y = 10;
            int z = 6;

            Console.WriteLine(y > z);
            Console.WriteLine(y < z);
            Console.WriteLine(y == z);
            Console.WriteLine(y != z);
            Console.WriteLine(y >= z);
            Console.WriteLine(y <= z);
            Console.WriteLine("========================");

            // d) Logical

            Console.WriteLine(" This is C# Logical Tutorial ");
            Console.WriteLine(" ");

            int cv = 5;
            Console.WriteLine(cv > 3 && cv < 10);
            Console.WriteLine(cv > 3 || cv < 10);
            Console.WriteLine(!(cv > 3 && cv < 10));
            Console.WriteLine("========================");


            // C# Math

            Console.WriteLine("This is C# Math Tutorial ");
            Console.WriteLine(" ");

            Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(34));
            Console.WriteLine(Math.Abs(-47));
            Console.WriteLine(Math.Round(9.90));
            Console.WriteLine("========================");


            // C# Strings

            Console.WriteLine("This is C# Strings");
            Console.WriteLine(" ");

            string txt = "Gugu gaga";
            Console.WriteLine(txt);

            string txtlong = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The text are: " + txtlong.Length); // show how much 
                                                                  // lenght of that string

            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(" ");


            // C# String Concatenation

            Console.WriteLine(" This is C# String Concatenation");
            Console.WriteLine(" ");

            string firstname = "Valentino ";
            string lastname = "Rossi";
            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            string nama = string.Concat(firstname, lastname);
            Console.WriteLine(nama);

            int k = 19;
            int l = 10;

            Console.WriteLine(k + l);

            string b = "19";
            string c = "20";
            string m = b + c;
            Console.WriteLine(m);
            Console.WriteLine("========================");


            // C# String Interpolation

            Console.WriteLine(" This is C# String Interpolation");
            Console.WriteLine(" ");

            string firname = "Valentino ";
            string lasname = "Rossi";
            string namee = $"My full name is: {firname} {lasname}";
            Console.WriteLine(namee);
            Console.WriteLine("========================");

            // C# Access Strings

            Console.WriteLine(" this is C# Access Strings");
            Console.WriteLine(" ");

            string greet = "Hello";
            Console.WriteLine(greet[0]); // output H
            Console.WriteLine(greet.IndexOf("e")); // output 1
            Console.WriteLine(greet.Substring(1)); // output ello
            Console.WriteLine("========================");

            // C# Special Characters
            Console.WriteLine(" This is C# Special Characters");
            Console.WriteLine(" ");

            string viki = " This is so called \"Viking\" ";
            string viki1 = " it\' al right ";
            string viki2 = " This call \\ backslah ";
            Console.WriteLine(viki);
            Console.WriteLine(viki1);
            Console.WriteLine(viki2);
            Console.WriteLine("========================");

        }
    }
}
