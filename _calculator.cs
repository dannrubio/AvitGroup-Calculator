namespace AvitCalculator
{
  class Calculator
  {
    static void Main()
    {
      ValidationClass validate = new ValidationClass();

      Console.Write("Enter your statement: ");
      string val = Console.ReadLine() ?? "";
      string errorMessage1 = validate.CheckEqualExists(val!) ? "" : "Missing equal symbol.";
      string errorMessage2 = validate.CheckOperatorExists(val!) ? "" : "Missing operator symbol.";

      if (errorMessage1 == "")
      {
        if (errorMessage2 == "")
        {
          string operation = "";
          string[] values = validate.GetValues(val!.Replace("=", ""), out operation);
          double value = 0;
          switch (operation)
          {
            case "+":
              value = double.Parse(values[0]) + double.Parse(values[1]);
              break;
            case "-":
              value = double.Parse(values[0]) - double.Parse(values[1]);
              break;
            case "*":
              value = double.Parse(values[0]) * double.Parse(values[1]);
              break;
            case "/":
              value = double.Parse(values[0]) / double.Parse(values[1]);
              break;
            default:
              value = double.Parse(values[0]);
              break;
          }
          Console.Write(value);
        }
        else
        {
          Console.WriteLine(errorMessage2);
        }
      }
      else
      {
        Console.WriteLine(errorMessage1);
      }
    }
  }
}
