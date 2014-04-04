using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.PlaybackSettings;
using Superoffice.Object_Repo;

namespace Superoffice
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class ManageCompany
    {
        [TestMethod]
        public void CreateCompany()
        {
            //Select browser type
            //BrowserWindow.CurrentBrowser = TestContext.DataRow["Browser"].ToString();
            // BrowserWindow.CurrentBrowser = "firefox";



            SuperOfficeUI.browser = BrowserWindow.Launch(new Uri(config.Default.URL));  
            
            //Login with credentials 
            SuperOfficeUI.Username.WaitForControlExist();
            SuperOfficeUI.Username.Text = config.Default.username;
            SuperOfficeUI.password.Text = config.Default.password;
            Mouse.Click(SuperOfficeUI.login);

            //Assert user lands Defauls.aspx page

            try
            {
                SuperOfficeUI.lnkCompany.WaitForControlExist();
                Assert.AreEqual("Company", SuperOfficeUI.lnkCompany.InnerText);
            }
            catch (Exception e)
            {

                Image pic = SuperOfficeUI.browser.CaptureImage();
                pic.Save(config.Default.errordumppath);
                TestContext.AddResultFile(config.Default.resultfilepath);
                Assert.Fail("Login failed. Incorrect username or password..." + e);
            }


            //create a company

            Mouse.Click(SuperOfficeUI.lnknewCompany);


            SuperOfficeUI.countrylist.Text = "Sri Lanka";
            Mouse.Click(SuperOfficeUI.lnknewCompany);
            SuperOfficeUI.countrylist.SetFocus();


        }

        #region Additional test attributes

        

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("UI Test started at: " + DateTime.Now);
            
        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //    SuperOfficeUI.browser.CloseOnPlaybackCleanup = false;
        //    Console.WriteLine("UI Test ended at: " + DateTime.Now);
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
