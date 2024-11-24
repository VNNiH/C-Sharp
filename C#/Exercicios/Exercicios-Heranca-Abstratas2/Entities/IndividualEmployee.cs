using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio6
{
    class IndividualEmployee : Employees
    {
        public double HealthExpenditures { get; set; }
        public IndividualEmployee() { }
        public IndividualEmployee(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }

        }
    }
}
