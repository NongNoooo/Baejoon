using System;

class Program {
  public static void Main (string[] args) {
    int min = 1000001;
    int max = -1000001;
    int temp;
    
    int num = int.Parse(Console.ReadLine());

    string[] numStr = Console.ReadLine().Split();

    
    for(int i = 0; i < num; i++){
      temp = int.Parse(numStr[i]);
      if(temp < min) min = temp;
      if(temp > max) max = temp;
    }
    
    Console.Write($"{min} {max}");
  }
}