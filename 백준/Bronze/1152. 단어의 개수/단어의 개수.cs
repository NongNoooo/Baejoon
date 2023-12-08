using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string str = Console.ReadLine().Trim();

    int counter = 0;
    
    for(int i = 0; i < str.Length; i++) if(str[i] == ' ') counter++;

    if(str.Length == 0) counter = 0;
    else counter++;
    
    Console.WriteLine(counter);
  }
}