using System;


class Program {
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());

    for(int i = 1; i < 10; i++){
      Console.WriteLine($"{num} * {i} = {num * i}");
    }
  }
}