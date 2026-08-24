using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTest.Functions
{
    public static class OperationsMenu
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
                    | 5. Exit                |
                    ==========================
                    ";
        }

        public static int SelectOperation()
        {
            Console.WriteLine("-=CHOOSE OPERATION=-");
            int.TryParse(Console.ReadLine(), out int result);
            return result;
        }
    }
}
