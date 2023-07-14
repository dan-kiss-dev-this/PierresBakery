using System;
using System.Collections.Generic;
using CSharpBakeryCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpBakeryCalculator.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_GetAnInstanceOfPastry_Pastry()
        {
            Pastry newPastry = new Pastry();
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }
    }
}