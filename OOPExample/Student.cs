using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    class Student
    {
        //private string _firstName;
        //private string _lastName;
        private static int _count;
        private int _mark;

        //propfull
        private string _firstName;
        //prop
        public string LastName { get; set; }


        //ctor
        public Student()
        {
            _firstName = "no name";
            LastName = "no name";
            _mark = 1;
            _count++;
        }
        /// <summary>
        /// Оніціалізація
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="mark">Якщо оцінка < 0 і > 13 буде вилітати Exception</param>
        public Student(string firstName, string lastName="", int mark=1)
        {
            _firstName = firstName;
            LastName = lastName;
            Mark = mark;
            _count++;
        }
        public static int GetCountObject
        {
            get
            {
                return _count;
            }
        }
        public static int Length(string str)
        {
            return str.Length;
        }
        //public void SetMark(int mark)
        //{
        //    if (mark >= 1 && mark <= 12)
        //    {
        //        _mark = mark;
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Помилка ініціалізація оцінки");
        //        //throw new Exception("Не валідна оцінка");
        //    }
        //}

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public int Mark { 
            set 
            {
                if (value >= 1 && value <= 12)
                {
                    _mark = value;
                }
                else
                {
                    Debug.WriteLine("Помилка ініціалізація оцінки");
                    //throw new Exception("Не валідна оцінка");
                }
            }
            get
            {
                return _mark;
            }
        }
        public override string ToString()
        {
            string str = $"FistName: {_firstName}\n";
            str += $"LastName: {LastName}\n";
            str += $"Mark: {(_mark == 0 ? "" : _mark.ToString())}";
            return str;
        }
    }
}
