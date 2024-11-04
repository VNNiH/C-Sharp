using System;
class HelloWorld {
  static void Main() {
    var x = 101;
    var person = new Person();
    person.Name = "Vinicius";
    Console.WriteLine(x);
    Console.WriteLine(person.Name);
  }
}
class Person{
    public string Name;

}
