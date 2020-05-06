using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class CoursesPageModel
    {
        public By ourCoursesLabelTag = By.TagName("h1");
        public By contactUsXPath = By.XPath("/html/body/div[1]/main/section[3]/div/button");
        public By contactUsInputName = By.XPath("/html/body/div[1]/main/div[4]/div/div/form/div[1]/input");
        public By contactUsInputEMailXPath = By.XPath("/html/body/div[1]/main/div[4]/div/div/form/div[2]/input");
        public By contactUsInputMessageName = By.XPath("/html/body/div[1]/main/div[4]/div/div/form/div[3]/textarea");
        public By contactUsSendButtonXPath = By.XPath("/html/body/div[1]/main/div[4]/div/div/form/div[4]/button");
        public By contactUsMessageSendXPath = By.XPath("/html/body/div[1]/main/div[7]/div/div/div");


        public By cityKiyvXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div/ul/li[2]/a/div");
        public By bookkeepingKiyvXPath = By.XPath("/ html/body/div[1]/main/section[1]/div/div/ul/li[2]/ul/li[1]/a/span[1]");

        IWebElement coursesLabel;
        IWebElement kyivCityLabel;
        IWebElement kyivBookkeepingLabel;
        IWebElement contactUsButton;
        IWebElement nameField;
        IWebElement emailField;
        IWebElement messageField;
        IWebElement sendButton;
       
        private IWebDriver _driver;

        public CoursesPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public CoursesPageModel FindCoursesLabel()
        {
            coursesLabel = _driver.FindElement(ourCoursesLabelTag);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return coursesLabel.Text;
        }
        public CoursesPageModel FindKyivCityButton()
        {
            kyivCityLabel = _driver.FindElement(cityKiyvXPath);
            return this;
        }
        public KyivPageModel ClickOnKyivCityButton()
        {
            kyivCityLabel.Click();
            return new KyivPageModel(_driver);
        }
        public CoursesPageModel FindKyivBookkeepingButton()
        {
            kyivBookkeepingLabel = _driver.FindElement(bookkeepingKiyvXPath);
            return this;
        }
        public KyivBookkeepingPageModel ClickOnKyivBookkeepingButton()
        {
            kyivBookkeepingLabel.Click();
            return new KyivBookkeepingPageModel(_driver);
        }
        public CoursesPageModel FindContactUsButton()
        {
            contactUsButton = _driver.FindElement(contactUsXPath);
            return this;

        }
        public CoursesPageModel ClickOnContactUsButton()
        {
            contactUsButton.Click();
            return this;
        }
        public CoursesPageModel FindNameField()
        {
            nameField = _driver.FindElement(contactUsInputName);
            return this;
        }
        public CoursesPageModel SendName()
        {
            nameField.SendKeys("test");
            return this;
        }
        public CoursesPageModel FindEmailField()
        {
            emailField = _driver.FindElement(contactUsInputEMailXPath);
            return this;
        }
        public CoursesPageModel SendEMail()
        {
            emailField.SendKeys("test@i.ua");
            return this;
        }
        public CoursesPageModel FindMessageField()
        {
            messageField = _driver.FindElement(contactUsInputMessageName);
            return this;
        }
        public CoursesPageModel SendMessage()
        {
            messageField.SendKeys("test");
            return this;
        }
        public CoursesPageModel FindSendButton()
        {
            sendButton = _driver.FindElement(contactUsSendButtonXPath);
            return this;
        }
        public CoursesPageModel ClickOnSendButton()
        {
            sendButton.Click();
            return this;
        }
        public IWebElement FindPopUpMessage()
        {
            return  _driver.FindElement(contactUsMessageSendXPath);
           
        }
    }
}
