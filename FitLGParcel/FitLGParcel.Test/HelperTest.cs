using System;
using FitLGParcel.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitLGParcel.Test
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void ShouldAbleToConvertValueToDouble()
        {
            // Arrange
            double expected = 1.23;

            // Act
            var result = Helper.ConvertValueToDouble("1.23");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldAbleToConvertValueToDouble_WithNegative()
        {
            // Arrange
            double expected = -1.23;

            // Act
            var result = Helper.ConvertValueToDouble("-1.23");

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldAbleToConvertValueToDouble_DecimalAsFirstChar()
        {
            // Arrange
            double expected = 0.235;

            // Act
            var result = Helper.ConvertValueToDouble(".235");

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
