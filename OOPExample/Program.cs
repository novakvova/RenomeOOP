using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //int t = int.Parse("df");

            Student peter = new Student(); //new Student("Славік", "Федоров", -5);
            peter.Mark = -10;
            peter.LastName = "Hello";
            peter.FirstName = "asdfasfd";
            Console.WriteLine(peter);

            Console.WriteLine("Count: {0}", Student.GetCountObject);
            Student pasha = new Student(firstName: "Pasha", mark: 8);
            Console.WriteLine(pasha);
            Console.WriteLine("Count: {0}", Student.GetCountObject);
            //Math.Min(23, 45);
            Student.Length("sdfsdf");
            //Student.GetCountObject;
            //Console.WriteLine(peter.Mark);


            //new Student();
            //peter.FistName = "Петро";
            //peter.LastName = "Іванов";
            //peter.Mark = -5;

        }
    }
}
