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
            //criando variaveis que irão ser linhas (M) e colunas (N)
            int L, C;
            Console.WriteLine("INSIRA A QUANTIDADE DE LINHAS");
            L = int.Parse(Console.ReadLine());
            Console.WriteLine("INSIRA A QUANTIDADE DE COLUNAS");
            C = int.Parse(Console.ReadLine());

            //criando matriz bidimensional
            int[,] matriz = new int[L, C];
            //criando numero para armazenar na matriz
            int number;

            //i percorre as linhas
            for(int i = 0; i < L; i++)
            {
                //j percorre as colunas
                for(int j = 0; j < C; j++)
                {
                    Console.WriteLine($"INSIRA O DADO PARA A POSIÇÃO [{i}, {j}]");
                    number = int.Parse(Console.ReadLine());
                    matriz[i, j] = number;
                }
            }
            //loops for para imprimir matriz
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); // Quebra de linha após cada linha da matriz
            }
            //criando variavel que irá ter as posicoes imprimidas na tela
            Console.WriteLine("Insira um valor existente na matriz para ver suas posições");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < L; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (matriz[i, j] == X)
                    {
                        Console.WriteLine($"POSITION [{i}, {j}]");
                        if(i > 0)
                        {
                            Console.WriteLine($"UP: {matriz[i - 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Não tem");
                        }
                        if (i < L - 1)
                        {
                            Console.WriteLine($"DOWN: {matriz[i + 1, j]}");
                        }
                        else
                        {
                            Console.WriteLine("Não tem");
                        }
                        if (j > 0)
                        {
                            Console.WriteLine($"LEFT: {matriz[i, j - 1]}");
                        }
                        else
                        {
                            Console.WriteLine("Não tem");
                        }
                        if (j < C - 1)
                        {
                            Console.WriteLine($"RIGHT: {matriz[i, j+1]}");
                        }
                        else
                        {
                            Console.WriteLine("Não tem");
                        }
                    }
                }
                Console.WriteLine(); // Quebra de linha após cada linha da matriz
            }
        }

    }

}
