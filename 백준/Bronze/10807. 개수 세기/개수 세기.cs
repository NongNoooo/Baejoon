using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    int num = int.Parse(Console.ReadLine());

    string[] numbers = Console.ReadLine().Split();

    int findNum = int.Parse(Console.ReadLine());
    
    int count = 0;
    
    for(int i = 0; i < numbers.Length; i++){
      int tempNum = int.Parse(numbers[i]);

      if(tempNum == findNum){
        count++;
      }
    }

    Console.WriteLine(count);
  }
}