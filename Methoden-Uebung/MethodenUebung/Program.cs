namespace Uebung.Methoden
{
  class Program
  {
    static string header = "Methoden Uebung";     // Statische Konstante für den Programmheader.

    /// <summary>
    /// Einstiegspunkt des Programms. Druckt den Header und ruft die SimpleCalc-Funktion auf.
    /// </summary>
    static void Main()
    {
      PrintHeader(1);

      CallSimpleCalc();
    }

    /// <summary>
    /// Ruft die SimpleCalc-Funktion auf, die verschiedene mathematische Operationen ausführt.
    /// </summary>
    static void CallSimpleCalc()
    {
      int number = PromptUserInput();
      // int num = (zum Beispiel : 2);

      PromptUserInput(out double number2);
      // mit "out" kann ebenfalls ein in der Methode zugewiesener Wert aus der Methode heraus gegeben werden

      double number3 = 0.0;
      SwapNumber(ref number3, ref number2);
      // mit "ref" können Werte außerhalb der Methode bearbeitet werden

      double result = number3 - number2;
      Console.Write(result);
    }

    /// <summary>
    /// Tauscht den Wert zweier Variablen, die als Referenzen übergeben werden.
    /// </summary>
    /// <param name="numberOneParam">Referenz auf die erste Variable (wird getauscht).</param>
    /// <param name="numberTwoParam">Referenz auf die zweite Variable (wird getauscht).</param>
    private static void SwapNumber(ref double numberOneParam, ref double numberTwoParam)
    {
      double swap = numberTwoParam;
      numberTwoParam = numberOneParam;
      numberOneParam = swap;
    }
    
    /// <summary>
    /// Fordert den Benutzer auf, eine Kommazahl einzugeben und speichert diese in der angegebenen Variable.
    /// </summary>
    /// <param name="numberParam">Variable, in der die eingegebene Kommazahl gespeichert wird.</param>
    static void PromptUserInput(out double numberParam)
    {
      Console.Write("\n Geben Sie eine Kommazahl ein: ");
      bool isValid = false;
      do
      {
        string input = Console.ReadLine();
        isValid = double.TryParse(input, out numberParam);
        if (!isValid)
          Console.Write("\n Bitte Kommazahl eingeben!\n");
      } while (isValid == false);
      // Kurzschreibweise von "(isValid == false)" : "(!isValid)"
    }
  
    /// <summary>
    /// Fordert den Benutzer auf, eine Ganzzahl einzugeben und gibt diese zurück.
    /// </summary>
    /// <returns>Vom Benutzer eingegebene Ganzzahl.</returns>
    static int PromptUserInput() // = return int number;
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
    //                          Title                          //
    /// <summary>
    /// Druckt den Programmheader zentriert oder linksbündig, abhängig vom Parameter 'centre'.
    /// </summary>
    /// <param name="centre">Option zum Zentrieren des Headers (1) oder Linksbündigkeit (0, Standard).</param>
    static void PrintHeader(byte centre = 0)
    {
      if (centre == 1)
        Console.Write("\n" + ConcatSpacing() + header);
      else
        Console.Write("\n" + header);
    }

    /// <summary>
    /// Erzeugt eine Zeichenfolge mit Leerzeichen, um den Programmheader zu zentrieren.
    /// </summary>
    /// <returns>Zeichenfolge mit Leerzeichen für die Zentrierung des Headers.</returns>
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
  }
}