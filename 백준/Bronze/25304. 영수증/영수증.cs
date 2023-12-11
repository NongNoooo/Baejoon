using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int totalPrice = int.Parse(Console.ReadLine());

    int totalGoods = int.Parse(Console.ReadLine());

    int calculatingPrice = 0;
    for(int i = 0; i < totalGoods; i++)
    {
      string[] tmpStr = Console.ReadLine().Split();

      calculatingPrice += int.Parse(tmpStr[0]) * int.Parse(tmpStr[1]);
    }

    if(totalPrice == calculatingPrice) Console.WriteLine("Yes");
    else Console.WriteLine("No");
  }
}