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
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
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
