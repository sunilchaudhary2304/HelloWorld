using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace HelloWorldTest.Tests
{
    [TestClass]
    public class HelloWorldConsoleAppUnitTest
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            const string actualData = "Hello World";

            // Call the method to test
            string expectedData = MainDriver.Run();

            // Check values
            Assert.AreEqual(expectedData, actualData);

        }
    }
}