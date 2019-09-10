using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium
{
   public class WebItem
    {
        public string Id;
        public string ClassName;
        public string XPathQuery;


        public WebItem(string Id, string ClassName, string XPathQuery)
        {
            this.Id = Id;
            this.ClassName = ClassName;
            this.XPathQuery = XPathQuery;
        }


        public void Click()
        {
            TestFramework.FindWebElement(this).Click();
        }

        public void SetValue( string value)
        {
            TestFramework.FindWebElement(this).SendKeys(value);
        }

    }
}
