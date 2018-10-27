using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        private int _id;
        private double _salary;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                {
                    _id = 0;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    _salary = 0;
                }
                else
                {
                    _salary = Math.Round(value, 2);
                }
            }
        }

        public Employee(int id, double salary)
        {
            Id = id;
            Salary = salary;
        }

        internal void PrintInfo()
        {
            Console.WriteLine($"Сотрудник с табельным номером {Id} имеет оклад {Salary} руб.");
        }
    }
}
