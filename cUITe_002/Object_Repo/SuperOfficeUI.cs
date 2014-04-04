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

        public static BrowserWindow browser { get; set; }
  
        //retrieve username
        public static HtmlEdit Username
        {
            get {
                HtmlEdit txtusername = new HtmlEdit(browser);
                txtusername.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_UserName");
                return txtusername;
            }
        }
          
          
        //retrieve password
        public static HtmlEdit password
        {
            get{
            HtmlEdit txtpassword = new HtmlEdit(browser);
            txtpassword.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_Password");
            return txtpassword;
            }
        }


        //login button
        public static HtmlInputButton login
        {
            get{
            HtmlInputButton btnLogin = new HtmlInputButton(browser);
            btnLogin.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0_LoginPlaceHolder_soLogin_LoginBtn");
            return btnLogin;
            }
        }

        //company Link in navigator panel
        public static HtmlHyperlink lnkCompany
        {
            get{
            HtmlHyperlink linkcompany=new HtmlHyperlink(browser);
            linkcompany.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id,"contactButton_hyperlinkText");
            return linkcompany;
            }
        }


        //Create Company Link

        public static HtmlHyperlink lnknewCompany
        {
            get
            {
                HtmlHyperlink company = new HtmlHyperlink(browser);
                company.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "ToolBarNew_10_hyperlinkText");
                return company;

            }}

        //search and enter  country for company
            public static HtmlEdit countrylist
            {
                get{

                 HtmlEdit c_list = new HtmlEdit(browser);
                c_list.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0__Splitter_maingroup__ContactCountryMDO__ctl0__ctl0__Splitter_maingroup__ContactCountryMDO_SearchBox__ctl0__ctl0__Splitter_maingroup__ContactCountryMDO_SearchBox");
                return c_list;
                }

            }

            
              
        // return company name in SO to be used in assert
        public static HtmlEdit txtcompanyname
        {
            get
            {
                HtmlEdit company = new HtmlEdit(browser);
                company.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0_WebClientPlaceHolder__Splitter_MainHeaderGroup_MainHeading_textfield_MainHeaderGroup_MainHeading_textfield");
                return company;
            }
        }


    }
}
