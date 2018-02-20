using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WebApp1;
using WebApp1.Controllers;
using System;

namespace WebApp1.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            var b = controller.About();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("value1", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();
            var x = controller.Contact();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void Output()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void FailingTest1()
        {
            throw new System.Exception();
        }
        [TestMethod]
        public void FailingTest2()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.MyNewMethod() as ViewResult;

            // Will not reach because of NotImplementedException
            Assert.IsNotNull(result);
        }
    }
}
