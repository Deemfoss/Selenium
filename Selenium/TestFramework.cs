using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
namespace Selenium
{
    public class TestFramework
    {
        static RemoteWebDriver _webDriver;

        public static RemoteWebDriver webDriver
        {
            get
            {
                if (_webDriver == null)
                {
                    _webDriver = new ChromeDriver();
                }

                return _webDriver;
            }
        }

        public static void OpenUrl(string URl)
        {
            webDriver.Navigate().GoToUrl(URl);
        }

        public static IWebElement FindWebElement(WebItem webItem)
        {

            if (webItem.Id != "")
            {
                return webDriver.FindElementById(webItem.Id);
            }

            if (webItem.ClassName != "")
            {
                return webDriver.FindElementByClassName(webItem.ClassName);
            }

            if (webItem.XPathQuery != "")
            {
                return webDriver.FindElementByXPath(webItem.XPathQuery);
            }

            return null;
        }

        public static void Delay(int time=10)
        {

            System.Threading.Thread.Sleep(time * 1000);
        }

        
    }
}
