using System;
using System.Text;

class Program 
{
  public static void Main (string[] args) 
  {
    string[] str = Console.ReadLine().Split();

    int[] nums = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

    int targetNumber = int.Parse(str[1]);
    StringBuilder strBuilder = new StringBuilder();
    
    for(int i = 0; i < nums.Length; i++)
    {
      if(nums[i] < targetNumber) strBuilder.Append(nums[i] + " ");
    }

    Console.WriteLine(strBuilder.ToString());
  }
}