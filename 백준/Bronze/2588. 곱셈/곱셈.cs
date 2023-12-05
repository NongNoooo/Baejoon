using System;


class Program {
  public static void Main (string[] args) {
    int upperSide = int.Parse(Console.ReadLine());
    string lowerSide = Console.ReadLine();
  
    
    int lowSideNum1 = int.Parse(lowerSide.Substring(2,1));
    int lowSideNum2 = int.Parse(lowerSide.Substring(1,1));
    int lowSideNum3 = int.Parse(lowerSide.Substring(0,1));
    
    Console.WriteLine(upperSide * lowSideNum1);
    Console.WriteLine(upperSide * lowSideNum2);
    Console.WriteLine(upperSide * lowSideNum3);
    Console.WriteLine(upperSide * int.Parse(lowerSide));
  }
}