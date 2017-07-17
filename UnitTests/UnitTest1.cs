using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CH.Controllers;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new HelloController();

            // Act
            var result = controller.GetOutputText();

            // Assert
            Assert.IsInstanceOfType(result, typeof(OkNegotiatedContentResult<string>));
        }

        [TestMethod]
        public void TestMethod2()
        {
            var controller = new HelloController();

            // Act
            var result = controller.GetOutputText();

            // Assert
            var stringValue = result as OkNegotiatedContentResult<string>;
            Assert.IsNotNull(stringValue);
            Assert.AreEqual("Hello World", stringValue.Content);

        }
    }
}
