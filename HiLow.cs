using System;
using System.Collections.Generic;

  public class NumberWizard
  {
    public static void Main()
    {

      int max = 1000;
      int min = 1;
      // int guess = 500;
      // Start is called before the first frame update

      Console.WriteLine("Welcome to Wizard");
      Console.WriteLine("Pick a number");
      Console.WriteLine("The highest number you can pick is: " + max);
      Console.WriteLine("The lowest number you can pick is: " + min);
      Console.WriteLine("Tell me if your number is higher or lower than 500");
      Console.WriteLine("Type 'h' for 'Higher', Type 'L' for Lower, type 'C' for 'Correct'");

      Loop();
  }
       public static void Loop(){
         List<int> guessNumber = new List<int> {};
         int guess = 500;

         string key = Console.ReadLine();
          if (key == "h" || key == "H")
          {
              Console.WriteLine("Higher!");
              guessNumber.Add(guess);
              Console.WriteLine(guessNumber[0]);
              guessNumber[0] = (guessNumber[0])/2;
              Console.WriteLine(guessNumber[0]);

              // Loop();
          }
          else if (key == "l" || key == "L")
          {
              Console.WriteLine("Lower!");

              guess = guess / 2;
              Console.WriteLine(guess);
              // Loop();
          }
          else if (key == "c" || key == "C")
          {
              Console.WriteLine("I guess your number!");
          }
        }
}
