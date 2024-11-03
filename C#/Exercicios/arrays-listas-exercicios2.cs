using System;
using System.Collections.Generic;

class HelloWorld {
  static void Main() {
      Console.WriteLine("INSIRA O TAMANHO DA MATRIZ");
      int N = int.Parse(Console.ReadLine());
    
      int[,] matriz = new int[N, N];
      int number;
      int countNegative = 0;
      
      // Lista para armazenar os números da diagonal principal
      List<int> diagonalNumbers = new List<int>();
      
      // Preenchendo a matriz com valores do usuário
      for (int i = 0; i < N; i++) {
          for (int j = 0; j < N; j++) {
              Console.WriteLine($"INSIRA O DADO PARA A POSIÇÃO [{i}, {j}]");
              number = int.Parse(Console.ReadLine());
              matriz[i, j] = number;
              
              // Conta números negativos
              if (number < 0) {
                  countNegative++;
              }
              
              // Armazena o número se ele estiver na diagonal principal
              if (i == j) {
                  diagonalNumbers.Add(matriz[i, j]);
              }
          }
      }
    
      // Exibindo os números da diagonal principal
      Console.WriteLine("\nDiagonal principal: ");
      foreach (int item in diagonalNumbers) {
          Console.Write(item + " ");
      }
      
      Console.WriteLine("\n\nMatriz:");
      // Exibindo a matriz em formato de tabela
      for (int i = 0; i < N; i++) {
          for (int j = 0; j < N; j++) {
              Console.Write(matriz[i, j] + "\t");
          }
          Console.WriteLine(); // Quebra de linha após cada linha da matriz
      }
      
      // Exibindo a quantidade de números negativos
      Console.WriteLine("\nNúmeros negativos: " + countNegative);
  }
}
