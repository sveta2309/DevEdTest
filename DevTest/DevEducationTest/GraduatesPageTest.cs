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
    public class GraduatesPageTest : TestDriver
    {
        GraduatesPageModel graduatesPageModel;

        public GraduatesPageTest()
        {
            graduatesPageModel = new GraduatesPageModel();
        }


        [Test]

        public void CheckMainLabel()
        {
            base.driver.Url = Urls.graduatesPage;
            IWebElement mainLabel = driver.FindElement(By.XPath(graduatesPageModel.ourGraduatesLabelXPath));
            string actRes = mainLabel.Text;
            Assert.AreEqual("Наши выпускники", actRes);
        }
    }
}
