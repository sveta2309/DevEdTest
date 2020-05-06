using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class ContactsPageModel
    {
        private IWebDriver _driver;

        public ContactsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By contactsLabelTag = By.TagName("h1");

        public By dneprContactsButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[1]");
        public By kyivContactsButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[2]");
        public By bakuContactsButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[3]");
        public By petersburgContactsButtonXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[4]");
        public By kharkovContactsButtonXPath = By.XPath( "/html/body/div[1]/main/section[1]/div/div[1]/button[5]");

        public By dneprContactsAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[1]");
        public By kyivContactsAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]");
        public By bakuContactsAdressXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[3]/div[1]/div[2]/div[1]");
        public By petersburgContactsAdressXPath = By.XPath ("/html/body/div[1]/main/section[1]/div/div[2]/div[4]/div[1]/div[2]/div[1]");
        public By kharkovContactsAdressXPath = By.XPath ("/html/body/div[1]/main/section[1]/div/div[2]/div[5]/div[1]/div[2]/div[1]");


        IWebElement contactsLabel;

        IWebElement dneprContactsButton;
        IWebElement dneprContactsAdress;

        IWebElement kyivContactsButton;
        IWebElement kyivContactsAdress;

        IWebElement bakuContactsButton;
        IWebElement bakuContactsAdress;

        IWebElement petersburgContactsButton;
        IWebElement petersburgContactsAdress;

        IWebElement kharkovContactsButton;
        IWebElement kharkovContactsAdress;
        public ContactsPageModel FindContactsLabel()
        {
            contactsLabel = _driver.FindElement(contactsLabelTag);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return contactsLabel.Text;
        }




        public ContactsPageModel FindDneprContactsButton()
        {
            dneprContactsButton = _driver.FindElement(dneprContactsButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnDneprContactsButton()
        {
            dneprContactsButton.Click();
            return this;
        }
        public ContactsPageModel FindDneprContactsAdress()
        {
            dneprContactsAdress = _driver.FindElement(dneprContactsAdressXPath);
            return this;
        }
        public string GetTextFromDneprContactsAdress()
        {
            return dneprContactsAdress.Text;
        }
        public ContactsPageModel FindKyivContactsButton()
        {
            kyivContactsButton = _driver.FindElement(kyivContactsButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnKyivContactsButton()
        {
            kyivContactsButton.Click();
            return this;
        }
        public ContactsPageModel FindkyivContactsAdress()
        {
            kyivContactsAdress = _driver.FindElement(kyivContactsAdressXPath);
            return this;
        }
        public string GetTextFromKyivContactsAdress()
        {
            return kyivContactsAdress.Text;
        }
        public ContactsPageModel FindBakuContactsButton()
        {
            bakuContactsButton = _driver.FindElement(bakuContactsButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnBakuContactsButton()
        {
            bakuContactsButton.Click();
            return this;
        }
        public ContactsPageModel FindBakuContactsAdress()
        {
            bakuContactsAdress = _driver.FindElement(bakuContactsAdressXPath);
            return this;
        }
        public string GetTextFromBakuContactsAdress()
        {
            return bakuContactsAdress.Text;
        }
        public ContactsPageModel FindPetersburgContactsButton()
        {
            petersburgContactsButton = _driver.FindElement(petersburgContactsButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnPetersburgContactsButton()
        {
            petersburgContactsButton.Click();
            return this;
        }
        public ContactsPageModel FindPetersburgContactsAdress()
        {
            petersburgContactsAdress = _driver.FindElement(petersburgContactsAdressXPath);
            return this;
        }
        public string GetTextFromPetersburgContactsAdress()
        {
            return petersburgContactsAdress.Text;
        }
        public ContactsPageModel FindKharkovContactsButton()
        {
            kharkovContactsButton = _driver.FindElement(kharkovContactsButtonXPath);
            return this;
        }
        public ContactsPageModel ClickOnKharkovContactsButton()
        {
            kharkovContactsButton.Click();
            return this;
        }
        public ContactsPageModel FindKharkovContactsAdress()
        {
            kharkovContactsAdress = _driver.FindElement(kharkovContactsAdressXPath);
            return this;
        }
        public string GetTextFromKharkovContactsAdress()
        {
            return kharkovContactsAdress.Text;
        }
    }
}
