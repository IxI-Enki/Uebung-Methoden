
using System.Drawing;
using System.Reflection.PortableExecutable;

namespace Uebung.Methoden
{
  class Program
  {
    static string header = "Title";

    static void Main()
    {
      PrintHeader(1);

      CallSimpleCalc();
    }

    static void CallSimpleCalc()
    {
      int number = PromptUserInput();
      // int zahl = 2;

      PromptUserInput(out double number2);
      // double zahl2 = 2.2;
      double number3 = 0.0;

      SwapNumber(ref number3, ref number2);
      //  double result = number3 - number2;
      //  Console.Write(result);
    }

    private static void SwapNumber(ref double number3, ref double number2)
    {
      double swap = number2;
      number2 = number3;
      number3 = swap;
    }

    static void PromptUserInput(out double numberParam)
    {
      Console.Write("\n Geben Sie eine Kommazahl ein: ");
      bool isValid = false;
      // int input2 = Convert.ToInt32(Console.ReadLine());  
      // keine Möglichkeit zur Kontrolle der Eingabe
      do
      {
        string input = Console.ReadLine();
        isValid = double.TryParse(input, out numberParam);
        if (!isValid)
          Console.Write("\n Bitte Ganzzahl eingeben!");
      } while (isValid == false);

    }

    static int PromptUserInput() // = return number;
    {
      Console.Write("\n Geben Sie eine Ganzzahl ein: ");
      bool isValid = false;
      int numberParam;
      do
      {
        string input = Console.ReadLine();
        isValid = int.TryParse(input, out numberParam);
        if (!isValid)
          Console.Write("\n Bitte Ganzzahl eingeben!");
      } while (isValid == false);
      return numberParam;
    }

    // ----------------------------------------------------------
    static void PrintHeader(byte centre = 0)
    {
      if (centre == 1)
        Console.Write("\n" + ConcatSpacing() + header);
      else
        Console.Write("\n" + header);
    }
    //                  title                  //
    static string ConcatSpacing()
    {
      int consoleWidth = Console.WindowWidth;
      string spacing = "";

      for (int w = 0; w < (consoleWidth - header.Length) / 2; w++)
      {
        spacing += " ";
      }
      return spacing;
    }
    /*
    private static void MethodeDieRgbErwartet(byte r, byte g, byte b)
    {
      Console.Write("\n"
        + "\u001b[48;2;" + r + ";" + g + ";" + b + "m" + "TESTTEXT"

        + "\u001b[0m"

      + "Normaler Text");

      Console.ReadLine();

      //   Console.ForegroundColor = ConsoleColor.Magenta;
    }

    //      \u001B[38;2;255;255;255m Text 

    //        \330[38;2;255;255;255m TEXT
    //        \x11[ 
    */
  }
}
