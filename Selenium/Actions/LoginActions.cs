using Selenium.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Actions
{
    class LoginActions
    {
        public static void DoLogin()
        {
            try
            {
                LoginWebItems.LoginFormButton.Click();
                LoginWebItems.UserNameTextBox.SetValue("demfoss@gmail.com");
                LoginWebItems.PasswordTextBox.SetValue("Bqweqweq!");
                LoginWebItems.LoginButton.Click();
                TestFramework.Delay();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} exceptions ", e.Message);
            }


        }
    }
}
