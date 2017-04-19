using System;
using System.Web.Mvc;
using BancoDeQuestoes.Mvc.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace BancoDeQuestoesTeste
{
    [TestFixture]
    public class HomeControllerTest
    {
	    private HomeController _home;

		[SetUp]
	    public void Setup()
	    {
		    _home = new HomeController();
	    }

        [Test]
        public void TestIndex()
        {
	        var result = _home.Index() as ViewResult;

			Assert.AreEqual("Index",result.ViewName);

        }

		[Test]
		public void TestAbout()
		{
			var result = _home.About() as ViewResult;

			Assert.AreEqual("About", result.ViewName);

		}

		[Test]
		public void TestContact()
		{
			var result = _home.Contact() as ViewResult;

			Assert.AreEqual("Contact", result.ViewName);

		}
	}
}
