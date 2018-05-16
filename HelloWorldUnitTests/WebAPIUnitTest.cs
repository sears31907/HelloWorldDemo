using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldWebAPI.Controllers;

namespace HelloWorldUnitTests
{
    [TestClass]
    public class WebAPIUnitTest
    {
     
        [TestMethod]
        public void GetMessage()
        {
            var controller = new HelloWorldController();

            var result = controller.Get();
            Assert.AreEqual("Hello World!", result);
        }

       
    }
}
