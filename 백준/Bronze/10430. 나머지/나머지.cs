using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int a,b,c;
    while(true){
      string[] num = Console.ReadLine().Split();

      a = int.Parse(num[0]);
      b = int.Parse(num[1]);
      c = int.Parse(num[2]);

      if(a >= 2 && a <= 10000 && b >= 2 && b <= 10000 && c >= 2 && c <= 10000) break;
    }

    Console.WriteLine((a+b)%c);
    Console.WriteLine(((a%c) + (b%c))%c);
    Console.WriteLine((a*b)%c);
    Console.WriteLine(((a%c) * (b%c))%c);
  }
}