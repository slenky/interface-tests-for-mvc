using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MvcApplicationTest.InterfaceTests.Controllers
{
    [TestClass]
    public class AvailabilityTests
    {
	static IWebDriver driver = new ChromeDriver(@"C:\jenkins\other\");
        [TestMethod]
        public void GetPageTitle()
        {
            try
            {
			
                driver.Navigate().GoToUrl("http://localhost:3050/");
				var title = driver.Title;
				Assert.AreEqual("ASP.NET Web API Help Page", title);
				
				//driver.Close();

            }
            catch (Exception ex) { }
            finally
            {
                driver.Quit();
            }
        }
        [TestMethod]
        public void OpenAPIPage()
        {
            
            try
            {
                driver.Navigate().GoToUrl("http://localhost:3050/");
				driver.FindElement(By.LinkText("API")).Click();
				driver.FindElement(By.LinkText("GET api/Values")).Click();
				var CurrentTitle = driver.Title;
				Assert.AreEqual("GET api/Values", CurrentTitle);
				driver.Close();
            }
            catch (Exception ex) { }
            finally
            {
                driver.Quit();
            }
        }		
    }
}
