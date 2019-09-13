using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
   public class PagesActions
    {
        public static void OpenLoginPage()
        {
            TestFramework.OpenUrl("https://www.cars.com/profile/secure/signup/");
           
        }
        public static void OpenHomePage()
        {
            TestFramework.OpenUrl("https://www.cars.com/");

        }
       
    }
}
