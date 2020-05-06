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
    public class BlogPageTest:TestDriver
    {
        [Test]

        public void CheckMainLabel()
        {
            BlogPageModel blogPageModel = new BlogPageModel(driver);
            base.driver.Url = Urls.blogPage;
            string actRes = blogPageModel.FindBlogLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("Блог", actRes);
        }


        [Test]

        public void CheckFirstPostButton()
        {
            BlogPageModel blogPageModel = new BlogPageModel(driver);
            base.driver.Url = Urls.blogPage;
            string actRes = blogPageModel.FindFirstBlogPostButton()
                .ClickOnFirstBlogPostButton()
                .FindFirstBlogPostLabel()
                .GetTextFromFirstBlogPostLabel();
            Assert.AreEqual("Как стать iOS разработчиком?", actRes);
        }
    }
}
