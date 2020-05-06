using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class MoreDetailsAboutUsPageModel
    {
        private IWebDriver _driver;

        public MoreDetailsAboutUsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By mainLabelTagName = By.TagName("h1");

        IWebElement mainLabel;



        public MoreDetailsAboutUsPageModel FindMainLabel()
        {
            mainLabel = _driver.FindElement(mainLabelTagName);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return mainLabel.Text;
        }
    }
}
