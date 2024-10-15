using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x,y;
            x = new Pessoa();
            y = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());
            
            
            if(x.Idade > y.Idade){
            	Console.WriteLine(x.Nome + " é mais velho");
            }
            else{
            	Console.WriteLine(y.Nome + " é mais velho");
            }
            
        }
    }

    class Pessoa
    {
       public string Nome;
       public int Idade;
    }
}
