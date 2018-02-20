using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI;
using WebAPI.Controllers;

namespace WebAPI.Tests
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void ValuesTest()
        {
            // Arrange
            ValuesController vc = new ValuesController();
            IEnumerable<string> values = vc.Get();
            string v1 = values.First();

            // Assert
            Assert.IsNotNull(v1);
        }

        [TestMethod]
        public void GetIndex()
        {
            // Arrange
            ValuesController vc = new ValuesController();
            String values = vc.Get(1);

            // Assert
            Assert.IsNotNull(values);
        }

        [TestMethod]
        public void DeleteIndex()
        {
            // Delete string
            ValuesController vc = new ValuesController();
            vc.Delete(0);

            Assert.AreNotEqual(vc.Get(0), "value");

        }
        [TestMethod]
        public void Post()
        {
            // Add string
            ValuesController vc = new ValuesController();
            vc.Post("insert value");
            Assert.AreEqual(vc.Get(2), "insert value");
        }
        [TestMethod]
        public void FailingTestValues()
        {
            // Fail to add to string
            ValuesController vc = new ValuesController();
            //vc.Post("failing value");

            Assert.AreEqual(vc.Get(2), "failing value");
        }
    }
}
