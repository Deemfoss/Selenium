using Selenium.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
    public class TestCase
    {
        public static void doTestCase()
        {
            PagesActions.OpenLoginPage();
            LoginActions.DoLogin();
        }

        public static void doSearch()
        {
            PagesActions.OpenHomePage();
            SearchingActions.DoSearch();
            TestFramework.Delay();
        }

    }
}
