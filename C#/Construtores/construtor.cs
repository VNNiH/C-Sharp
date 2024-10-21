using System;
using System.Collections.Generic;
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00);
            Console.WriteLine(p);
        }
        class Produto
        {
            public string Nome;
            public double Preco;
            public int Quantidade;

            //criando um construtor para meu objeto com 3 parametros
            //o construtor sempre é o mesmo nome da CLASS
            public Produto(string nome, double preco, int quantidade)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
            }
            //podemos criar varios construtores isso se chama SOBRECARGA
            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
                Quantidade = 10;
            }
            //podemos criar o construtor padrão que é sem os parametros
            public Produto()
            {
            }
            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }
            public void AdicionarProdutos(int quantidade)
            {
                Quantidade += quantidade;
            }
            public void RemoverProdutos(int quantidade)
            {
                Quantidade -= quantidade;
            }
            public override string ToString()
            {
                return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
        }

    }
}
