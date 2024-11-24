using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio6
{
    class CompanyEmployees : Employees
    {
        public int NumberOfEmployees { get; set; }
        public CompanyEmployee(string name, double anualIncome,int numberOfEmployees) : base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double Tax()
        {
            double tax = 0.0;
            if(NumberOfEmployees > 10) 
            {
                tax = AnualIncome * 0.14;
                return tax;
            }
            else
            {
                tax = AnualIncome * 0.16;
                return tax;
            }
        }
    }
}
