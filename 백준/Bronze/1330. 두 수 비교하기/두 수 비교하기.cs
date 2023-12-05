using System;


class Program {
  public static void Main (string[] args) {
    String[] str = Console.ReadLine().Split();

    int num1 = int.Parse(str[0]);
    int num2 = int.Parse(str[1]);

    if (num1 < num2) Console.WriteLine("<");
    else if (num1 > num2) Console.Write(">");
    else if (num1 == num2) Console.WriteLine("==");
  }
}