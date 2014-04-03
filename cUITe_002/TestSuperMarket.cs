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
using cUITe_002.Object_Repo;

namespace cUITe_002
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
        BrowserWindow SMpage;
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
                    Assert.Fail("Login failed. Incorrect username or password...");
                    Image pic = this.SOpage.CaptureImage();
                    pic.Save("E:\\GitHub\\CUITests\\CUITests_Local\\screenshots\\file.bmp");
                    TestContext.AddResultFile("E:\\GitHub\\CUITests\\CUITests_Local\\TestResults\\file.bmp");
                }

                     
                // BrowserWindow.Locate("Invitations - Windows Internet Explorer provided by SuperOffice").Close();
                   

                //else if (BrowserWindow.CurrentBrowser == "chrome")
                //{
                //BrowserWindow.Locate("Invitations - Google Chrome").Close();
                //}

                //else if (BrowserWindow.CurrentBrowser == "firefox")
                //{
                //BrowserWindow.Locate("Invitations - Mozilla Firefox").Close();
                //}

                //launch SUperMarket
                System.Threading.Thread.Sleep(config.Default.SleepTime);                       
                Mouse.Click(SuperOfficeUI.lnkTools(SOpage));
                SuperOfficeUI.spnsupermarket(SOpage).WaitForControlExist();
                Mouse.Click(SuperOfficeUI.spnsupermarket(SOpage));
                     
                //Locate the Supermarket browser window. 
                SMpage = BrowserWindow.Locate("SuperOffice SuperMarket");
                
                //assert whether Company name in both SO and SM are equal
                try
                {
                    SuperMarketUI.spncompanyname(SMpage).WaitForControlExist();
                    Assert.AreEqual(SuperOfficeUI.txtcompanyname(SOpage).Text, SuperMarketUI.spncompanyname(SMpage).InnerText);
                }
                catch (AssertFailedException e)
                {
                    Assert.Fail("Incorrect company in SuperMarket...");
                    Console.WriteLine(e.Message);
                }


                //Click "New Installation" to proceed to buy license wizard 
                SuperMarketUI.btnNewInstalaltion(SMpage).WaitForControlExist();     
                Mouse.Click(SuperMarketUI.btnNewInstalaltion(SMpage));

                //Click on "Professional license" button
                SuperMarketUI.btnProfLicense(SMpage).WaitForControlExist();
                Mouse.Click(SuperMarketUI.btnProfLicense(SMpage));

                // Add number of licenses in numeric value 
                SuperMarketUI.txtStepbox(SMpage).WaitForControlExist();
                SuperMarketUI.txtStepbox(SMpage).Text = "2";
                Mouse.Click(SuperMarketUI.txtDiscount(SMpage));

                //assert that the license number and the price value tally
                try
                {
                    Assert.AreEqual("NOK 790.01", SuperMarketUI.totalPriceMonth(SMpage).InnerText);

                }

                catch (AssertFailedException e)
                {
                    Console.WriteLine(e.Message);
                }


                //click buy button
                Mouse.Click(SuperMarketUI.btnBuy(SMpage));

                // ******************setup installation************
               
                //select language
                SuperMarketUI.comboLang(SMpage).WaitForControlExist();
                SuperMarketUI.comboLang(SMpage).SelectedItem = "English";

                //select name radio button

                Mouse.Click(SuperMarketUI.rdoName(SMpage));

                //add new name

                SuperMarketUI.txtMrMs(SMpage).Text = "Mr";
                SuperMarketUI.txtfname(SMpage).Text = "Kapila";
                SuperMarketUI.txtmname(SMpage).Text = "Kumara";
                SuperMarketUI.txtlname(SMpage).Text = "Kalinga";

                SuperMarketUI.txtemail(SMpage).Text = "Kapila@yahuu.com";


                //assert whether "KKK" appears in userID field
                try
                {
                    Assert.AreEqual("KKK", SuperMarketUI.txtuserId(SMpage).Text);
                }
                catch (AssertFailedException e)
                {
                    Console.WriteLine(e.Message);
                }


                Mouse.Click(SuperMarketUI.txtuserId(SMpage));

                Mouse.Click(SuperMarketUI.btnNext(SMpage));
               
                //assert total licenses prices
                try
                {
                    SuperMarketUI.totalPrice(SMpage).WaitForControlExist();
                    Assert.AreEqual("NOK 2,370.00", SuperMarketUI.totalPrice(SMpage).InnerText);
                    Assert.AreEqual("NOK 6,370.01", SuperMarketUI.totinclVat(SMpage).InnerText);
                }
                catch (AssertFailedException e)
                {
                    Console.WriteLine(e.Message);
                }

                SuperMarketUI.txtPO(SMpage).Text = "PO 1000000";
                SuperMarketUI.txtComment(SMpage).Text = "Test comment to purchase this licnese in Purchase order";
                
            //assert confirm button is diabled before entering email addresses

                try
                {
                    Assert.IsTrue(!SuperMarketUI.btnconfirm(SMpage).Enabled);
                }

            catch(AssertFailedException e)
                {
                    Console.WriteLine("Confirm button was enabled where it shoudn't be...");
                }


                //settign email for accounting for field

                Mouse.Click(SuperMarketUI.lnkAddEmail(SMpage));
                SuperMarketUI.txtaccountingEmail(SMpage).Text = TestContext.DataRow["emailAddresses"].ToString(); ;
                Mouse.Click(SuperMarketUI.btnaccOK(SMpage));

                //setting email to send documents field

                Mouse.Click(SuperMarketUI.lnkAddadditionalEmail(SMpage));
                SuperMarketUI.txtsendDocEmail(SMpage).Text = TestContext.DataRow["emailAddresses"].ToString(); ;
                Mouse.Click(SuperMarketUI.btnSendDocOK(SMpage));

                  

                
                // click the check box "Confirm"
                Mouse.Click(SuperMarketUI.chkConfirm(SMpage));

              //assert "confirm" button is enabled by now...

                try
                {
                    Assert.IsTrue(SuperMarketUI.btnconfirm(SMpage).Enabled);
                }

            catch(AssertFailedException e)
                {
                    Console.WriteLine("Confirm button was disabled where it shoudn't be...");
                }

                //confirm the order        

                Mouse.Click(SuperMarketUI.btnconfirm(SMpage));
                              
                //assert whether the order is successful
                try
                {
                    SuperMarketUI.divSuccess(SMpage).WaitForControlExist();
                    Assert.AreEqual(SuperMarketUI.lblSuccess, SuperMarketUI.divSuccess(SMpage).InnerText);
                }

                catch (AssertFailedException e)
                {
                    Console.WriteLine(e.Message);
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
            SMpage.CloseOnPlaybackCleanup = true;
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
