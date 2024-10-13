using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //exec 1
            int password = int.Parse(Console.ReadLine());
            while (password != 2002)
            {
                Console.WriteLine("SENHA INVALIDA");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("ACESSO PERMITIDO");
            //exec 2
            string[] s = Console.ReadLine().Split(" ");

            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Q1");  // Primeiro quadrante
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Q4");  // Quarto quadrante
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Q3");  // Terceiro quadrante
                }
                else
                {
                    Console.WriteLine("Q2");  // Segundo quadrante
                }
                s = Console.ReadLine().Split(" ");

                x = int.Parse(s[0]);
                y = int.Parse(s[1]);

            }
            //exec 3
            int option = int.Parse(Console.ReadLine());

            int countAlcool = 0;
            int countGasolina = 0;
            int countDiesel = 0;


            while (option != 4)
            {
                if (option == 1)
                {
                    countAlcool++;
                }
                else if (option == 2)
                {
                    countGasolina++;
                }
                else if (option == 3)
                {
                    countDiesel++;
                }
                option = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + countAlcool);
            Console.WriteLine("GASOLINA: " + countGasolina);
            Console.WriteLine("Diesel: " + countDiesel);

        }
    }
}
