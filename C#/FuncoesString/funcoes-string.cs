using System;
using System.Globalization;
using System.Numerics;
using System.Xml.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //funçoes pertencem ao namespace System
            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            //trim elimina espaços em branco que nao estao entre strings
            string s3 = original.Trim();
            //procurando um index onde se inicia a condição
            int n1 = original.IndexOf("bc");
            //procurando o ultimo index onde se inicia a condição
            int n2 = original.LastIndexOf("bc");
            //recortando string a partir de um index
            string s4 = original.Substring(3);
            //recortando string a partir de um index e delimitando o numero de caracteres a partir do index p ser recortado
            //espaços em brancos tambem contam como caractere
            string s5 = original.Substring(3,5);
            //utilizando replace para trocar caracteres
            string s6 = original.Replace('a', 'x');
            //replace em strings
            string s7 = original.Replace("abc", "xy");
            //verificando se uma string é null ou empty "";
            bool isNull = String.IsNullOrEmpty(original);
            //verifica se é nulo ou espaço em branco " ";
            bool isNullSpace = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("TOUPPER : -" + s1 + "-");
            Console.WriteLine("tolower : -" + s2 + "-");
            Console.WriteLine("TRIM : -" + s3 + "-");
            Console.WriteLine("Index of('bc'): " + n1);
            Console.WriteLine("Last index of('bc'): " + n2);
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3,5): " + s5);
            Console.WriteLine("Replace('a', 'x') : -" + s6 + "-");
            Console.WriteLine("Replace(abc, xy) : -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty : -" + isNull + "-");
            Console.WriteLine("IsNullOrWhiteSpace : -" + isNullSpace + "-");
            //existe outras funções que ja foram usados no curso
            //split
            //.Parse - Convert
            //ToString
        }
    }

}
