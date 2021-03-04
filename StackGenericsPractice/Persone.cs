using System;
using System.Collections.Generic;
using System.Text;

namespace StackGenericsPractice
{
    class Persone
    {

        public string Name;
        public int Salary;

        public Persone(string Name, int Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return string.Join(" ", $"Name: {Name} Salary: {Salary}");
        }


    }
}
