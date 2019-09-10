using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    class LoginActions
    {
        public static void DoLogin()
        {
            LoginWebItems.UserNameTextBox.SetValue("nema");
            LoginWebItems.PasswordTextBox.SetValue("pass");
            LoginWebItems.LoginButton.Click();

            TestFramework.Delay();

        }
    }
}
