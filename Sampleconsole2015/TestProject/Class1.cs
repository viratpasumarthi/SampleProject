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
        //public object Driver { get; private set; }

        //  public Baseclass CA = new Baseclass();

        [SetUp]
        public void initialise()
        {

            var timespan = TimeSpan.FromMinutes(3);
            var options = new FirefoxOptions();
            // CA.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes(3);
            // var service = new FirefoxDriverService()
            //driver = new IWebDriver();
            //  driver.Manage().Timeouts().PageLoad = TimeSpan.FromMinutes (3);
            //new FirefoxDriver(FirefoxBinary,FirefoxProfile,timespan);
            


            //var driver = new FirefoxDriver(binary, profile, timeSpan);
        }

        [Test]
        public void OpenAppTets()
        {

            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //= @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            IWebDriver driver = new FirefoxDriver(service);
            driver.Manage().Window.Maximize();
            // gecko
            driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            driver.Close();
            // CA.Driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Navigate().GoToUrl("http://www.google.com");

            //driver.Navigate().GoToUrl("http://iircdev.niu.edu/2017");
            // driver.
        }

        [TearDown]
        public void EndTest()
        {
            //CA.Driver.Close();
            
        }
    }
}
