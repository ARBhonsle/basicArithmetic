using System;

namespace basicArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arithmetic operations");
            Console.WriteLine("Adding, subtracting and multiplying, modulus numbers");
            Console.WriteLine("Enter number a :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number b :");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Sum of given numbers: " + a + " and " + b + " is " + c);
            c = a - b;
            Console.WriteLine("Difference between given numbers: " + a + " and " + b + " is " + c);
            c = a * b;
            Console.WriteLine("Multiplication of given numbers: " + a + " and " + b + " is " + c);
            c = a % b;
            Console.WriteLine("Modulus of given numbers: " + a + " and " + b + " is " + c);
            Console.WriteLine("Exiting Application ....");
        }
    }
}
