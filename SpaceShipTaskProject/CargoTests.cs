using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceShipExam.Tests
{
    internal class CargoTests
    {
        private Cargo cargo;
        [SetUp]
        public void SettUp()
        {
            cargo = new Cargo();
        }
       [Test]
       public void TestResult()
        {
            
            cargo.BoughtSpaceShipYear = 2308;
            cargo.LightMiles = 344_789;
            var expected = 326768;
            var result = cargo.Result();
            Console.WriteLine("Cargo SpaceShip Tax Result is:" + cargo.Result());
            Assert.AreEqual(expected,result);
        }
        [Test]
        public void TestResultExeption()
        {
            cargo.BoughtSpaceShipYear = 2346;
            Assert.That(() => cargo.Result(), Throws.Exception.With.Message.EqualTo("Test1"));
        }
        [Test]
        public void TestSetterValidation()
        {
            Assert.That(() => cargo.TheYear = 0, Throws.Exception);
        }
    }
}
