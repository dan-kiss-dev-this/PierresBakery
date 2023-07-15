using System;
using System.Collections.Generic;
using CSharpBakeryCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpBakeryCalculator.Tests
// naming convention public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
{
    [TestClass]
    public class PastryTests : IDisposable
    {
        public void Dispose()
        {
            Pastry.ClearAll();
        }

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

        [TestMethod]
        public void Discount_GetDiscount_Int()
        {
            Pastry pastryOrder = new Pastry(7);
            int expectedDiscount = 2;
            Assert.AreEqual(expectedDiscount, pastryOrder.Discount);
        }

        [TestMethod]
        public void GetAll_ReturnsInstances_List()
        {
            Pastry pastryOrder1 = new Pastry(1);
            Pastry pastryOrder2 = new Pastry(2);
            List<Pastry> expectedList = new List<Pastry> { pastryOrder1, pastryOrder2 };
            List<Pastry> instances = Pastry.GetAll();
            CollectionAssert.AreEqual(expectedList, instances);
        }

        [TestMethod]
        public void GetAll_MakesInstancesOnlyIfObjectOrdered_List()
        {
            // units is zero for breadOrder0 so instance of order is not stored
            Pastry pastryOrder0 = new Pastry(0);
            List<Pastry> expectedList = new List<Pastry> { };
            List<Pastry> instances = Pastry.GetAll();
            CollectionAssert.AreEqual(expectedList, instances);
        }


    }
}