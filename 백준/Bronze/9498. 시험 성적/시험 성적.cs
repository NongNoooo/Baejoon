using System;


class Program {
  public static void Main (string[] args) {
     int score = int.Parse(Console.ReadLine());
     if (score > 100 || score < 0) return;


    if (score > 89) Console.WriteLine("A");
    else if (score > 79) Console.WriteLine("B");
    else if (score > 69) Console.WriteLine("C");
    else if (score > 59) Console.WriteLine("D");
    else Console.WriteLine("F");
  }
}