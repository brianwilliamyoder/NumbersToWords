using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumbersToWords.Models;


namespace NumbersToWords.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void StringConstructor_CreateInstanceOfClass_Class()
    {
      NumberWord new1 = new NumberWord();
      Assert.AreEqual(typeof(NumberWord), new1.GetType());
    }

    [TestMethod]
    public void NumberDictionaries_OutputString_String()
    {
      NumberWord new1 = new NumberWord();
      string zero = "zero";
      string result = new1.singleDigit[0];
      Assert.AreEqual(zero, result);
    }

    [TestMethod]
    public void ReturnSingleDigitString_OutputString_String()
    {
      NumberWord new1 = new NumberWord();
      string one = "one";
      string result = new1.ReturnSingleDigitString(1);
      Assert.AreEqual(one, result);

    }
   [TestMethod]
    public void ReturnDoubleDigitString_OutputString_String()
    {
      NumberWord new1 = new NumberWord();
      string ten = "ten";
      string result = new1.ReturnDoubleDigitString(10);
      Assert.AreEqual(ten, result);

    }
    
   }
 }
