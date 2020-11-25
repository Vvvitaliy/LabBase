using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Enter the operation sign (+, -, *, /): ");
            bool check;
            do
            {
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine("{0} + {1} = {2}", a, b, Addition(a, b));
                        check = false;
                        break;
                    case "-":
                        Console.WriteLine("{0} - {1} = {2}", a, b, Subtraction(a, b));
                        check = false;
                        break;
                    case "*":
                        Console.WriteLine("{0} * {1} = {2}", a, b, Multiplication(a, b));
                        check = false;
                        break;
                    case "/":
                        Console.WriteLine("{0} / {1} = {2}", a, b, Division(a, b));
                        check = false;
                        break;
                    default:
                        Console.Write("Incorrect operation sign. Try again: ");
                        check = true;
                        break;
                }
            } while (check);
            
        }

        public static double Addition(double a, double b)
        {
            return a + b;
        }

        public static double Subtraction(double a, double b)
        {
            return a - b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
