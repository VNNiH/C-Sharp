using Course.Entities.Exercicio5;
using System;
using System.Globalization;

namespace Course
{
    class Programm
    {
        static void Main(string[] args) 
        {
            List <Product> products = new List <Product>();
            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            for(int i = 1; i <= N;i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char key = char.Parse(Console.ReadLine());
                if(key == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Product product = new Product(name,price);
                    products.Add(product);
                }
                else if (key == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Product product = new UsedProduct(name, price, date);
                    products.Add(product);

                }
                else if (key == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    int price = int.Parse(Console.ReadLine());
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    Product product = new ImportedProduct(name, price, customsFee);
                    products.Add(product);

                }

                Console.WriteLine("PRICE TAGS:");

                foreach(Product product in products)
                {
                    Console.WriteLine(product.PriceTag());
                }
                

            }

        }
    }
}
