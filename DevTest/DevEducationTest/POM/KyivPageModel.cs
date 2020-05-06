using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class KyivPageModel
    {
        private IWebDriver _driver;

        public KyivPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By mainPageLocationXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/ul/li[2]/button");
        public By ourCoursesLocationXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/ul/li[2]/button");
        public By courseNameBookkeepingXPath = By.XPath("/html/body/div[1]/main/div[1]/div/section/div[1]/div[2]/h1");



        IWebElement localisation;

        public KyivPageModel FindLocalisation()
        {
            localisation = _driver.FindElement(mainPageLocationXPath);
            return this;
        }
        public string GetTextFromLocalisationLabel()
        {
            return localisation.Text;
        }
    }
}
