using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator.Functions;

    public static class MainMenu
    {
        public static string ShowMainMenu()
        {
            return @"
                    ==========================
                    |    M A I N  M E N U    |
                    ==========================
                    | 1. Addition            |
                    | 2. Substraction        |
                    | 3. Multiplication      |
                    | 4. Division            |
                    | 5. Modulo              |
                    | 6. Exit                |  
                    ==========================
                    ";
        }

        public static int SelectOperation()
        {
        int choice;
       while(!int.TryParse(Console.ReadLine(), out choice))

        {
            Console.WriteLine("Error please select a number");
        }
        
        return choice;
        }
    }
