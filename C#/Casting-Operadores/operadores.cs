using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //OPERADOR DE ATRIBUIÇÃO
            int a = 10;
            // a = 10 % 3; -> 10/3 = 3 e o resto 1
            Console.WriteLine(a %= 3);

            string s = "abc";
            Console.WriteLine(s);
            s += "def";
            Console.WriteLine(s);
            //OPERADOR ARITMETICOS
            int y = 5;
            //nesse caso o c# avalia primeiro e soma depois por isso que no primeiro CW o valor de b é 5 e no ultimo já conta as duas operações ou seja (7)
            int b = y++;
            Console.WriteLine(b);//5
            int z = ++y;
            Console.WriteLine(y);//7
            //CASTING
            int x;
            double h;
            h = 5.9;
            x = (int)h;
            Console.WriteLine(x);//5 mesmo sendo 5.9 o c# joga o valor para baixo, entao perdemos informacao ao realizar esse casting
        }
    }
}
