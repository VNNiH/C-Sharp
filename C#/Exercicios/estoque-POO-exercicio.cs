using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            produto1.Name = Console.ReadLine();
            produto1.Price = double.Parse(Console.ReadLine());
            produto1.Quantity = int.Parse(Console.ReadLine());
            
            produto1.dadosDoProduto();
            produto1.ValorTotalEmEstoque();
            
            int addP = int.Parse(Console.ReadLine());
            produto1.AddProducts(addP);
            produto1.dadosDoProduto();
            produto1.ValorTotalEmEstoque();
            
            int removeP = int.Parse(Console.ReadLine());
            produto1.RemoveProducts(removeP);
            produto1.dadosDoProduto();
            produto1.ValorTotalEmEstoque();
        }
    }

    class Produto
    {
       public string Name;
       public double Price;
       public int Quantity;
       
       public double totalValue;
       
       public double ValorTotalEmEstoque(){
           totalValue = Quantity * Price;
           Console.WriteLine("Valor Total em Estoque : " + totalValue);
           return totalValue;
       }

       public void AddProducts(int addQuantity){
          Quantity += addQuantity;
       }
       
       public void RemoveProducts(int removeQuantity){
          Quantity -= removeQuantity; 
       }
        public void dadosDoProduto(){
           Console.WriteLine("Dados do Produto : " + Name + " ," + Price.ToString("F2") + " ," + Quantity );
       }
    }
}
