using System;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa ler um numero inteiro N
            Console.Write("How many employees will be registered ? ");
            int N = int.Parse(Console.ReadLine());

            //criando array de employees
            List<Employee> listEmployees = new List<Employee>();

            for(int i = 1; i <= N; i++)
            {
                //depois ler os atributos do employee
                Console.Write("Employee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                //utilizando .Add para adicionar os employees na listas e passando os parametros do construtor padrao ja definido na class Employee
                listEmployees.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            //criando um novo funcionario caso o id sejam iguais 
            Employee e1 = listEmployees.Find(x => x.Id == idIncrease);
            //criando variavel bool para caso o funcionario nao exista ou exista
            bool employeeExist = false;
            //se e1 for diferente de null entao e1 existe como funcionario
            if(e1 != null)
            {
                employeeExist = true;
            }
            if (employeeExist)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                e1.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            Console.WriteLine();
            //print de todos os employees usando foreach
            Console.WriteLine("Updated list of employees:");
            foreach(Employee e in listEmployees)
            {
                Console.WriteLine(e);
            }
        }

    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Employee()
        {

        }
        public void increaseSalary(double percentage)
        {
            double tax = Salary * (percentage / 100);
            Salary += tax;
        }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Name
                + ", "
                + Salary;
        }
    }
}
