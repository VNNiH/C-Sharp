using Course.Entities.Exercicio4;
using Course.Entities.Heranca;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Enther the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            //criando Lista de Funcionarios
            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced(y / n) ?");
                char key = char.Parse(Console.ReadLine());
                if( key == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee employee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(employee);
                }
                else 
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(name,hours,valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("PAYMENTS");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment());
            }
        }
    }
}
