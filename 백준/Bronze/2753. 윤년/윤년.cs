using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    int year;
    while(true){
      if(int.TryParse(Console.ReadLine(), out year)) break;
    }
   

    if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0) Console.WriteLine(1);
    else Console.WriteLine(0);
  }
}