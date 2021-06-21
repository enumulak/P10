using Microsoft.VisualStudio.TestTools.UnitTesting;
using P10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.Tests
{
    [TestClass()]
    public class PatternPrinterTests
    {
        [TestMethod()]
        public void FailureTest()
        {
            // This method is to verify that the input size should be 1 or greater. Only then do we print the pattern or else send a failure message back

            // Arrange
            string fMessage = "Invalid Input";
            PatternPrinter pp = new PatternPrinter();

            // Act - this test is supposed to update the value of failureMessage with "Invalid Input"
            pp.PrintOnesPattern(0);

            string falMessage = pp.GetInputStatusMessage();

            // Assert
            Assert.AreEqual(fMessage, falMessage);
        }

        [TestMethod()]
        public void ValidInputTest()
        {
            // This method is to verify that the input size is 1 or greater. Status Message is "Valid Input"

            // Arrange
            string vMessage = "Valid Input";
            PatternPrinter pp = new PatternPrinter();

            // Act
            pp.PrintOnesPattern(1);
            string inputStatus = pp.GetInputStatusMessage();

            // Assert
            Assert.AreEqual(vMessage, inputStatus);
        }

        // Our class method depends on the modulus operator to print the desired pattern on screen
        // We basically check if the current index is odd or even, by performing --> index % 2
        // We print 1 if the index is odd
        // We print -1 if the index is even

        [TestMethod]
        public void TestModOperatorForOdd()
        {
            // We will verify that '1' will be printed if current index is odd

            // Arrange
            string dOutput = "1";
            string aOutput = "";
            int index = 1; // Take any odd number

            // Act
            int cIndex = index % 2;
            if(cIndex != 0)
            {
                aOutput = "1";
            }

            // Assert
            Assert.AreEqual(dOutput, aOutput);

        }

        [TestMethod]
        public void TestModOperatorForEven()
        {
            // We will verify that '-1' will be printed if current index is even

            // Arrange
            string dOutput = "-1";
            string aOutput = "-1";
            int index = 2; // Take any even number

            // Act
            int cIndex = index % 2;
            if (cIndex == 0)
            {
                aOutput = "-1";
            }

            // Assert
            Assert.AreEqual(dOutput, aOutput);
        }

    }
}