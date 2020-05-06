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
    public class CoursesPageTest : TestDriver

    {

        [Test]

        public void CheckMainLabel()
        {
            CoursesPageModel coursesPageModel = new CoursesPageModel(driver);
            base.driver.Url = Urls.coursesPage;
            string actRes = coursesPageModel.FindCoursesLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Наши курсы", actRes);
        }

        [Test]

        public void CheckKyivLabel()
        {
            CoursesPageModel coursesPageModel = new CoursesPageModel(driver);
            base.driver.Url = Urls.coursesPage;
            string actRes = coursesPageModel.FindKyivCityButton()
                .ClickOnKyivCityButton()
                .FindLocalisation()
                .GetTextFromLocalisationLabel();
            Assert.AreEqual("Киев", actRes);
        }

        [Test]
        public void CheckBookkeepingKyivLabel()
        {
            CoursesPageModel coursesPageModel = new CoursesPageModel(driver);
            base.driver.Url = Urls.coursesPage;
            string actRes = coursesPageModel.FindKyivBookkeepingButton()
                .ClickOnKyivBookkeepingButton()
                .FindCoursesLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Bookkeeping", actRes);
        }

        [Test]

        public void CheckContactUsOption()
        {
            CoursesPageModel coursesPageModel = new CoursesPageModel(driver);
            base.driver.Url = Urls.coursesPage;
            IWebElement actRes = coursesPageModel.FindContactUsButton()
                .ClickOnContactUsButton()
                .FindNameField()
                .SendName()
                .FindEmailField()
                .SendEMail()
                .FindMessageField()
                .SendMessage()
                .FindSendButton()
                .ClickOnSendButton()
                .FindPopUpMessage();
            if (actRes != null)
            {
                Assert.Pass();
            }
        }
    }
}
