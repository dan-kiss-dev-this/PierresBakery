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
        public void BreadOrderPrice_CalculateCostForPiecesOfBread_int()
        {
            Bread breadOrder = new Bread(7);
            int expectedOrderCost = 25;
            // need method to calculate set price
            Assert.AreEqual(expectedOrderCost, breadOrder.FinalPrice);
        }
    }
}