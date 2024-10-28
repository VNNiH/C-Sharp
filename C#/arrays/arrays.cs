using System;
using System.Globalization;
using System.Numerics;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];
            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
               Console.WriteLine("DIGITE O NUMERO");
                arr[i] = double.Parse(Console.ReadLine());
                sum += arr[i];
            }

            double average = sum / 3;
            Console.WriteLine(average);

            Produto[] vect = new Produto[3];
            double sum = 0;
            
            for(int i = 0; i< n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Produto(name, price);
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine(avg);
        }    
    }
  class Produto
    {
    public string Name { get; set; }
    public double Price { get; set; }

    public Produto(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
}
