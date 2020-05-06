using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class PrivatePolicyPageModel
    {
        private IWebDriver _driver;

        public PrivatePolicyPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By privatePolicyTagName = By.TagName("h1");

        IWebElement mainLabel;



        public PrivatePolicyPageModel FindMainLabel()
        {
            mainLabel = _driver.FindElement(privatePolicyTagName);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return mainLabel.Text;
        }
    }
}
