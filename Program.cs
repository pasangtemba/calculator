using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            bool flag = false;
            string option;
            Console.WriteLine("Press a for addition");
            Console.WriteLine("Press s for substraction");
            Console.WriteLine("Press m for multiplication");
            Console.WriteLine("Press d for division");
            
            Console.WriteLine("press 1 to find the area ");
            Console.WriteLine("press 2 to find the volume");
            Console.WriteLine("press 3 to check string is palandrom or not");

            int choice = Convert.ToInt32(Console.ReadLine());

          /*  option = Console.ReadLine();


            switch (option)
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
          */
            switch(choice)
            {
                case 1:
                    Console.WriteLine("press 1 to find the area of rectangle ");
                    Console.WriteLine("press 2 to find the area of square");
                    Console.WriteLine("press 3 to find the area of circle");
                    int choice1 = Convert.ToInt32(Console.ReadLine());
                    if (choice1==1)
                    {
                        Console.WriteLine("enter the length ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the breadth");
                        int breadth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the area of rectangle is " + (length * breadth));
                    }
                    else if(choice1== 2)
                    {
                        Console.WriteLine("enter the length of square");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the area of square is " + (length * length));
                    }
                    else if(choice1==3)
                    {
                        Console.WriteLine("enter the radius of circle");
                        int radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the area of circle is " + (3.14 * radius * radius));
                    }
                    else
                    {
                        Console.WriteLine("invalid option");
                    } 
                    break;
                case 2:
                    Console.WriteLine("press 1 to find the volume of cube");
                    Console.WriteLine("press 2 to find the volume of cuboid");
                    Console.WriteLine("press 3 to find the volume of sphere");
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 == 1) 
                    {
                        Console.WriteLine("enter the side of cube");
                        int side = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the volume of cube is " + (side * side * side));
                    }
                    else if(choice2 == 2)
                    {
                          Console.WriteLine("enter the length of cuboid");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the breadth of cuboid");
                        int breadth = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the height of cuboid");
                        int height = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the volume of cuboid is " + (length * breadth * height));
                    }
                    else if(choice2 == 3)
                    {
                        Console.WriteLine("enter the radius of sphere");
                        int radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("the volume of sphere is " + (4/3 * 3.14 * radius * radius * radius));
                    }
                    else
                    {
                        Console.WriteLine("invalid option");    
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the string to check Palandrom");
                    string str = Console.ReadLine();
                    
                    for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
                    {
                        if (str[i] != str[j])
                        {
                            flag = false;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (flag)
                    {
                        Console.WriteLine("The string is Palandrom");
                    }
                    else
                    {
                        Console.WriteLine("The string is not Palandrom");
                    }
                    break;
               default:
                    Console.WriteLine("invalid option");
                    break;
            }

            

        }
    }
}