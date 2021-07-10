using System;

namespace ConsoleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person("Саша", 10);
            //Console.WriteLine(p);
            //Person worker = new Worker("Славік", 25, 45000M);
            //Console.WriteLine(worker);
            Person person;
            Console.WriteLine("З ким вас зконтактувати:");
            Console.WriteLine("1. Клієнтом");
            Console.WriteLine("2. Працівником");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            if (action == 2)
            {
                Console.WriteLine("Введіть зарплату працівника:");
                decimal salary = decimal.Parse(Console.ReadLine());
                person = new Worker(name, age, salary);
            }
            else
            {
                Console.WriteLine("Введіть id client:");
                string transactionId = Console.ReadLine();
                person = new Client(name, age, transactionId);
            }
            Console.WriteLine("Hello");
            Console.WriteLine(person);
        }
    }
}
