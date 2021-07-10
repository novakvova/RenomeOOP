using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheritance
{
    class Client : Person
    {
        private string _transactionId;
        public Client() : base("no name", 24)
        {
            _transactionId = Guid.NewGuid().ToString();
        }
        public Client(string name, int age, string transactionId)
            : base(name, age)
        {
            _transactionId = transactionId;
        }
        public override string ToString()
        {
            string str = base.ToString() + "\n";
            str += "TransactionId: " + _transactionId;
            return str; ;
        }
    }
}
