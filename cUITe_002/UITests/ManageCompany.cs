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
using Superoffice.Object_Repo;

namespace Superoffice
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestSuperMarket
    {
        public TestSuperMarket()
        {
        }
        BrowserWindow SOpage;
        
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\Users\\tharindal\\SkyDrive\\CodedUI_Projects\\Test\\cUITe\\cUITe_002\\cUITe_002\\cUITe_002\\Resources\\Browsers.csv", "Browsers#csv", DataAccessMethod.Sequential), DeploymentItem("Browsers.csv")]
       

        [TestMethod]
        
        public void BuyNewProfLicense()
        {
            

                //Select browser type
               //BrowserWindow.CurrentBrowser = TestContext.DataRow["Browser"].ToString();
              // BrowserWindow.CurrentBrowser = "firefox";
              
            //Launch SO web
                SOpage = BrowserWindow.Launch(new Uri(config.Default.URL));
                

                //Login with credentials 
                SuperOfficeUI.username(SOpage).WaitForControlExist();
                SuperOfficeUI.username(SOpage).Text = config.Default.username;
                SuperOfficeUI.password(SOpage).Text = config.Default.password;
                Mouse.Click(SuperOfficeUI.login(SOpage));
                
                //Assert user lands Defauls.aspx page

                try
                {
                    SuperOfficeUI.lnkCompany(SOpage).WaitForControlExist();
                    Assert.AreEqual("Company", SuperOfficeUI.lnkCompany(SOpage).InnerText);
                }
                catch (Exception e)
                {
                    Image pic = this.SOpage.CaptureImage();
                    pic.Save(config.Default.errordumppath);
                    TestContext.AddResultFile(config.Default.resultfilepath);
                    Assert.Fail("Login failed. Incorrect username or password.....OR" + e);
                }
                            
                
                       
        }

        #region Additional test attributes

        

        ////Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Console.WriteLine("UI Test started at: " + DateTime.Now);
            
        }

        ////Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            SOpage.CloseOnPlaybackCleanup = true;
          
            Console.WriteLine("UI Test ended at: " + DateTime.Now);
        }

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
