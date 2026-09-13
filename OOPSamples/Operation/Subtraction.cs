using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    public class Subtraction
    {
        private double _firstNumber;
        private double _secondNumber;
        private bool _isValid;


        public double FirstNumber => _firstNumber;
        public double SecondNumber => _secondNumber;

        public bool IsValid => _isValid;

        public Subtraction(double firstNumber, double secondNumber)
        {
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;

            if (_secondNumber == 0)
            {

                _isValid = false;
            }

            else
            {
                _isValid = true;
            }
        }
        public double CalculateDifference()
        {
            return _firstNumber - _secondNumber;
        }

        public string ShowDifference()
        {
            return $"The Difference of {_firstNumber} and {_secondNumber} is {CalculateDifference()}";
        }
    }
}