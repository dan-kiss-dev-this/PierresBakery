using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpBakeryCalculator.Models;
using System;
using System.Collections.Generic;

namespace CSharpBakeryCalculator.Tests
{
    [TestClass]

    public class BreadTests : IDisposable
    // naming convention public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
        public void Dispose()
        {
            Bread.ClearAll();
        }

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

        [TestMethod]
        public void GetAll_ReturnsInstances_List()
        {
            Bread breadOrder1 = new Bread(1);
            Bread breadOrder2 = new Bread(2);
            List<Bread> expectedList = new List<Bread> { breadOrder1, breadOrder2 };
            List<Bread> instances = Bread.GetAll();
            CollectionAssert.AreEqual(expectedList, instances);
        }

        [TestMethod]
        public void GetAll_MakesInstancesOnlyIfObjectOrdered_List()
        {
            // units is zero for breadOrder0 so instance of order is not stored
            Bread breadOrder0 = new Bread(0);
            List<Bread> expectedList = new List<Bread> { };
            List<Bread> instances = Bread.GetAll();
            CollectionAssert.AreEqual(expectedList, instances);
        }

    }
}