using System;

class HelloWorld {
  static void Main() {
    try{
        int n1  = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        if(n1 < 0 || n2 < 0)
        {
            throw new NumeroNegativoException("Numeros negativos não são permitidos",1001);
        }
        
        
        int result = n1 / n2;
        Console.WriteLine(result);
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine("Erro : " + ex.Message);
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Erro : " + ex.Message);
    }
    catch(NumeroNegativoException ex)
    {
        Console.WriteLine($"Erro capturado: {ex.Message} (Código: {ex.CodigoErro})");
        Console.WriteLine(ex.StackTrace);
    }
    catch(Exception ex)
    {
        Console.WriteLine("Erro : " + ex.Message);
        Console.WriteLine(ex.StackTrace);
    }
    
  }
}
class NumeroNegativoException : Exception{
    public int CodigoErro {get; set;}
    public NumeroNegativoException (string msg, int codigo) : base(msg)
    {
        CodigoErro = codigo;
    }
}
