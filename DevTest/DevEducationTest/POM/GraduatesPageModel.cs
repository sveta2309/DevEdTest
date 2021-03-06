﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class GraduatesPageModel
    {
        private IWebDriver _driver;

        public GraduatesPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public By ourGraduatesLabelXPath = By.XPath("/html/body/div[1]/main/section[1]/div/div/h1");



        IWebElement graduatesLabel;

        public GraduatesPageModel FindGraduatesLabel()
        {
            graduatesLabel = _driver.FindElement(ourGraduatesLabelXPath);
            return this;
        }
        public string GetTextFromMainLabel()
        {
            return graduatesLabel.Text;
        }

    }
}
