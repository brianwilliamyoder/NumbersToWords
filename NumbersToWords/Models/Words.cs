using System;

namespace NumbersToWords.Models
{
  public class NumberWord
  {
    public string Zero;
    public string One;
    public string Two;
    // public string 3;
    // public string 4;
    // public string 5;
    // public string 6;
    // public string 7;
    // public string 8;
    // public string 9;

    public NumberWord(int number)
    {
      
    }
  }
}

Dictionary<int, string> indexZero = new Dictionary<int, string>(){{0, "zero"}, {1,"one"}, {2,"two"}};