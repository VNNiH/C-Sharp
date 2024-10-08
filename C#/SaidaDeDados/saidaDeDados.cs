using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            int age = 24;
            double cash = 10.3213;
            string name = "Vinicius";
            //como colocar um formato na qtde de casas decimais, no caso sao duas casas decimais apos a virgula
            Console.WriteLine(cash.ToString("F2"));
            //placeholder concatenação interpolação
            //começando pelo placeholder, dentro das chaves nos referenciamos um valor (indexado) e dps colocamos qual variavel deve compor essa chave {numero index variavel)
            Console.WriteLine("{0} tem {1} anos e {2} reais",name,age,cash);
            //interpolação igual no PHP sempre começar com o cifrão
            Console.WriteLine($"{name} tem {age} e {cash} reais");
            //concatenação igual no JS
            Console.WriteLine(name + " tem " + age + " e " + cash.ToString("F2") + " reais");
        }
    }
}
