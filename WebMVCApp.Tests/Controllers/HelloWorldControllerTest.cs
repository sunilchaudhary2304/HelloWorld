using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebMVCApp.Controllers;

namespace WebMVCApp.Tests.Controllers
{
    [TestClass]
   public class HelloWorldControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //Arrange
            const string actualData = "Hello World";
            HelloWorldController controller = new HelloWorldController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            string expectedData = result.ViewBag.Message;

            //Assert
            Assert.AreEqual(expectedData, actualData);
        }

    }
}
