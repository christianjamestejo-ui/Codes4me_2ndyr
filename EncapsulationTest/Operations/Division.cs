using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTest.Operations
{
    public class Division
    {
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }

        public Division()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public void InputNumbersForDivision()
        {
            Console.WriteLine("Enter First Number: ");
            FirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Number: ");
            SecondNumber = int.Parse(Console.ReadLine());
            do
            {
                double.TryParse(Console.ReadLine(), out var result);
            } while (result);
        }

        public string ShowQuotient()
        {
            return $"The Quotient of {FirstNumber} and {SecondNumber} is {FirstNumber / SecondNumber}";
        }
    }
}
