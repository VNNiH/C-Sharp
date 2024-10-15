using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Cria uma instância de Retangulo
        Retangulo retangulo1 = new Retangulo();
        
        // Entrada de dados
        Console.WriteLine("Digite a largura do retângulo:");
        retangulo1.Largura = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a altura do retângulo:");
        retangulo1.Altura = double.Parse(Console.ReadLine());

        // Chamada dos métodos para calcular a área, perímetro e diagonal
        retangulo1.Area();
        retangulo1.Perimetro();
        retangulo1.Diagonal();
    }

    class Retangulo
    {
        // Atributos de instância
        public double Largura;
        public double Altura;
        
        // Métodos de instância
        public double Area()
        {
            double areaDoRetangulo = Altura * Largura;
            Console.WriteLine($"Área: {areaDoRetangulo}");
            return areaDoRetangulo;
        }
        
        public double Perimetro()
        {
            double perimetroDoRetangulo = 2 * (Largura + Altura);
            Console.WriteLine($"Perímetro: {perimetroDoRetangulo}");
            return perimetroDoRetangulo;
        }
        
        public double Diagonal()
        {
            double diagonalDoRetangulo = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            Console.WriteLine($"Diagonal: {diagonalDoRetangulo}");
            return diagonalDoRetangulo;
        }
    }
}
