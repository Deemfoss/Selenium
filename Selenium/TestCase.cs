using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    public class TestCase
    {
        public static void doTestCase()
        {
            PagesActions.OpenHomePage();
            LoginActions.DoLogin();
        }

    }
}
