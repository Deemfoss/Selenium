using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
   public class LoginWebItems
    {

        public static WebItem UserNameTextBox;

        public static WebItem PasswordTextBox;

        public static WebItem LoginButton
        {
            get
            {
                return new WebItem ("ctl00_ContentPlaceHolder1_LoginButton", "", ""); 
            }
        }
    }
}
