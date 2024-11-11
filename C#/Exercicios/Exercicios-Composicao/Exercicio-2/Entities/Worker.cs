using Course.Entities.Exercicio2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities.Exercicio2
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //para não começar null nossa List
        public List<HourContract> Hours { get; set; } = new List<HourContract>();
        //construtor vazio
        public Worker() { }
        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }
        public void AddContract(HourContract contract)
        {
            Hours.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Hours.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = 0.0;
            foreach (HourContract contract in Hours)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }

            }
            return sum + BaseSalary;
        }
    }
}
