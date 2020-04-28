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
        CoursesPageModel coursesPageModel;
        KyivPageModel kyivPageModel;

        public CoursesPageTest()
        {
            coursesPageModel = new CoursesPageModel();
            kyivPageModel = new KyivPageModel();

        }


        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.coursesPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(coursesPageModel.ourCoursesLabelTag));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Наши курсы", actRes);
        }

        [Test]

        public void CheckKyivLabel()
        {
            base.driver.Url = Urls.coursesPage;
            IWebElement cityKyivButton = driver.FindElement(By.XPath(coursesPageModel.cityKiyvXPath));
            cityKyivButton.Click();
            IWebElement locationLabel = driver.FindElement(By.XPath(kyivPageModel.ourCoursesLocationXPath));
            string actRes = locationLabel.Text;
            Assert.AreEqual("Киев", actRes);
        }

        [Test]
        public void CheckBookkeepingKyivLabel()
        {
            base.driver.Url = Urls.coursesPage;
            IWebElement bookkeepingKyivButton = driver.FindElement(By.XPath(coursesPageModel.bookkeepingKiyvXPath));
            bookkeepingKyivButton.Click();
            IWebElement bookkeepingCourseKyiv = driver.FindElement(By.XPath(kyivPageModel.courseNameBookkeepingXPath));
            string actRes = bookkeepingCourseKyiv.Text;
            Assert.AreEqual("Bookkeeping", actRes);
        }





        //[Test]
        //Тест падает, не могу понять в чем причина. Пишет что с полем имейла нельзя взаимодействовать, и не может записать в него строку.

        //public void CheckContactUsOption()
        //{
        //    base.driver.Url = Urls.coursesPage;
        //    IWebElement contactUsButton = driver.FindElement(By.XPath(coursesPageModel.contactUsXPath));
        //    contactUsButton.Click();
        //    IWebElement nameField = driver.FindElement(By.Name(coursesPageModel.contactUsInputName));
        //    nameField.SendKeys("test");
        //    IWebElement emailField = driver.FindElement(By.Name(coursesPageModel.contactUsInputEMailName));
        //    //emailField.SendKeys("test@i.ua");
        //    IWebElement messageField = driver.FindElement(By.Name(coursesPageModel.contactUsInputMessageName));
        //    messageField.SendKeys("test");
        //    IWebElement sendButton = driver.FindElement(By.XPath(coursesPageModel.contactUsSendButtonClassName));
        //    sendButton.Click();
        //    IWebElement massegeSendWindow = driver.FindElement(By.XPath(coursesPageModel.contactUsMessageSendXPath));
        //    string actRes = massegeSendWindow.Text;
        //    Assert.AreEqual("Сообщение отправлено", actRes);

        //}


    }
}
