public class ValidationClass
{
  public bool CheckEqualExists(string phrase)
  {
    return phrase!.IndexOf("=") > -1 ? true : false;
  }

  public bool CheckOperatorExists(string phrase)
  {
    bool addOper = phrase!.IndexOf("+") > 0 ? true : false;
    bool subOper = phrase!.IndexOf("-") > 0 ? true : false;
    bool multOper = phrase!.IndexOf("*") > 0 ? true : false;
    bool divOper = phrase!.IndexOf("/") > 0 ? true : false;
    return addOper || subOper || multOper || divOper;
  }

  public string[] GetValues(string phrase, out string operSymbol)
  {
    string newPhrase = phrase!.Replace("=", "");
    if (newPhrase!.IndexOf("+") > -1)
    {
      operSymbol = "+";
      return newPhrase!.Split("+");
    }
    if (newPhrase!.IndexOf("-") > -1)
    {
      operSymbol = "-";
      return newPhrase!.Split("-");
    }
    if (newPhrase!.IndexOf("*") > -1)
    {
      operSymbol = "*";
      return newPhrase!.Split("*");
    }
    if (newPhrase!.IndexOf("/") > -1)
    {
      operSymbol = "/";
      return newPhrase!.Split("/");
    }
    operSymbol = "";
    return newPhrase!.Split(" ");
  }
}