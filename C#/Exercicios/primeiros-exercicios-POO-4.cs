using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Nome = Console.ReadLine();
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario : " + funcionario.Nome + " , " + funcionario.SalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine());

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Funcionario : " + funcionario.Nome + " , " + funcionario.SalarioPosDesconto);
        }

        class Funcionario
        {
            public string Nome;
            public double SalarioBruto;
            public double Imposto;
            public double SalarioPosDesconto;
            public double SalarioLiquido()
            {
                SalarioPosDesconto = SalarioBruto - Imposto;
                return SalarioPosDesconto;
            }

            public void AumentarSalario(double porcentagem)
            {
                double tax = SalarioBruto * (porcentagem / 100);
                SalarioPosDesconto = SalarioPosDesconto + tax;
            }

            public override string ToString()
            {
                return Nome + ", "+ SalarioPosDesconto;
            }

        }
    }
}
