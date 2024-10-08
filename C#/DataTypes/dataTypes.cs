using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //Dentro dos tipos inteiros existe as funcoes de minimo e maximo dos numeros
            int n1 = int.MinValue; int n2 = int.MaxValue;
            //so colocar o tipo e MinValue ou MaxValue
            Console.WriteLine(n1  + " N2= "+ n2);
            //menor numero int só vai ate 127, no caso desse WriteLine é pq o c# pega o 1(int) e transforma o x (sbyte) em int por isso fica 128 pq nao pe mais sbyte e sim int
            sbyte x = 127;
            Console.WriteLine(x+1);
            //float deve ter o f no final para sinalizar pro compilador que é um float e nao um double
            float y = 1.0f;
            //a msm coisa o Long com o L
            long z = 100000L;
            //bool
            bool verdade = true;
            Console.WriteLine(verdade);
            //char é entre aspas simples
            char gender = 'F';
            Console.WriteLine(gender);
            //Podemos colocar o codigo unicode para ser representado semopre começando com \u para indicar pro compiler o codigo unicode
            char word = '\u0041';
            Console.WriteLine(word);
            //string -> não é um tipo básico do c# ele é uma cadeia de caracteres(array de chars) e é IMUTÁVEL
            string nome = "Maria Green";
            Console.WriteLine(nome);
            //object -> objeto generico (toda classe em c# é subclasse de object)
            object obj1 = "Alex Brown";
            //ou seja, o tipo object aceita qlqr coisa pq tudo é OBJECT
            object obj2 = 10231;
            
        }
    }
}
