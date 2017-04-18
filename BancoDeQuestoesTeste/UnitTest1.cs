using System;
using System.Web.Mvc;
using BancoDeQuestoes.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoDeQuestoesTeste
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            if (result != null)
            {
                Assert.AreEqual("Index", result.ViewName);
            }
        }
    }
}
