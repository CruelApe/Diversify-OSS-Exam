using System;
using FitLGParcel.Library;
using FitLGParcel.Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitLGParcel.Test
{
    [TestClass]
    public class CalculationEngineTest
    {
        [TestMethod]
        public void ShouldCalculateVolumeAsExpected()
        {
            // Arrange
            double expected = 8.00;
            double height = 2.00;
            double width = 2.00;
            double depth = 2.00;

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(new ParcelModel {
                Weight = 10,
                Height = height,
                Width = width,
                Depth = depth
            });

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

        [TestMethod]
        public void ShouldAbleToDetermine_RejectedCategory()
        {
            // Arrange
            var expected = PriorityType.Rejected;
            ParcelModel parcel = new ParcelModel {
                Weight = 110,
                Height = 20,
                Width = 55,
                Depth = 120
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Priority);
        }

        [TestMethod]
        public void ShouldAbleToDetermine_HeavyCategory()
        {
            // Arrange
            var expected = PriorityType.Heavy;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 22,
                Height = 5,
                Width = 5,
                Depth = 5
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Priority);
        }

        [TestMethod]
        public void ShouldAbleToDetermine_LargeCategory()
        {
            // Arrange
            var expected = PriorityType.Large;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 5,
                Height = 125,
                Width = 278,
                Depth = 3
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Priority);
        }

        [TestMethod]
        public void ShouldAbleToDetermine_MediumCategory()
        {
            // Arrange
            var expected = PriorityType.Medium;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 10,
                Height = 20,
                Width = 5,
                Depth = 20
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Priority);
        }

        [TestMethod]
        public void ShouldAbleToDetermine_SmallCategory()
        {
            // Arrange
            var expected = PriorityType.Small;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 9,
                Height = 1,
                Width = 1,
                Depth = 1
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Priority);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_RejectedCost()
        {
            // Arrange
            var expected = 0.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 110,
                Height = 20,
                Width = 55,
                Depth = 120
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Cost);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_HeavyCost()
        {
            // Arrange
            var expected = 330.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 22,
                Height = 5,
                Width = 5,
                Depth = 5
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Cost);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_LargeCost()
        {
            // Arrange
            var expected = 3127.50;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 5,
                Height = 125,
                Width = 278,
                Depth = 3
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Cost);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_MediumCost()
        {
            // Arrange
            var expected = 80.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 10,
                Height = 20,
                Width = 5,
                Depth = 20
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Cost);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_SmallCost()
        {
            // Arrange
            var expected = 0.05;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 9,
                Height = 1,
                Width = 1,
                Depth = 1
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Cost);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_RejectedVolume()
        {
            // Arrange
            var expected = 132000.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 110,
                Height = 20,
                Width = 55,
                Depth = 120
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_HeavyVolume()
        {
            // Arrange
            var expected = 125.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 22,
                Height = 5,
                Width = 5,
                Depth = 5
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_LargeVolume()
        {
            // Arrange
            var expected = 104250.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 5,
                Height = 125,
                Width = 278,
                Depth = 3
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_MediumVolume()
        {
            // Arrange
            var expected = 2000.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 10,
                Height = 20,
                Width = 5,
                Depth = 20
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

        [TestMethod]
        public void ShouldAbleToCalculate_SmallVolume()
        {
            // Arrange
            var expected = 1.00;
            ParcelModel parcel = new ParcelModel
            {
                Weight = 9,
                Height = 1,
                Width = 1,
                Depth = 1
            };

            // Act
            var result = CalculationEngine.CalculateCostOfDelivery(parcel);

            // Assert
            Assert.AreEqual(expected, result.Volume);
        }

    }
}
