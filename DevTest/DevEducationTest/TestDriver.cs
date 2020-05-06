using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class TestDriver
    {
        public IWebDriver driver;
        
        [SetUp]

        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Lenovo\\Desktop\\Ковалёва Света");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
