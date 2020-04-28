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
    public class ContactsPageTest:TestDriver
    {
        ContactsPageModel contactsPageModel;

        public ContactsPageTest()
        {
            contactsPageModel = new ContactsPageModel();
        }

        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.contactsPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(contactsPageModel.contactsLabelTag));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]
        public void CheckDneprLabel()
        {

            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();
            IWebElement dneprButton = driver.FindElement(By.XPath(contactsPageModel.dneprContactsButtonXPath));
            dneprButton.Click();
            IWebElement adressDnepr = driver.FindElement(By.XPath(contactsPageModel.dneprContactsAdressXPath));
            string actRes = adressDnepr.Text;
            Assert.AreEqual("ул.Симферопольская, 17", actRes);
        }
        [Test]
        public void CheckKyivLabel()
        {
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();
            IWebElement kyivButton = driver.FindElement(By.XPath(contactsPageModel.kyivContactsButtonXPath));
            kyivButton.Click();
            IWebElement adressKyiv = driver.FindElement(By.XPath(contactsPageModel.kyivContactsAdressXPath));
            string actRes = adressKyiv.Text;
            Assert.AreEqual("ст. метро Васильковская, ул. Сумская,1", actRes);
        }
        [Test]
        public void CheckBakuLabel()
        {
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();
            IWebElement bakuButton = driver.FindElement(By.XPath(contactsPageModel.bakuContactsButtonXPath));
            bakuButton.Click();
            IWebElement adressbaku = driver.FindElement(By.XPath(contactsPageModel.bakuContactsAdressXPath));
            string actRes = adressbaku.Text;
            Assert.AreEqual("проспект Бабека 10E, Rusel Plaza, 7 этаж", actRes);
        }
        [Test]
        public void CheckPetersburgLabel()
        {
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();
            IWebElement petersburgButton = driver.FindElement(By.XPath(contactsPageModel.petersburgContactsButtonXPath));
            petersburgButton.Click();
            IWebElement adressPetersburg = driver.FindElement(By.XPath(contactsPageModel.petersburgContactsAdressXPath));
            string actRes = adressPetersburg.Text;
            Assert.AreEqual("площадь Карла Фаберже, 8Б, офис 440\r\nБЦ Золотая Долина", actRes);
        }
        [Test]
        public void CheckKharkovLabel()
        {
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();
            IWebElement kharkovButton = driver.FindElement(By.XPath(contactsPageModel.kharkovContactsButtonXPath));
            kharkovButton.Click();
            IWebElement adressKharkov = driver.FindElement(By.XPath(contactsPageModel.kharkovContactsAdressXPath));
            string actRes = adressKharkov.Text;
            Assert.AreEqual("ул. Донец Захаржевского, 2,\r\nздание Сбербанка, этаж 5", actRes);
        }
    }
}
