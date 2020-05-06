using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class NewsPageModel
    {
        private IWebDriver _driver;

        public NewsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By newsLabelTag = By.TagName("h1");
        public By firstNewsXPath = By.XPath( "/html/body/div[1]/main/div/div/div[1]/div/ul/li[1]/figure/figcaption/h3/a");
        public By firstNewsTitleXPath = By.XPath("/html/body/div[1]/main/section/div/div/div/p[1]/span/strong");



        IWebElement  newsLabel;
        IWebElement firstArticle;
        IWebElement firstPostTitle;

        public NewsPageModel FindNewsLabel()
        {
            newsLabel = _driver.FindElement(newsLabelTag);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return newsLabel.Text;
        }
        public NewsPageModel FindFirstNewsPostButton()
        {
            firstArticle = _driver.FindElement(firstNewsXPath);
            return this;
        }
        public NewsPageModel ClickOnFirstArticleButton()
        {
            firstArticle.Click();
            return this;
        }
        public NewsPageModel FindFirstNewsLabel()
        {
            firstPostTitle = _driver.FindElement(firstNewsTitleXPath);
            return this;
        }
        public string GetTextFromFirstNewsBlogPostLabel()
        {
            return firstPostTitle.Text;
        }




    }
}
