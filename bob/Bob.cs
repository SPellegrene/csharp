
using System;

public class Bob()
{
  string yell = input.toUpper(); //Any input with ALL CAPS
  string question = input.Contains(?); //Any input with a ?

  public static string Main(string input)
  {
    if (input  === question)
    {
      return ("Sure");
    }
    else if (input === yell)
    {
      return ("Whoa, Chill Out");
    }
    else if (input === null)
    {
      return ("Fine, be that way");
    }
    else
    {
      return ("Whatever");
    }
  }
}
