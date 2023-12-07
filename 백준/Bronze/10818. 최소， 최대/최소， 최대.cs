using System;

class Program {
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());

    string[] numStr = Console.ReadLine().Split();

    int[] numbers = new int[num];
    for(int i = 0; i < num; i++){
      numbers[i] = int.Parse(numStr[i]);
    }
    
    Array.Sort(numbers);

    Console.Write($"{numbers[0]} {numbers[num - 1]}");
  }
}