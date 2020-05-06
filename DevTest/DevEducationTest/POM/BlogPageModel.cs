using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class BlogPageModel
    {
        private IWebDriver _driver;

        public BlogPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By blogLabelTag = By.TagName("h1");
        public By firstBlogPostXPath = By.XPath("/html/body/div/main/div/div/div/div/ul/li[1]/figure/figcaption/h3/a");
        public By firstBlogPostTitleXPath = By.XPath("/html/body/div[1]/main/section/div/div/div/p[1]/span/span/strong");


        IWebElement blogLabel;
        IWebElement firstPostButton;
        IWebElement firstPostTitle;
        public BlogPageModel FindBlogLabel()
        {
            blogLabel = _driver.FindElement(blogLabelTag);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return blogLabel.Text;
        }
        public BlogPageModel FindFirstBlogPostButton()
        {
            firstPostButton = _driver.FindElement(firstBlogPostXPath);
            return this;
        }
        public BlogPageModel ClickOnFirstBlogPostButton()
        {
            firstPostButton.Click();
            return this;
        }
        public BlogPageModel FindFirstBlogPostLabel()
        {
            firstPostTitle = _driver.FindElement(firstBlogPostTitleXPath);
            return this;
        }
        public string GetTextFromFirstBlogPostLabel()
        {
            return firstPostTitle.Text;
        }



    }
}
