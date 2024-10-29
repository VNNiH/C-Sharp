using System;
using System.Globalization;
using System.Numerics;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (type variableName in arrayName)
            //{
            //code
            //}

            //instanciando e ja inserindo valores no array
            string[] vect = new string[] { "Jamile", "Guga", "Gaba" };

            foreach (string nome in vect)
            {
                Console.WriteLine(nome);
            }

            //usando o for para fazer a mesma coisa que o foreach
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
        }

    }

}
