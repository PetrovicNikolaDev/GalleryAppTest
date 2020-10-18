using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GalleryAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is test data, remove the comments to run the tests
            
            //testLogin("nik@gallery.com", "12345678");
            //testCreateGallery("nik@gallery.com", "12345678", "Snow", "Snowy Gallery", "https://static.euronews.com/articles/stories/04/45/99/98/945x531_cmsv2_371acacd-a248-570b-8e4a-a28481ce9f55-4459998.jpg");
        }

        public static void testLogin(string Email, string Password)
        {
            //Create reference for the browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Navigate to GalleryApp Login
            driver.Navigate().GoToUrl("https://gallery-app.vivifyideas.com/login");
            //Fill out the form and submit
            driver.FindElement(By.Id("email")).SendKeys(Email);
            driver.FindElement(By.Id("password")).SendKeys(Password);
            driver.FindElement(By.TagName("button")).Click();
            //Waiting for new page to load
            Thread.Sleep(1000);
            //Test if login was successfull 
            string currentUrl = driver.Url;
            string expectedUrl = "https://gallery-app.vivifyideas.com/";
            if (currentUrl.Equals(expectedUrl))
            {
                Console.WriteLine("Login Test successfull");
            }
            else
            {
                Console.WriteLine("Login Test Failed");
            }

        }
        public static void testCreateGallery(string Email, string Password, string Title, string Description, string imageUrl)
        {
            //Create reference for the browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Navigate to GalleryApp Login
            driver.Navigate().GoToUrl("https://gallery-app.vivifyideas.com/login");
            //Fill out the form and submit
            driver.FindElement(By.Id("email")).SendKeys(Email);
            driver.FindElement(By.Id("password")).SendKeys(Password);
            driver.FindElement(By.TagName("button")).Click();
            //Waiting for new page to load
            Thread.Sleep(1000);
            //Fill out the Create Gallery form and Submit 
            driver.FindElement(By.LinkText("Create Gallery")).Click();
            driver.FindElement(By.Id("title")).SendKeys("Snow");
            driver.FindElement(By.Id("description")).SendKeys("Snowy Gallery");
            driver.FindElement(By.XPath("//input[@type='url']")).SendKeys("https://static.euronews.com/articles/stories/04/45/99/98/945x531_cmsv2_371acacd-a248-570b-8e4a-a28481ce9f55-4459998.jpg");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            //Waiting for page to load
            Thread.Sleep(1000);
            //Test if the Gallery has been created Successfully
            string currentUrl = driver.Url;
            string expectedUrl = "https://gallery-app.vivifyideas.com/";
            if (currentUrl.Equals(expectedUrl))
            {
                Console.WriteLine("Create Gallery Test successfull");
            }
            else
            {
                Console.WriteLine("Create Gallery Test Failed");
            }
        }
        
    }
}
