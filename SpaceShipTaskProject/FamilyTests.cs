using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipExam.Tests
{
    internal class FamilyTests
    {
        private Family family;
        [SetUp]
        public void SettUp()
        {
            family = new Family();
        }
        [Test]
        public void TestResult()
        {

            family.BoughtSpaceShipYear = 2338;
            family.LightMiles = 2_344;
            var expected = 2715;
            var result = family.Result();
            Console.WriteLine("Family SpaceShip Tax Result is:" + family.Result());

            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestResultExeption()
        {
            family.BoughtSpaceShipYear = 2346;
            Assert.That(() => family.Result(), Throws.Exception.With.Message.EqualTo("Test2"));
        }
        [Test]
        public void TestSetterValidation()
        {
            Assert.That(() => family.TheYear = 0, Throws.Exception);
        }
    }
}
