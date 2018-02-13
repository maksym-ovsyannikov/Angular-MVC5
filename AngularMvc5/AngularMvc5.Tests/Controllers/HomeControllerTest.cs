using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AngularMvc5;
using AngularMvc5.Controllers;

namespace AngularMvc5.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
