using System;
using System.Collections.Generic;
using System.Text;

namespace RealTime3
{
    public class Calc
    {
        public delegate int calculator(int num1, int num2);
        public int addition(int num1,int num2)
        {
            return num1 + num2;
        }
        public int substraction(int num1,int num2)
        {
            return num1 - num2;
        }
        public int multiplication(int num1,int num2)
        {
            return num1 * num2;
        }
        public int division(int num1,int num2)
        {
            return num1 / num2;
        }
        public void Display(calculator d, int num1, int num2)
        {
            Console.WriteLine(d(num1, num2));
        }
    }
}
    
        
    

