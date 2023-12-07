using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());

    string[] numStr = Console.ReadLine().Split();

    int[] numbers = numStr.Select(n => int.Parse(n)).ToArray();
    
    Array.Sort(numbers);

    Console.Write($"{numbers[0]} {numbers[numbers.Length - 1]}");
  }
}