using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression2
{
    
        public class Intobj<T>
        {


            public int intobj { get; set; }

            public void Display(int x)
            {
                Console.WriteLine(x*x);
            }
        }
    
}
