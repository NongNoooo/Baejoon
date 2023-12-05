using System;


class Program {
  public static void Main (string[] args) {
    string[] nowTime = Console.ReadLine().Split();
    string cookTime = Console.ReadLine();
    
    int h = int.Parse(nowTime[0]);
    int m = int.Parse(nowTime[1]) + int.Parse(cookTime);

    h = (h + m / 60) % 24;
    m %= 60;
    
    Console.WriteLine("{0} {1}",h, m);
  }
}