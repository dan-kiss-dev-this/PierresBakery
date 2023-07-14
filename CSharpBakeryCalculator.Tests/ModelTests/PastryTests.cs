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

    }
}