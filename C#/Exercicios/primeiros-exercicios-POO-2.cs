using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando
            Pessoa x,y;
            x = new Pessoa();
            y = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            x.Nome = Console.ReadLine();
            x.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            y.Nome = Console.ReadLine();
            y.Salario = double.Parse(Console.ReadLine());
            
            double averageSalario = (x.Salario + y.Salario) / 2;
            
            Console.WriteLine("Salario medio: " + averageSalario);
            
        }
    }

    class Pessoa
    {
       public string Nome;
       public double Salario;
    }
}
