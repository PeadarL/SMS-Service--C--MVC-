using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using SMS_Service.Models;

namespace SMS_Service.Controllers
{
    public class ContactsController : Controller
    {
        ContactList list = new ContactList();
        
        // GET: Contacts
        public ActionResult Contacts() //changed from index
        {
            ViewBag.contacts = list.generateList();
            return View();
        }
    }
}