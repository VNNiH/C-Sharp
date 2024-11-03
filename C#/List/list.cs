using System;
using System.Collections.Generic;
class HelloWorld {
  static void Main() {
    //criando uma lista vazia e inserindo dados nela
    List<string> list = new List<string>();  
    //ADD valores
    list.Add("Alex");//0
    list.Add("Maria");//1
    list.Add("Anna");//3
    //Com insert podemos colocar o index onde o nosso elemento irá ficar
    list.Insert(2,"Vitor");//2
    foreach(string item in list){
        Console.WriteLine(item);
    }
    //contando o tamanho da nossa list usando a propriedade Count
    Console.WriteLine(list.Count);
    string s1 = list.Find(x=> x[0] == 'A');
    Console.WriteLine(s1);
    
    string s2 = list.FindLast(x=> x[0] == 'A');
    Console.WriteLine(s2);
    
    int i1 = list.FindIndex(x=> x[0] == 'A');
    Console.WriteLine(i1);
    
    int i2 = list.FindLastIndex(x=> x[0] == 'A');
    Console.WriteLine(i2);
    
    Console.WriteLine("---------------------");
    //FindAll necessita de uma lista para armazenar os items filtrados
    //list.FindAll -> passamos a lista original onde ira ser aplicado o filtro
    List<string> list2 = list.FindAll(x => x.Length == 5);
    
    foreach(string item in list2){
        Console.WriteLine(item);
    }
    
    Console.WriteLine("---------------------");
    list.Remove("Alex");
    foreach(string item in list){
        Console.WriteLine(item);
    }
    
    Console.WriteLine("---------------------");
    list.RemoveAll(x => x[0] == 'V');
    foreach(string item in list){
        Console.WriteLine(item);
    }
    
    Console.WriteLine("---------------------");
    list.RemoveAt(0);
    foreach(string item in list){
        Console.WriteLine(item);
    }
  }
}
class Product{
    public string Name;
    public int Idade;
    
    public Product(string name, int idade){
        Name = name;
        Idade = idade;
    }
}
