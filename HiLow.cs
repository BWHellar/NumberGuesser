using System;
using System.Collections.Generic;

  public class NumberWizard
  {
    static int max = 1000;
    static int min = 1;
    static int guess = 500;
    public static void Main()
    {

      Console.WriteLine("Welcome to Wizard");
      Console.WriteLine("Pick a number");
      Console.WriteLine("The highest number you can pick is: " + max);
      Console.WriteLine("The lowest number you can pick is: " + min);
      Console.WriteLine("Tell me if your number is higher or lower than 500");
      Console.WriteLine("Type 'h' for 'Higher', Type 'L' for Lower, type 'C' for 'Correct'");

      Loop();
  }
       public static void Loop(){
         string key = Console.ReadLine();
          if (key == "h" || key == "H")
          {
              Console.WriteLine("Higher!");
              min = guess;
              guess = (max + min) / 2;
              Console.WriteLine(guess);

          }
          else if (key == "l" || key == "L")
          {
              Console.WriteLine("Lower!");
              max = guess;
              guess = (max + min) / 2;
              Console.WriteLine(guess);
          }
          else if (key == "c" || key == "C")
          {
              Console.WriteLine("I guessed your number!");
          }
          Loop();
        }
}
