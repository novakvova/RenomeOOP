using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheritance
{
    class Worker : Person
    {
        private decimal _salary;
        public Worker() : base("no name", 24)
        {
            _salary = 6600.34M;
        }
        public Worker(string name, int age, decimal salary=0.0M)
            : base(name, age)
        {
            _salary = salary;
        }
        public override string ToString()
        {
            string str = base.ToString()+"\n";
            str += "Salary: " + _salary;
            return str; ;
        }
    }
}
