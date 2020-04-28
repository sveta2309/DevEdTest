using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTest.POM
{
    public class ContactsPageModel
    {
        public string contactsLabelTag = "h1";

        public string dneprContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[1]";
        public string kyivContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[2]";
        public string bakuContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[3]";
        public string petersburgContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[4]";
        public string kharkovContactsButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[5]";

        public string dneprContactsAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[1]";
        public string kyivContactsAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]";
        public string bakuContactsAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[3]/div[1]/div[2]/div[1]";
        public string petersburgContactsAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[4]/div[1]/div[2]/div[1]";
        public string kharkovContactsAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[5]/div[1]/div[2]/div[1]";
    }
}
