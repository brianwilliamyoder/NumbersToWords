using System;
using System.Collections.Generic;

namespace NumbersToWords.Models
{
  public class NumberWord
  {

    public Dictionary<int, string> singleDigit = new Dictionary<int, string>
    {
      {0, "zero"},
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"}
    };

    public Dictionary<int, string> teenDigitsEtc = new Dictionary<int, string>()
    {
      {11, "eleven"},
      {12, "twelve"} ,
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };

    public Dictionary<int, string> tYDigits = new Dictionary<int, string>()
    {
      {10, "ten"},
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"}
      };

    public string ReturnSingleDigitString(int userNumber)
    {
      string output = this.singleDigit[userNumber];
      return output;
    }

    public string ReturnDoubleDigitString(int userNumber)
    {

      string stringNumber = userNumber.ToString();
      char[] charNumber = stringNumber.ToCharArray();
      if (stringNumber.Contains("0"))
      {
        return this.tYDigits[userNumber];

      }
      else if (stringNumber.Substring(0, 1) != "1")
      {
        return (this.tYDigits[userNumber]);
      }
      else
      {
        return this.teenDigitsEtc[userNumber];
      }

    }




  }
}


