using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operation
{
    public  class Modulo
    {
        private int _dividend;
        private int _divisor;
        private bool _canCompute;

        public int Dividend => _dividend;
        public int Divisor => _divisor; 
        public bool CanCompute => _canCompute; 

      public Modulo(int dividend, int divisor)
      {
            if (divisor == 0)
            {
                _canCompute = false; 
            }
            else
            {
                _canCompute = true; 
            }
      }    
       
        public int GetRemainder()
        {
            return _dividend % _divisor; 
        }
    




    }

}
