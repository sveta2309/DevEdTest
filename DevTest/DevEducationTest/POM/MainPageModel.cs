using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class MainPageModel
    {
        public By mainLabelTagName = By.TagName("h1");
        public By courseMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a");
        public By graduetesMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a");
        public By newsMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a");
        public By blogMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[4]/a");
        public By aboutUsMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a");
        public By contactsMenuButtonXPath = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a");
        public By mapKyivButtonXPath = By.XPath("/html/body/div[1]/main/section/div/div[2]/div/a[1]/span[2]");
        public By PrivatePolicyButtonClassName = By.ClassName("ofooter-policy__link");

        private IWebDriver _driver;

        public MainPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        IWebElement mainLabel;
        IWebElement coursesLabel;
        IWebElement graduatesLabel;
        IWebElement newsLabel;
        IWebElement blogLabel;
        IWebElement aboutUsLabel;
        IWebElement contactsLabel;
        IWebElement mapDotKyivLabel;
        IWebElement privatePolicyLabel;


        public MainPageModel FindMainLabel()
        {
            mainLabel = _driver.FindElement(mainLabelTagName);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return mainLabel.Text;
        }
        public MainPageModel FindCoursesMenuButton()
        {
            coursesLabel = _driver.FindElement(courseMenuButtonXPath);
            return this;
        }
        public CoursesPageModel ClickOnCourseButton()
        {
            coursesLabel.Click();
            return new CoursesPageModel(_driver);
        }
        public MainPageModel FindGraduatesMenuButton()
        {
            graduatesLabel = _driver.FindElement(graduetesMenuButtonXPath);
            return this;
        }
        public GraduatesPageModel ClickOnGraduatesButton()
        {
            graduatesLabel.Click();
            return new GraduatesPageModel(_driver);
        }
        public MainPageModel FindNewsMenuButton()
        {
            newsLabel = _driver.FindElement(newsMenuButtonXPath);
            return this;
        }
        public NewsPageModel ClickOnNewsButton()
        {
            newsLabel.Click();
            return new NewsPageModel(_driver);
        }
        public MainPageModel FindBlogMenuButton()
        {
            blogLabel = _driver.FindElement(blogMenuButtonXPath);
            return this;
        }
        public BlogPageModel ClickOnBlogButton()
        {
            blogLabel.Click();
            return new BlogPageModel(_driver);
        }
        public MainPageModel FindAboutUsMenuButton()
        {
            aboutUsLabel = _driver.FindElement(aboutUsMenuButtonXPath);
            return this;
        }
        public AboutUsPageModel ClickOnAboutUsButton()
        {
            aboutUsLabel.Click();
            return new AboutUsPageModel(_driver);
        }
        public MainPageModel FindContactsMenuButton()
        {
            contactsLabel = _driver.FindElement(contactsMenuButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnContactsButton()
        {
            contactsLabel.Click();
            return new ContactsPageModel(_driver);
        }
        public MainPageModel FindMapDotKyivButton()
        {
            mapDotKyivLabel = _driver.FindElement(mapKyivButtonXPath);
            return this;
        }
        public KyivPageModel ClickOnKyivMapButton()
        {
            mapDotKyivLabel.Click();
            return new KyivPageModel(_driver);
        }
        public MainPageModel FindPrivatePolicyButton()
        {
            privatePolicyLabel = _driver.FindElement(PrivatePolicyButtonClassName);
            return this;
        }
        public PrivatePolicyPageModel ClickOnPrivatePolicyButton()
        {
            privatePolicyLabel.Click();
            return new PrivatePolicyPageModel(_driver);
        }
    }
}
