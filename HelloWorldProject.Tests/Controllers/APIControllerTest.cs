using HelloWorldAPI.Controllers;
using HelloWorldBusiness.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HelloWorldProject.Tests.Controllers
{
    [TestClass]
    public class APIControllerTest
    {
        private Mock<IDataSource> dataSourceMock;

        [TestMethod]
        public void GetApiResponseTest()
        {
            //Mock Data
            dataSourceMock = new Mock<IDataSource>();
            dataSourceMock.Setup(m => m.getDataString()).Returns("Hello World!");

            //Create Class
            HelloWorldApiController apiController = new HelloWorldApiController(dataSourceMock.Object);

            //Call
            string result = apiController.Get();

            //Test
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "Hello World!");
        }
    }
}
