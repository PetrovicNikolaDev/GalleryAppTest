using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create reference for the browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to GalleryApp Login
            driver.Navigate().GoToUrl("https://gallery-app.vivifyideas.com/login");

            driver.FindElement(By.Id("email")).SendKeys("nik@gallery.com");
            driver.FindElement(By.Id("password")).SendKeys("12345678");
            driver.FindElement(By.TagName("button")).Click();
        }

        
    }
}
