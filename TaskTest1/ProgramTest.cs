using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
[TestClass]
public class ArrayAnalyzerTests
{
    [TestMethod]
    public void AnalyzeArray_ShouldCountEvenNumbers()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        
        var result = Program.AnalyzeArray(array);
        
        Assert.AreEqual(3, result.couples);
    }

    [TestMethod]
    public void AnalyzeArray_ShouldCountOddNumbers()
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        
        var result = Program.AnalyzeArray(array);
        
        Assert.AreEqual(3, result.odd);
    }

    [TestMethod]
    public void AnalyzeArray_ShouldCountUniqueValues()
    {
        int[] array = { 1, 2, 2, 3, 3, 3 };
        
        var result = Program.AnalyzeArray(array);
        
        Assert.AreEqual(3, result.unique);
    }

    [TestMethod]
    public void AnalyzeArray_WithEmptyArray_ShouldReturnZeros()
    {
        int[] array = Array.Empty<int>();
        
        var result = Program.AnalyzeArray(array);
        
        Assert.AreEqual(0, result.couples);
        Assert.AreEqual(0, result.odd);
        Assert.AreEqual(0, result.unique);
    }

    [TestMethod]
    public void AnalyzeArray_WithAllSameElements()
    {
        int[] array = { 5, 5, 5, 5 };
        
        var result = Program.AnalyzeArray(array);
        
        Assert.AreEqual(4, result.couples);
        Assert.AreEqual(0, result.odd);
        Assert.AreEqual(4, result.unique); 
    }
}