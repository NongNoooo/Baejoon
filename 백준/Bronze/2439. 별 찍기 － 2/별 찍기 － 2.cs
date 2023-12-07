using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int starNum = int.Parse(Console.ReadLine());

    for(int i = 0; i < starNum; i++)
    {
      for(int j = starNum -1; j > -1 ; j--)
      {
        if(j > i) Console.Write(" ");
        else Console.Write("*");
      }

      Console.WriteLine();
    }
  }
}