using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class KyivBookkeepingPageModel
    {
        private IWebDriver _driver;

        public KyivBookkeepingPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By courseName = By.TagName("h1");
       

        IWebElement courseNameLabel;
        public KyivBookkeepingPageModel FindCoursesLabel()
        {
            courseNameLabel = _driver.FindElement(courseName);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return courseNameLabel.Text;
        }
    }
}
