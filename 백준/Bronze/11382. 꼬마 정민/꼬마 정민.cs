using System;


class Program {
  public static void Main (string[] args) {
    string[] str = Console.ReadLine().Split();

    Console.WriteLine(long.Parse(str[0]) + long.Parse(str[1]) + long.Parse(str[2]));
  }
}