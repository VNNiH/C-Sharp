using System.Collections.Generic;
using Course.Entities.Abstratas;
using System;
using Course.Entities.Enums;
using Course.Entities.Exercicio6;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> listEmp = new List<Employees>();
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)");
                char key = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (key == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    Employees emp = new IndividualEmployee(name, anualIncome, healthExpenditures);
                    listEmp.Add(emp);
                }
                else if (key == 'c')
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Employees emp = new CompanyEmployee(name, anualIncome, numberOfEmployees);
                    listEmp.Add(emp);
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Employees tp in listEmp)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
    
