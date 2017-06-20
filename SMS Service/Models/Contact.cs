using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Service.Models
{
    public class Contact
    {
        public string foreName { get; set; }
        public string surName { get; set; }
       
        public string areaCode { get; set; } //(See Summary below) set to max/min 3 characters, not null
        /* Adding this validation is currently preventing connection to the localhost
         * and so has been removed until fixed
         * {
            get
            {
                return areaCode;
            }
            set
            {
                if ((value.Length >= 3))
                {
                    areaCode = value;
                }
                else
                {
                    throw new ArgumentException("Area code must have 3 characters");
                }
            }
        }*/ 
        public string mobileNumber { get; set; }
        /*{
            get
            {
                return mobileNumber;
            }
            set
            {
                if ((value.Length == 7))
                {
                    mobileNumber = value;
                }
                else
                {
                    throw new ArgumentException("The mobile number must have 7 characters");
                }
            }
        }*/

        public Contact(string foreName, string surName, string areaCode, string mobileNumber)
        {
            this.foreName = foreName;
            this.surName = surName;
            this.areaCode = areaCode;
            this.mobileNumber = mobileNumber;
        }
    }
}