using ConsoleApp1.Math;
using System;

namespace ConsoleApp1
{
    //classes and objects
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "john";
            john.LastName = "smith";
            john.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.add(1, 2);
            Console.WriteLine(result);

            //Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
        }
    }
}
