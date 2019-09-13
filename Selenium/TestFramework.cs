using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

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
                    _webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
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
            if (webItem.Name != "")
            {
                webDriver.FindElementByName(webItem.Name);
            }
            return null;
        }

        public static void Delay(int time=10)
        {

            System.Threading.Thread.Sleep(time * 1000);
        }

        
    }
}
