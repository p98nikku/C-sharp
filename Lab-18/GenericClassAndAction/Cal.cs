using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClassAndAction
{
    public class Cal<T>
    {
        public T echo;
        public void Display(Action t) {
            t();
        }
    }
}
