using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using HelloWorldConsole.Interface;
using HelloWorldConsole.Class;

namespace HelloWorldProject.Tests.Controllers
{
    [TestClass]
    public class HelloWorldConsoleTest
    {
        [TestMethod]
        public void ConsoleApplicationTest()
        {
            Mock<IServiceAccess> serviceAccessMock = new Mock<IServiceAccess>();

            ApplicationCode applicationCode = new ApplicationCode(serviceAccessMock.Object);

            serviceAccessMock.Setup(m => m.getDataString()).Returns("Hello World!");

            String response = applicationCode.Run();

            Assert.IsNotNull(response);
            Assert.AreEqual("Hello World!", response);

        }
    }
}
