using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Items
{
   public class LoginWebItems
    {

        public static WebItem UserNameTextBox
        {
            get
            {
                return new WebItem("","", "//input[@ng-model='$ctrl.credentials.email']","");
            }
        }

        public static WebItem PasswordTextBox
        {
            get
            {
                return new WebItem("", "", "//input[@ng-model='$ctrl.credentials.password']","");
            }
        }

        public static WebItem LoginFormButton
        {
            get
            {
                return new WebItem("", "", "//li[@tab-for='login']","");
            }
        }

        public static WebItem LoginButton
        {
            get
            {
                return new WebItem ("", "", "//button[@data-linkname='log-in-submit']",""); 
            }
        }
    }
}
