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
       
       
        [Test]

        public void CheckMainLabel()
        {
            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel(driver);
            base.driver.Url = Urls.aboutUsPage;
            string actRes = aboutUsPageModel.FindAboutUsLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("О нас", actRes);
        }


        [Test]

        public void CheckMoreDetailsButton()
        {
            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel(driver);
            base.driver.Url = Urls.aboutUsPage;
            string actRes = aboutUsPageModel.FindMoreDetailsAboutUsMenuButton()
                .ClickOnMoreDetailsButton()
                .FindMainLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Вдохновитель", actRes);
        }

    }
}
