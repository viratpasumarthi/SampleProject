using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void initialise()
        {
            var timespan = TimeSpan.FromMinutes(3);
            var options = new FirefoxOptions();
           // var service = new FirefoxDriverService()
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes (3);
            //new FirefoxDriver(FirefoxBinary,FirefoxProfile,timespan);
            driver.Manage().Window.Maximize();


            //var driver = new FirefoxDriver(binary, profile, timeSpan);
        }

        [Test]
        public void OpenAppTets()
        {
            // gecko

            driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            // driver.
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
