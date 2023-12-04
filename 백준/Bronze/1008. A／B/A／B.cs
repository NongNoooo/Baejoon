using System;


class Program {
  public static void Main (string[] args) {
    String str = Console.ReadLine();

    int a = int.Parse(str.Substring(0,1));
    int b = int.Parse(str.Substring(2,1));

    Console.WriteLine((double)a/b);
  }
}