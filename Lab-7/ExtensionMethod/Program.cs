using calculatorLibrary;
using System;


namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            int n = str.countVowels();
            Console.WriteLine(n);


            Calculator cal = new Calculator
            {
                Num1 = 3,
                Num2 = 8

            };
            Console.WriteLine(cal.mul());
            Console.WriteLine(cal.add());


        }
    }
}