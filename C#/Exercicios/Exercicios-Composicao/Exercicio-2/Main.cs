using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Enums;
using Course.Entities.Exercicio;
using Course.Entities.Exercicio2;
using Course.Entities.Exercicio2.Enums;

namespace Course
{
    class Main
    {
        static void Main(string[] args) 
        {
            Console.Write("Enter department's name:");
            string departament = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior: ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker?");

            //criando o Worker
            Worker worker = new Worker(name, workerLevel, baseSalary);
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date,valuePerHour,hours);
                worker.AddContract(contract);
            }
            
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY) :");
            DateTime dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(worker.Income(dt.Year, dt.Month));

        }
    }
}
