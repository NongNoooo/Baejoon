using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    string[] num = Console.ReadLine().Split();
    int a = int.Parse(num[0]);
    int b = int.Parse(num[1]);
    int c = int.Parse(num[2]);

    if(a == b & b == c) {
        Console.WriteLine($"{10000+a*1000}");
        return;
    }
    if (a == b) {
        Console.WriteLine($"{1000 + a * 100}");
        return;
    }
    else if(b == c) {
        Console.WriteLine($"{1000 + b * 100}");
        return;
    }
    else if(c == a) {
        Console.WriteLine($"{1000 + c * 100}");
        return;
    }
    if (!(a == b) && !(b == c)) {
        Array.Sort(num);
        Array.Reverse(num);
        Console.WriteLine($"{int.Parse(num[0]) * 100}");
        return;
    }
  }
}