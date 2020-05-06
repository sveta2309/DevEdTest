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
        [Test]

        public void CheckMainLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            
            string actRes = contactsPageModel.FindContactsLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]
        public void CheckDneprLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();

            string actRes = contactsPageModel.FindDneprContactsButton()
                .ClickOnDneprContactsButton()
                .FindDneprContactsAdress()
                .GetTextFromDneprContactsAdress();
            Assert.AreEqual("ул.Симферопольская, 17", actRes);
        }
        [Test]
        public void CheckKyivLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();

            string actRes = contactsPageModel.FindKyivContactsButton()
                .ClickOnKyivContactsButton()
                .FindkyivContactsAdress()
                .GetTextFromKyivContactsAdress();
            Assert.AreEqual("ст. метро Васильковская, ул. Сумская,1", actRes);
        }
        [Test]
        public void CheckBakuLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();

            string actRes = contactsPageModel.FindBakuContactsButton()
                .ClickOnBakuContactsButton()
                .FindBakuContactsAdress()
                .GetTextFromBakuContactsAdress();
            Assert.AreEqual("проспект Бабека 10E, Rusel Plaza, 7 этаж", actRes);
        }
        [Test]
        public void CheckPetersburgLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();

            string actRes = contactsPageModel.FindPetersburgContactsButton()
                .ClickOnPetersburgContactsButton()
                .FindPetersburgContactsAdress()
                .GetTextFromPetersburgContactsAdress();
            Assert.AreEqual("площадь Карла Фаберже, 8Б, офис 440\r\nБЦ Золотая Долина", actRes);
        }
        [Test]
        public void CheckKharkovLabel()
        {
            ContactsPageModel contactsPageModel = new ContactsPageModel(driver);
            base.driver.Url = Urls.contactsPage;
            driver.Manage().Window.Minimize();

            string actRes = contactsPageModel.FindKharkovContactsButton()
                .ClickOnKharkovContactsButton()
                .FindKharkovContactsAdress()
                .GetTextFromKharkovContactsAdress();
            Assert.AreEqual("ул. Донец Захаржевского, 2,\r\nздание Сбербанка, этаж 5", actRes);
        }
    }
}
