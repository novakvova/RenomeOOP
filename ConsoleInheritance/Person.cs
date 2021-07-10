using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheritance
{
    abstract class Person
    {
        private string _name;
        private int _age;
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public override string ToString()
        {
            string str = $"Name: {_name}\n";
            str += $"Age: {_age}";
            return str;
        }
    }
}
