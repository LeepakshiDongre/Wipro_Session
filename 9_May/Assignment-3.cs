// Subtracting
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculator
    { 
        //Addition Overloading
        public int Sub(int a, int b)
        {
            return a - b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}



using ConsoleApp2;
using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        //Addition
        Console.WriteLine("Subtraction:");
        Console.WriteLine("3 - 2 = " + calc.Sub(2, 3));
        Console.WriteLine("3.7 - 2.5 = " + calc.Sub(3.7, 2.5));
        Console.WriteLine("7 - 2 - 3 = " + calc.Sub(7, 2, 1));
    }
}




//Multiplying
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculator
    { 
        //Addition Overloading
        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a - b;
        }

        public int Mul(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}

using ConsoleApp2;
using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        //Addition
        Console.WriteLine("Multiplication:");
        Console.WriteLine("3 * 2 = " + calc.Mul(2, 3));
        Console.WriteLine("3.7 * 2.5 = " + calc.Mul(3.7, 2.5));
        Console.WriteLine("7 * 2 * 3 = " + calc.Mul(7, 2, 1));
    }
}