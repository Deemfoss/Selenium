using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using Selenium.Items;
namespace Selenium.Actions
{
    class SearchingActions
    {
        public static void DoSearch()
        {
            try
            {
                SearchingCarsWebItems.SelectCarDropDown.SelectValue("Ford");
                SearchingCarsWebItems.ZipCodeTextBox.SetValue("28273");
                SearchingCarsWebItems.SearchButton.Click();
              var name=  SearchingCarsWebItems.SearchLabel.CheckElement();
                
                if (name=="Ford")
                {
                    Console.WriteLine("Searching work like expected");
                }
                else
                Console.WriteLine("Sheet is happens");

            }
            catch (Exception e)
            {

                Console.WriteLine("{0} Some exception",e);
            }
   
           
        }

    }
}
