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
    public class MainPageTest:TestDriver
    {
        MainPageModel mainPageModel;
        CoursesPageModel coursesPageModel;
        GraduatesPageModel graduatesPageModel;
        NewsPageModel newsPageModel;
        BlogPageModel blogPageModel;
        AboutUsPageModel aboutUsPageModel;
        ContactsPageModel contactsPageModel;
        KyivPageModel kyivPageModel;
        public MainPageTest()
        {
            mainPageModel = new MainPageModel();
            coursesPageModel = new CoursesPageModel();
            graduatesPageModel = new GraduatesPageModel();
            newsPageModel = new NewsPageModel();
            blogPageModel = new BlogPageModel();
            aboutUsPageModel = new AboutUsPageModel();
            contactsPageModel = new ContactsPageModel();
            kyivPageModel = new KyivPageModel();

        }

        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement mainLabel =driver.FindElement(By.TagName(mainPageModel.mainLabelTagName));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Международный IT-колледж", actRes);
        }
        [Test]

        public void CheckCoursesLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(mainPageModel.courseMenuButtonXPath));
            coursesButton.Click();
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesPageModel.ourCoursesLabelTag));
            string actRes = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actRes);
        }
        [Test]

        public void CheckGraduatesLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement graduatesButton = driver.FindElement(By.XPath(mainPageModel.graduetesMenuButtonXPath));
            graduatesButton.Click();
            IWebElement ourGraduatesLabel = driver.FindElement(By.XPath(graduatesPageModel.ourGraduatesLabelXPath));
            string actRes = ourGraduatesLabel.Text;
            Assert.AreEqual("Наши выпускники", actRes);
        }
        [Test]

        public void CheckNewsLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement newsButton = driver.FindElement(By.XPath(mainPageModel.newsMenuButtonXPath));
            newsButton.Click();
            IWebElement newsLabel = driver.FindElement(By.TagName(newsPageModel.newsLabelTag));
            string actRes = newsLabel.Text;
            Assert.AreEqual("Новости", actRes);
        }

        [Test]

        public void CheckBlogLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement blogButton = driver.FindElement(By.XPath(mainPageModel.blogMenuButtonXPath));
            blogButton.Click();
            IWebElement blogLabel = driver.FindElement(By.TagName(blogPageModel.blogLabelTag));
            string actRes = blogLabel.Text;
            Assert.AreEqual("Блог", actRes);
        }
        [Test]

        public void CheckAboutUsLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement aboutUsButton = driver.FindElement(By.XPath(mainPageModel.aboutUsMenuButtonXPath));
            aboutUsButton.Click();
            IWebElement aboutUsLabel = driver.FindElement(By.ClassName(aboutUsPageModel.aboutUsClassName));
            string actRes = aboutUsLabel.Text;
            Assert.AreEqual("О нас", actRes);
        }
        [Test]

        public void CheckContactsLabel()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement contactsButton = driver.FindElement(By.XPath(mainPageModel.contactsMenuButtonXPath));
            contactsButton.Click();
            IWebElement contactsLabel = driver.FindElement(By.TagName(contactsPageModel.contactsLabelTag));
            string actRes = contactsLabel.Text;
            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]

        public void CheckMapKyivButton()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement mapKyivButton = driver.FindElement(By.XPath(mainPageModel.mapKyivButtonXPath));
            mapKyivButton.Click();
            IWebElement locationLabel = driver.FindElement(By.XPath(kyivPageModel.mainPageLocationXPath));
            string actRes = locationLabel.Text;
            Assert.AreEqual("Киев", actRes);
        }

        [Test]
        public void CheckPrivatePolicyButton()
        {
            base.driver.Url = Urls.mainPage;
            IWebElement privatePolicyButton = driver.FindElement(By.ClassName(mainPageModel.PrivatePolicyButtonClassName));
            privatePolicyButton.Click();
            IWebElement titleLabel = driver.FindElement(By.XPath("/html/body/div/main/div/div/h1"));
            string actRes = titleLabel.Text;
            Assert.AreEqual("Политика конфиденциальности", actRes);
        }

    }
}
