using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sampleconsole2015;

namespace TestProject
{

    public class Class1       
    {

        [SetUp]
        public void initialise()
        {
            var timespan = TimeSpan.FromMinutes(3);
            var options = new FirefoxOptions();
            
        }

        [Test] // Unit Testing
        public void unit_test1()
        {
            Program myprog = new Program();
            int a = 10, b = 20;
            Assert.AreEqual(200, myprog.add(a, b));
        }

        [Test] // Integration Testing
        public void Integration_Test()
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            driver.Close();
            
        }
        

        [TearDown]
        public void EndTest()
        {
            //= @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            // CA.Driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            // driver.
            // CA.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            // var service = new FirefoxDriverService()
            //driver = new IWebDriver();
            //  driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes (3);
            //new FirefoxDriver(FirefoxBinary,FirefoxProfile,timespan);
            //CA.Driver.Close();
            //public object Driver { get; private set; }
            //  public Baseclass CA = new Baseclass();
        }
    }
}
