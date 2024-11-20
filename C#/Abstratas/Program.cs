using Course.Entities.Abstratas;
using Course.Entities.Exercicio5;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args) 
        {
            //isso cria uma lista generica do tipo Animal, ou seja, o tipo Animal é usado apenas como base isso nao é instanciacao
            List<Animal> animals = new List<Animal>();
            Cachorro cachorro = new Cachorro("Golden");
            cachorro.EmitirSom();
            //isso gera erro porque uma classe abstract não pode ser instanciado em um objeto
            //Animal animal = new Animal();
            // porem quando o tipo do objeto é de uma subclasse funciona normalmente
            Animal animal = new Cachorro("Pitbull");
            //a referencia é a superclass Animal mas a instancia é na subclass Cachorro
        }
    }
}
