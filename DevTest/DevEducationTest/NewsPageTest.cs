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
    public class NewsPageTest : TestDriver
    {
        
       
        NewsPageModel newsPageModel;
        public NewsPageTest()
        {
            newsPageModel = new NewsPageModel();
        }
        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.newsPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(newsPageModel.newsLabelTag));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Новости", actRes);
        }


        [Test]

        public void CheckFirstNews()
        {
            base.driver.Url = Urls.newsPage;
            IWebElement firstNews = driver.FindElement(By.XPath(newsPageModel.firstNewsXPath));
            firstNews.Click();
            IWebElement title = driver.FindElement(By.XPath(newsPageModel.firstNewsTitleXPath));
            string actRes = title.Text;
            Assert.AreEqual("В Баку выпускников пригласили в крупные IT-компании", actRes);
        }
    }
}
