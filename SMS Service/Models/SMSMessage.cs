using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMS_Service.Models
{
    public class SMSMessage
    {
        public string areaCode { get; set; }//(See Summary below) set to max/min 3 characters, not null
        /*Adding this validation is currently preventing connection to the localhost
         * and so has been removed until fixed
         * {
            get
            {
                return areaCode;
            }
            set
            {
                if ((value.Length == 3))
                {
                    areaCode = value;
                }
                else
                {
                    throw new ArgumentException("Area code must have 3 characters");
                }
            }
        }*/
        public string mobileNumber { get; set; }// set to max/min 7 characters, not null
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
        public string textContent { get; set; } // set to max 141/min 1 characters, not null
        /*{
            get
            {
                return textContent;
            }
            set
            {
                if ((value.Length < 141) &&  (value.Length > 1))
                {
                    textContent = value;
                }
                else
                {
                    throw new ArgumentException("Text must be at least one character and less than 141 characters long");
                }
            }
        }*/
        public SMSMessage(string textContent, string areaCode, string mobileNumber)
        {
            this.areaCode = areaCode;
            this.mobileNumber = mobileNumber;
            this.textContent = textContent;
        }
    }
}