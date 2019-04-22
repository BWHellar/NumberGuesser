using System;


  public class NumberWizard
  {
    public static void Main()
    {

      int max = 1000;
      int min = 1;
      int guess = 500;
      // Start is called before the first frame update

      Console.WriteLine("Welcome to Wizard");
      Console.WriteLine("Pick a number");
      Console.WriteLine("The highest number you can pick is: " + max);
      Console.WriteLine("The lowest number you can pick is: " + min);
      Console.WriteLine("Tell me if your number is higher or lower than 500");
      Console.WriteLine("Type 'h' for 'Higher', Type 'L' for Lower, type 'C' for 'Correct'");
      max = max + 1;
    // }
      // Update is called once per frame
    // public static void Keys()
    // {
        string key = Console.ReadKey().ToString();

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
            Console.WriteLine("I guess your number!");
        }
    // }
  }
}
