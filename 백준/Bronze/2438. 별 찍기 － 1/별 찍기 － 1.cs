using System;
using System.Text;

class Program 
{
  public static void Main (string[] args) 
  {
    int starNum = int.Parse(Console.ReadLine());
    StringBuilder strBuilder = new StringBuilder();

    for(int i = 0; i < starNum; i++)
    {
      for(int j = 0; j < starNum; j++)
      {
        if(j <= i) strBuilder.Append("*");
      }
      strBuilder.Append("\n");
    }

    Console.WriteLine(strBuilder.ToString());
  }
}