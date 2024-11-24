using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio6
{
    abstract class Employees
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Employees() { }
        public Employees(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
