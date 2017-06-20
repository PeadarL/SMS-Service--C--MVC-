using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using SMS_Service.Models;


namespace SMS_Service.Controllers
{
    public class HomeController : Controller
    {
        ContactList list = new ContactList();
 
        public ActionResult Index() // Returns Home Page View
        {
            ViewBag.FormMessage = "Enter the message, area code and mobile number here:";
            ViewBag.areaCode = "Instert Area Code Here: ";
            ViewBag.mobileNumber = "Instert Area Code Here: ";
            return View();
        }

        [HttpGet] // used to overload the method, as controllers don't normally allow this
        public ActionResult Index(string contactID) // Returns Home Page View
        {
            ArrayList contacts = list.generateList();
            string areaCode;
            string mobileNumber;
            foreach (Contact contact in contacts)
            {
                if (contact.foreName == contactID)
                {
                    areaCode = contact.areaCode;
                    mobileNumber = contact.mobileNumber;
                    ViewBag.FormMessage = "Enter the message, area code and mobile number here:" + contactID;
                    ViewBag.areaCode = areaCode;
                    ViewBag.mobileNumber = mobileNumber;
                }
            }
            return View();
        }

        [HttpPost] // Form Message parameters taken back via post and return confirm page
        public ActionResult Index(string sentMessage,string areaCode, string mobileNumber) //check name matches to list
        {
            SMSMessage message = new SMSMessage(sentMessage, areaCode, mobileNumber);
            ArrayList contacts = list.generateList();
            foreach(Contact contact in contacts)
            {
                if (contact.mobileNumber == message.mobileNumber)
                {
                    ViewBag.message = message.textContent;
                    System.Diagnostics.Debug.WriteLine(message.textContent);
                    ViewBag.Confirm = "You have successfully sent a message to " +
                    contact.foreName +" "+ contact.surName;
                    return View("Confirm");
                }
            }
            ViewBag.Failed = "The message to: " + message.areaCode + message.mobileNumber + ", Failed, as this number cannot be found in contacts." ;
            return View("Failed");
        }
    }
}