using System;
using static RealTime3.Calc;

namespace RealTime3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            Calc.calculator D = c.multiplication;
            c.Display(D, 12, 12);

        }
    }
}
