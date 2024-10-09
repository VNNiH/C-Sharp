using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //ENTRADA DE DADOS
            string s = Console.ReadLine();
            //PODEMOS DEFINIR ONDE SEPARAR AS STRINGS UTILIZANDO O METODO SPLIT 
            string[] frutas = s.Split(" ");
            string banana = frutas[0];
            string maca = frutas[1];
            string abacaxi = frutas[2];
            Console.WriteLine(banana + " "  + maca + " " + abacaxi);

            //PARA CONVERTER STRING PARA UM OUTRO TIPO NOS USAMOS TIPO.Parse(string);
            string x = Console.ReadLine();
            string[] numbers = x.Split(" ");
            int n1 = int.Parse(numbers[0]);
            int n2 = int.Parse(numbers[1]);
            int n3 = int.Parse(numbers[2]);
            //NUMERO DOUBLE É SEMPRE PARA DIGITAR COM VIRGULA E NAO PONTO
            double n4 = double.Parse(numbers[3]);

            Console.WriteLine(n1 + " " + n2 + " " + n3 + " " + n4);
        }
    }
}
