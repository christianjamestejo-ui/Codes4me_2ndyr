using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    
    public class Multiplication
    {
        private double _firstNumber;
        private double _secondNumber;

        public double FirstNumber => _firstNumber;

        public double SecondNumber => _secondNumber;

        public Multiplication(double firstNumber, double secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }

        public double CalculateProduct()
        { 
            return _firstNumber * _secondNumber;

        }

        public string ShowProduct()
        {
            return $"The Product of {_firstNumber} and {_secondNumber} is {CalculateProduct()}";
        }
    }

}    
    
    
    

