using System;
using System.Collections.Generic;
using System.Text;

namespace polystringoverload
{
    public class person
    {
        public string name;
        public int age;
        public void InsertUserDetails(string name, int age)
        {

            this.name = name;
            this.age = age;

        }

        public string ToString()
        {
            string s = this.name + " is " + this.age + " year old";
            Console.WriteLine(s);
            return s;
        }
    }
}
