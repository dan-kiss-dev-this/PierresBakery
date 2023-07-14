using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpBakeryCalculator.Models;
using System;
using System.Collections.Generic;

namespace CSharpBakeryCalculator.Tests
{
    [TestClass]

    public class BreadTests
    // naming convention public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
        [TestMethod]
        public void BreadConstrutor_CreateInstanceOfBread_Bread()
        {
            Bread newBread = new Bread(1);
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void LoafsOfBread_SetLoafsOfBread_Int()
        {
            Bread newBread = new Bread(1);
            int expectedValue = 1;
            Assert.AreEqual(expectedValue, newBread.LoafsOfBread);
        }

        [TestMethod]
        public void FinalPrice_CalculateCostForPiecesOfBread_int()
        {
            Bread breadOrder = new Bread(7);
            int expectedOrderCost = 25;
            Assert.AreEqual(expectedOrderCost, breadOrder.FinalPrice);
        }

        [TestMethod]
        public void CalculateOrderPrice_GetPriceForBreadOrdered_Int()
        {
            Bread breadOrder = new Bread(7);
            int expectedOrderCost = 25;
            Assert.AreEqual(expectedOrderCost, breadOrder.CalculateOrderPrice());
        }

        [TestMethod]
        public void Discount_GetDiscount_Int()
        {
            Bread breadOrder = new Bread(7);
            int expectedDiscount = 10;
            Assert.AreEqual(expectedDiscount, breadOrder.Discount);
        }

    }
}