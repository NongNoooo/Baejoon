using System;


class Program 
{
  public static void Main (string[] args) 
  {
    int starNum = int.Parse(Console.ReadLine());

    for(int i = 0; i < starNum; i++)
    {
      for(int j = 0; j < starNum; j++)
      {
        if(j <= i) Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}