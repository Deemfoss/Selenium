using OpenQA.Selenium.Support.UI;
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
        public string Name;

        public WebItem(string Id, string ClassName, string XPathQuery,string Name)
        {
            this.Id = Id;
            this.ClassName = ClassName;
            this.XPathQuery = XPathQuery;
            this.Name = Name;
        }

        public void Click()
        {
            TestFramework.FindWebElement(this).Click();
        }

        public void SetValue(string value)
        {
            TestFramework.FindWebElement(this).SendKeys(value);
        }

        public void SelectValue(string value)
        {
            var el = TestFramework.FindWebElement(this);
            SelectElement SelectDropdown = new SelectElement(el);
            SelectDropdown.SelectByText(value);
        }

        public string CheckElement()
        {
          var res= TestFramework.FindWebElement(this).Text;
            

            return res;
        }

    }
}
