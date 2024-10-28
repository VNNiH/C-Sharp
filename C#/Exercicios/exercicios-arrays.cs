using System;
using System.Globalization;
using System.Numerics;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando 10 quartos vazios do tipo Pousada
            Pousada[] quartos = new Pousada[10];
            //criando variavel para saber qtde de quartos
            Console.WriteLine("Quantos quartos serão alugados?");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Aluguel " + i + "#");
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto:");
                int quarto = int.Parse(Console.ReadLine());
                quartos[quarto] = new Pousada(name, email);
            }
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }
        }

        
    }
    class Pousada
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Pousada(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
