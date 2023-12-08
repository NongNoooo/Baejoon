using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] numbers = new int[9];
    int max = int.MinValue;
    int index = 0;
    
    for(int i = 0; i < numbers.Length; i++)
    {
      numbers[i] = int.Parse(Console.ReadLine());
    }

    for(int i = 0; i < numbers.Length; i++)
    {
      if(max < numbers[i])
      {
        max = numbers[i];
        index = i + 1;       
      }
    }

    Console.WriteLine(max);
    Console.WriteLine(index);
  }
}