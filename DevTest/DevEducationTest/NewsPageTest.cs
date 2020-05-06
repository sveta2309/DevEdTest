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
       [Test]

        public void CheckMainLabel()
        {
            NewsPageModel newsPageModel = new NewsPageModel(driver);
            base.driver.Url = Urls.newsPage;
            string actRes = newsPageModel.FindNewsLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("Новости", actRes);
        }
        [Test]

        public void CheckFirstPostButton()
        {
            NewsPageModel newsPageModel = new NewsPageModel(driver);
            base.driver.Url = Urls.newsPage;
            string actRes = newsPageModel.FindFirstNewsPostButton()
                .ClickOnFirstArticleButton()
                .FindFirstNewsLabel()
                .GetTextFromFirstNewsBlogPostLabel();
            Assert.AreEqual("В Баку выпускников пригласили в крупные IT-компании", actRes);
        }
    }
}
