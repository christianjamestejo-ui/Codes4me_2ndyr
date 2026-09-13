using Calculator.Functions;
using Calculator.Operation;
using Practice.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.structure 

{
    class Program
    {

        static void Main()
        {
            bool run = true;
            while (run)
            {
                Console.WriteLine(MainMenu.ShowMainMenu());
                Console.Write("Enter your choice:");
                int choice = MainMenu.SelectOperation();
                
                switch (choice)
                {
                    case 1:
                        Addition();
                        break;

                    case 2:
                        Subtraction();
                        break;

                    case 3:
                        Multiplication();
                        break;

                    case 4:
                        Division();
                        break;

                    case 5:
                        Module();
                        break;

                    case 6:
                        Console.WriteLine("Goodbye!");
                        run = false;
                        break;
                }
            }
        }

                  public static void Addition()
                  {
                     Console.WriteLine("Enter First Number:");
                     double firstNumber = Convert.ToDouble(Console.ReadLine());
                     Console.WriteLine($"Enter second number:");
                     double secondNumber = Convert.ToDouble(Console.ReadLine());
                    Addition addition = new Addition(firstNumber, secondNumber);
                    Console.WriteLine(addition.ShowProduct());
                  }


        public static void Subtraction()
        {
            Console.WriteLine("Enter First Number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Subtraction subtraction = new Subtraction(firstNumber, secondNumber);

            if (subtraction.IsValid)
            {
                Console.WriteLine(subtraction.ShowDifference());
            }
            else
            {
                Console.WriteLine("Invalid subtraction.");
            }
        }


        public static void Multiplication()
        {
            Console.WriteLine("Enter First Number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Multiplication multiplication = new Multiplication(firstNumber, secondNumber);

            Console.WriteLine(multiplication.ShowProduct());
        }
        
        
        public static void Division()
        {
            Console.WriteLine("Enter First Number:");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double divisor = Convert.ToDouble(Console.ReadLine());

            Division division = new Division(dividend, divisor);

            if (division.IsValid)
            {
                Console.WriteLine($"The result is {dividend / divisor}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

        public static void Module()
        {
            Console.WriteLine("Enter First Number:");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            Modulo modulo = new Modulo(dividend, divisor);

            if (modulo.CanCompute)
            {
                Console.WriteLine($"The remainder is {modulo.GetRemainder()}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }

}









