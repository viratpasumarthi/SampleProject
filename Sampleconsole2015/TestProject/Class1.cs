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
    public class Class1 :Baseclass
    {
        //public object Driver { get; private set; }

        //IWebDriver driver;
        [SetUp]
        public void initialise()
        {
            var timespan = TimeSpan.FromMinutes(3);
            var options = new FirefoxOptions();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
           // var service = new FirefoxDriverService()
            //driver = new IWebDriver();
          //  driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes (3);
            //new FirefoxDriver(FirefoxBinary,FirefoxProfile,timespan);
            //driver.Manage().Window.Maximize();


            //var driver = new FirefoxDriver(binary, profile, timeSpan);
        }

        [Test]
        public void OpenAppTets()
        {
            // gecko
            Driver.Navigate().GoToUrl("http://www.google.com");

            //driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            // driver.
        }

        [TearDown]
        public void EndTest()
        {
            Driver.Close();
        }
    }
}
