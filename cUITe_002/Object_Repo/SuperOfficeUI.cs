using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;


namespace Superoffice.Object_Repo
{
    class SuperOfficeUI
    {

        //retrieve username
        public static HtmlEdit username(BrowserWindow browser)
        {
            HtmlEdit txtusername = new HtmlEdit(browser);
            txtusername.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_UserName");
            return txtusername;
        }

        //retrieve password
        public static HtmlEdit password(BrowserWindow browser)
        {

            HtmlEdit txtpassword = new HtmlEdit(browser);
            txtpassword.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_Password");
            return txtpassword;   
        }

        //login button
        public static HtmlInputButton login(BrowserWindow browser)
        {

            HtmlInputButton btnLogin = new HtmlInputButton(browser);
            btnLogin.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_LoginBtn");
            return btnLogin;
        }

        //company link in navigator panel
        public static HtmlHyperlink lnkCompany(BrowserWindow browser)
        {
            HtmlHyperlink linkcompany=new HtmlHyperlink(browser);
            linkcompany.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id,"contactButton_hyperlinkText");
            return linkcompany;

        }


        //launch supermarekt


        public static HtmlHyperlink lnkTools(BrowserWindow browser)
        {
            HtmlHyperlink linktools = new HtmlHyperlink(browser);
            linktools.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id,"toolboxButton_hyperlinkText");
            return linktools;
        }


        public static HtmlSpan spnsupermarket(BrowserWindow browser)
        {
            HtmlSpan spansupermarket = new HtmlSpan(browser);
            spansupermarket.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText,"SuperMarket");
            spansupermarket.SearchProperties.Add(HtmlSpan.PropertyNames.Class,"name");
            return spansupermarket;
        }


        // return company name in SO to be used in assert
        public static HtmlEdit txtcompanyname(BrowserWindow browser)
        {
            HtmlEdit company = new HtmlEdit(browser);
            company.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_WebClientPlaceHolder__Splitter_MainHeaderGroup_MainHeading_textfield_MainHeaderGroup_MainHeading_textfield");
            return company;
        }


    }
}
