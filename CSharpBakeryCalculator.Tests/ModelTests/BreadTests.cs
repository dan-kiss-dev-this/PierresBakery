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
            Bread newBread = new Bread();
            Assert.AreEqual(typeof(Bread), newBread.GetType());

        }
    }
}