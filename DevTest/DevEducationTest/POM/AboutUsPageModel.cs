using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class AboutUsPageModel

    {
        private IWebDriver _driver;

        public AboutUsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By aboutUsClassName = By.ClassName("about-us-subtitle");
        public By moreDetailsButtonXPath = By.XPath("/html/body/div[1]/main/div[3]/div/div/a");

        IWebElement aboutUsLabel;
        IWebElement moreDetailsAboutUsLabel;
        public AboutUsPageModel FindAboutUsLabel()
        {
            aboutUsLabel = _driver.FindElement(aboutUsClassName);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return aboutUsLabel.Text;
        }
        public AboutUsPageModel FindMoreDetailsAboutUsMenuButton()
        {
            moreDetailsAboutUsLabel = _driver.FindElement(moreDetailsButtonXPath);
            return this;
        }
        public MoreDetailsAboutUsPageModel ClickOnMoreDetailsButton()
        {
            moreDetailsAboutUsLabel.Click();
            return new MoreDetailsAboutUsPageModel(_driver);
        }
    }
}
