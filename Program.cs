using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string option;
            Console.WriteLine("Press a for addition");
            Console.WriteLine("Press s for substraction");
            Console.WriteLine("Press m for multiplication");
            Console.WriteLine("Press d for division");

            option = Console.ReadLine();
            switch(option)
            {
                case "a":
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The sum is: " + (num1 + num2));
                    break;
                 case "s":
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The difference is: " + (num1 - num2));
                    break;
                    case "m":
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The product is: " + (num1 * num2));
                    break;
                    case "d":
                    Console.WriteLine("Enter first number");
                    num1 = Convert.ToInt32(Console.ReadLine());   
                    Console.WriteLine("Enter second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The quotient is: " + (num1 / num2));
                    break;
                    default:
                    Console.WriteLine("Invalid option");
                    break;
            }
                
        }
    }
}