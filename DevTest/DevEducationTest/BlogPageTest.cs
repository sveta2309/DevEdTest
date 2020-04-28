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
        BlogPageModel blogPageModel;

        public BlogPageTest()
        {
            blogPageModel = new BlogPageModel();
        }


        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.blogPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(blogPageModel.blogLabelTag));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Блог", actRes);
        }

        [Test]

        public void CheckFirstBlogPost()
        {
            base.driver.Url = Urls.blogPage;
            IWebElement firstBlogPost = driver.FindElement(By.XPath(blogPageModel.firstBlogPostXPath));
            firstBlogPost.Click();
            IWebElement title = driver.FindElement(By.XPath(blogPageModel.firstBlogPostTitleXPath));
            string actRes = title.Text;
            Assert.AreEqual("Как стать iOS разработчиком?", actRes);
        }
    }
}
