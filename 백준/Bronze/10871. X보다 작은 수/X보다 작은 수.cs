using System;
using System.Text;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] nums1 = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

    int[] nums2 = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

    int numbersCount = nums2.Length;
    int targetNumber = nums1[1];
    StringBuilder strBuilder = new StringBuilder();
    
    for(int i = 0; i < numbersCount; i++)
    {
      if(nums2[i] < targetNumber) strBuilder.Append(nums2[i] + " ");
    }

    Console.WriteLine(strBuilder.ToString());
  }
}