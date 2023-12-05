using System;


class Program {
  public static void Main (string[] args) {
    int a;
    int b;
    
    while(true)
    {
      string[] str = Console.ReadLine().Split();
      
      a = int.Parse(str[0]);
      b = int.Parse(str[1]);

      if(a > 0 && b < 10) break;
    }

    Console.WriteLine(a*b);
  }
}