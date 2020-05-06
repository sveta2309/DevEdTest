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
        [Test]

        public void CheckMainLabel()
        {
            GraduatesPageModel graduatesPageModel = new GraduatesPageModel(driver);
            base.driver.Url = Urls.graduatesPage;
            string actRes = graduatesPageModel.FindGraduatesLabel()
                                         .GetTextFromMainLabel();
            Assert.AreEqual("Наши выпускники", actRes);
        }
    }
}
