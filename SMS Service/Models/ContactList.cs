using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SMS_Service.Models;
using System.Collections;

namespace SMS_Service.Models
{
    public class ContactList
    {
        Contact john = new Contact("John", "Johnson", "087", "1234567");
        Contact bill = new Contact("bill", "Johnson", "087", "1234567");
        Contact tim = new Contact("tim", "Johnson", "083", "1234567");
        Contact fred = new Contact("fred", "Johnson", "086", "1234567");
        Contact george = new Contact("george", "Johnson", "084", "1234567");

        public ArrayList generateList()
        {
            ArrayList contacts = new ArrayList();
            contacts.Add(john);
            contacts.Add(bill);
            contacts.Add(tim);
            contacts.Add(fred);
            contacts.Add(george);
            return contacts;
        }
    }
}