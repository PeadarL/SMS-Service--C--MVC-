using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using SMS_Service;
using SMS_Service.Models;
using SMS_Service.Controllers;
using System.Web.Mvc;

namespace SMS_ServiceProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void about()
        {
            ContactList list = new ContactList();
            ArrayList contacts = list.generateList();
            ContactsController controller = new ContactsController();
            ViewResult result = controller.Contacts() as ViewResult;
            Assert.AreEqual(contacts, result.ViewBag.contacts);
        }
    }
}
