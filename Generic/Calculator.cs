using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Calculator<T1,T2> where T1 :struct where T2:struct
    {
        public double Addition(T1 a, T2 b)
        {
            return Convert.ToInt32(a) + Convert.ToInt32(b);
        }
        public double Subtraction(T1 a, T2 b)
        {
           
            return Convert.ToInt32(a) - Convert.ToInt32(b); 
        }
        public double Multiplication(T1 a, T2 b)
        {
           
            return Convert.ToInt32(a) * Convert.ToInt32(b);
        }
       
    }
}
