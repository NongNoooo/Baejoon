using System;


class Program {
  public static void Main (string[] args) {
    int year;
    
    while(true)
    {
      bool bTry = int.TryParse(Console.ReadLine(), out year);

      if(bTry && year >= 1000 && year <= 3000) break;
    }

    Console.WriteLine(year - 543);
  }
}