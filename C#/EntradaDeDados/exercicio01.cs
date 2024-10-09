using System;

namespace Course
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //exercicio 1
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int result = x + y;
            Console.WriteLine(result);

            //exercicio 2
            double r = double.Parse(Console.ReadLine());
            double area = 3.14159 * (r * r);
            Console.WriteLine(area.ToString("F4"));
            
            //exercicio 3
            int A,B,C,D;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            double DIFERENCA = (A * B - C * D);
            Console.WriteLine(DIFERENCA);

            //exercicio 4
            int numberOfEmployee = int.Parse(Console.ReadLine());
            int hoursOfWorked = int.Parse(Console.ReadLine());
            double valueOfOneHour = double.Parse(Console.ReadLine());

            double salary = hoursOfWorked * valueOfOneHour;

            Console.WriteLine("NUNBER = " + numberOfEmployee);
            Console.WriteLine("SALARY = " + salary);

            //exercicio 5
            string s1 = Console.ReadLine();
            string[] answer1 = s1.Split(" ");
            int n1 = int.Parse(answer1[0]);
            int numberPieces1 = int.Parse(answer1[1]);
            double valueUnitary1 = double.Parse(answer1[2]);
            double total1 = numberPieces1 * valueUnitary1;

            string s2 = Console.ReadLine();
            string[] answer2 = s2.Split(" ");
            int n2 = int.Parse(answer2[0]);
            int numberPieces2 = int.Parse(answer2[1]);
            double valueUnitary2 = double.Parse(answer2[2]);
            double total2 = numberPieces2 * valueUnitary2;

            Console.WriteLine("TOTAL = " + (total1 + total2));


        }
    }
}
