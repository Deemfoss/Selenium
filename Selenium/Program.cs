using System;

namespace Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase.doTestCase();
            TestFramework.Delay();
            TestCase.doSearch();
        }
    }
}
