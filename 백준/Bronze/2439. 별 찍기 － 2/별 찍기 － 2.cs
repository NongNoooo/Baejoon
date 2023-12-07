using System;
using System.Text;

class Program 
{
  public static void Main (string[] args) 
  {
    int starNum = int.Parse(Console.ReadLine());

    StringBuilder str = new StringBuilder();
    
    for(int i = 0; i < starNum; i++)
    {
      for(int j = starNum -1; j > -1 ; j--)
      {
        if(j > i) str.Append(" ");
        else str.Append("*");
      }

      str.Append("\n");
    }

    Console.WriteLine(str.ToString());
  }
}