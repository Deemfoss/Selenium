using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Items
{
    class SearchingCarsWebItems
    {

        public static WebItem SelectCarDropDown
        {
            get
            {
                return new WebItem("", "", "//select[@name='makeId']", "");
            }
        }

        public static WebItem ZipCodeTextBox
        {
            get
            {
                return new WebItem("","","//input[@name='zip']","");
            }
        }

        public static WebItem SearchButton
        {
            get
            {
                return new WebItem("", "", "//input[@value='Search']", "");
            }
        }

        public static WebItem SearchLabel
        {
            get
            {
                return new WebItem("", "", "//label[contains(text(),'Ford')]", "");
            }
        }
    }
}
