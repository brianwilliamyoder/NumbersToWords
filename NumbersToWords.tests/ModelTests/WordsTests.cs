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
  }
}