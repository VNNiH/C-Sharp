// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee();
        
        emp.Name = Console.ReadLine();
        emp.FullSalary = double.Parse(Console.ReadLine());
        emp.Tax = double.Parse(Console.ReadLine());
        
        Console.WriteLine(emp.Name + " " + emp.salarioLiquido());
        
        Console.WriteLine("Digite a porcentagem para aumentar o salario : ");
        double porcentagem = double.Parse(Console.ReadLine());
        emp.aumentarSalario(porcentagem);
        
        Console.WriteLine(emp.Name + " " + emp.FullSalary);
    }
    
    class Employee{
        public string Name;
        public double FullSalary;
        public double Tax;
        
        public double salarioLiquido(){
            return FullSalary - Tax;
        }
        
        public void aumentarSalario(double porcentagem){
            FullSalary *= (porcentagem/100);
        }
    }
}
