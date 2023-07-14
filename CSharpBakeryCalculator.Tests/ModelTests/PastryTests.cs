using System;
using System.Collections.Generic;
using CSharpBakeryCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpBakeryCalculator.Tests
// naming convention public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_GetAnInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry(1);
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void UnitsOfPastry_SetUnitsOfPastry_Int()
        {
            Pastry newPastry = new Pastry(1);
            int expectedValue = 1;
            Assert.AreEqual(expectedValue, newPastry.UnitsOfPastry);
        }

        [TestMethod]
        public void FinalPrice_GetPrice_Int()
        {
            Pastry pastryOrder = new Pastry(9);
            int expectedOrderCost = 14;
            Assert.AreEqual(expectedOrderCost, pastryOrder.FinalPrice);
        }

        [TestMethod]
        public void CalculateOrderPrice_GetPriceForPastrysOrdered_Int()
        {
            Pastry pastryOrder = new Pastry(9);
            int expectedOrderCost = 14;
            Assert.AreEqual(expectedOrderCost, pastryOrder.CalculateOrderPrice());
        }

    }
}