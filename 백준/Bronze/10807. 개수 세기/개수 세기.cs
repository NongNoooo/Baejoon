using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());

    string[] numbers = Console.ReadLine().Split();

    int findNum = int.Parse(Console.ReadLine());

    int result = Array.FindAll(numbers, x => int.Parse(x) == findNum).Length;

    Console.WriteLine(result);
  }
}