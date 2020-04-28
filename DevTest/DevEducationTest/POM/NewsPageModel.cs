using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class NewsPageModel
    {
        public string newsLabelTag = "h1";
        public string firstNewsXPath = "/html/body/div[1]/main/div/div/div[1]/div/ul/li[1]/figure/figcaption/h3/a";
        public string firstNewsTitleXPath = "/html/body/div[1]/main/section/div/div/div/p[1]/span/strong";
    }
}
