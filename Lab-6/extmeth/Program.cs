using System;
using calculatorlib;
using extensionmethod;
namespace extmeth
{
    class Program
    {
        static void Main(string[] args)
        {
            cal c = new cal
            {
                num1 = 9,
                num2 = 8
            };
            var calc = c.mul();
            Console.WriteLine(calc);

            string ss = c("alphabet");

            
           
        }
      
    }
}
