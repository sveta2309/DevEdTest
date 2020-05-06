using DevEducationTest.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest
{
    public class MainPageTest : TestDriver
    {




        [Test]

        public void CheckMainLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindMainLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("Международный IT-колледж", actRes);
        }


        [Test]

        public void CheckCoursesLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindCoursesMenuButton()
                .ClickOnCourseButton()
                .FindCoursesLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Наши курсы", actRes);
        }
        [Test]

        public void CheckGraduatesLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindGraduatesMenuButton()
                .ClickOnGraduatesButton()
                .FindGraduatesLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Наши выпускники", actRes);
        }
        [Test]

        public void CheckNewsLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindNewsMenuButton()
                .ClickOnNewsButton()
                .FindNewsLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Новости", actRes);
        }

        [Test]

        public void CheckBlogLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindBlogMenuButton()
                .ClickOnBlogButton()
                .FindBlogLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Блог", actRes);
        }
        [Test]

        public void CheckAboutUsLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindAboutUsMenuButton()
                .ClickOnAboutUsButton()
                .FindAboutUsLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("О нас", actRes);
        }
        [Test]

        public void CheckContactsLabel()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindContactsMenuButton()
                .ClickOnContactsButton()
                .FindContactsLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]

        public void CheckMapKyivButton()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindMapDotKyivButton()
                .ClickOnKyivMapButton()
                .FindLocalisation()
                .GetTextFromLocalisationLabel();
            Assert.AreEqual("Киев", actRes);
        }

        [Test]
        public void CheckPrivatePolicyButton()
        {
            MainPageModel mainPageModel = new MainPageModel(driver);
            base.driver.Url = Urls.mainPage;
            string actRes = mainPageModel.FindPrivatePolicyButton()
                .ClickOnPrivatePolicyButton()
                .FindMainLabel()
                .GetTextFromMainLabel();
            Assert.AreEqual("Политика конфиденциальности", actRes);
        }

    }
}
