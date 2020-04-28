using DevEducationTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class AboutUsPageTest:TestDriver
    {
        AboutUsPageModel aboutUsPageModel;
        public AboutUsPageTest()
        {
            aboutUsPageModel = new AboutUsPageModel();
        }
        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.aboutUsPage;
            IWebElement mainLabel = driver.FindElement(By.ClassName(aboutUsPageModel.aboutUsClassName));
            string actRes = mainLabel.Text;
            Assert.AreEqual("О нас", actRes);
        }


        [Test]

        public void CheckMoreDetailsButton()
        {
            base.driver.Url = Urls.aboutUsPage;
            IWebElement moreDetailsButton = driver.FindElement(By.XPath(aboutUsPageModel.moreDetailsButtonXPath));
            moreDetailsButton.Click();
            IWebElement title = driver.FindElement(By.TagName("h1"));
            string actRes = title.Text;
            Assert.AreEqual("Вдохновитель", actRes);
        }

    }
}
