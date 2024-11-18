using System;
using Course.Entities;
using Course.Entities.Heranca;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
           BussinesAccount acc = new BussinesAccount(8010,"Bob brown",100.0,500.0);
           Console.WriteLine(acc.Balance);
        }
    }
}
