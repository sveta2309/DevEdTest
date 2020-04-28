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
        public string mainLabelTagName = "h1";
        public string courseMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduetesMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a";
        public string newsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[3]/a";
        public string blogMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[4]/a";
        public string aboutUsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a";
        public string contactsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a";
        public string mapKyivButtonXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[1]/span[2]";
        public string PrivatePolicyButtonClassName = "ofooter-policy__link";

       
    }
}
