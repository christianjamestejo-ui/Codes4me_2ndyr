using Calculator.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Operation
{
    public class Division
    {
        private double _dividend;
        private double _divisor;
        private bool _isValid;


        public double Dividend => _dividend;
        public double Diviser => _divisor;

        public bool IsValid => _isValid;

        public Division(double dividend, double divisor)
        {
            _dividend = dividend;
            _divisor = divisor;

            if (divisor == 0)
            {

                _isValid = false;
            }

            else
            {
                _isValid = true;
            }
        }


    }

}


