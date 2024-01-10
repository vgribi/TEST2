using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TestCalculator()
    {
        string input = "+\n5\n*\n10\n-\n3\nq\n";
        string expectedOutput = "[#1]: 0\r\n" +
                                "[#2]: 5\r\n" +
                                "[#3]: 50\r\n" +
                                "[#4]: 47\r\n" +
                                "Программа завершена.\r\n";
        var consoleInput = new StringReader(input);
        var consoleOutput = new StringWriter();
        Console.SetIn(consoleInput);
        Console.SetOut(consoleOutput);

        Calculator.Main();

        Assert.AreEqual(expectedOutput, consoleOutput.ToString());
    }
}
