using System;
using System.Globalization;
using System.Numerics;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing e unboxing
            //boxing é a conversão de tipo valor para um objeto tipo referencia compativel
            int x = 20;
            Object obj = x;
            //criei um objeto e coloquei um tipo valor para ele receber, agora se criou no heap uma nova instancia object com valor 20
            Console.WriteLine(obj);
            Console.WriteLine(x);
            //unboxing é a conversao do tipo referencia para o tipo valor compativel
            //necessitando do casting para o compilador nao alegar erro de incompatibilidade
            //obj é compativel com int y
            int y = (int)obj;
            Console.WriteLine(y);
        }

    }

}
