using System;
using System.Globalization;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //exec 1
            int G = int.Parse(Console.ReadLine());

            for (int i = 0; i <= G; i++)
            {
                if (i % 2 == 1)
              {
                    Console.WriteLine(i);
                }
            }
            //exec 2
            int H = int.Parse(Console.ReadLine());
            int nIn = 0;
            int nOut = 0;
            for (int i = 0; i < H; i++)
            {

                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    nIn++;
                }
                else
                {
                    nOut++;
                }
            }
            Console.WriteLine(nIn + " in");
            Console.WriteLine(nOut + " out");
            //exec 3
            int y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
            //exec 4
            int Z = int.Parse(Console.ReadLine());
            for (int i = 0; i < Z; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double numerador = double.Parse(line[0]);
                double denominador = double.Parse(line[1]);

                if(denominador == 0)
                {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                Console.WriteLine(numerador / denominador);
            }
            //exec 5
            int number = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= number; i++)
            {
               fat = fat * i;
            }

            Console.WriteLine(fat);

            //exec 6
           int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                Console.Write(i + " ");
                Console.Write(i*i + " ");
                Console.Write(i*i*i + " ");
                Console.WriteLine();
            }
        }
    }
}
