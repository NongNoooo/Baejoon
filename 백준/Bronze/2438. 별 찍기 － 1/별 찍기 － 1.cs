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
      for(int j = 0; j < i + 1; j++)
      {
        strBuilder.Append("*");
      }
      strBuilder.Append("\n");
    }

    Console.WriteLine(strBuilder.ToString());
  }
}