using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTest.Operations
{
    public class Multiplication
    {
        private int FirstNumber { get; set; }
        private int SecondNumber { get; set; }

        public Multiplication()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }

        public void InputNumbersForMultiplication()
        {
            Console.WriteLine("Enter First Number: ");
            FirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Number: ");
            SecondNumber = int.Parse(Console.ReadLine());
        }

        public string ShowProduct()
        {
            return $"The Product of {FirstNumber} and {SecondNumber} is {FirstNumber * SecondNumber}";
        }
    }
}

