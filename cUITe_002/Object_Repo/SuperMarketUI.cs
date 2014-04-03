using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace cUITe_002.Object_Repo
{
    class SuperMarketUI
    {
        //returns "New installation" button
        public static HtmlInputButton btnNewInstalaltion(BrowserWindow browser)
        {
            HtmlInputButton inst = new HtmlInputButton(browser);
            inst.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0__ctl0_MarketTextButtonAutoId1_MarketTextButtonAutoId1");
            return inst;
        }

        //return "Professional license" button
        public static HtmlCustom btnProfLicense(BrowserWindow browser)
        {
            HtmlCustom btnprof = new HtmlCustom(browser);
            btnprof.SearchProperties.Add(HtmlCustom.PropertyNames.Id, "_ctl0__ctl0_TitleDescriptionButtonAutoId1_TitleDescriptionButtonAutoId1");
            return btnprof;
        }

        //returns stepbox - # of licenses

        public static HtmlEdit txtStepbox(BrowserWindow browser)
        {
            HtmlEdit stepbox = new HtmlEdit(browser);
            stepbox.SearchProperties.Add(HtmlEdit.PropertyNames.Name, "_ctl0:_ctl0:orderLines:_ctl3");
            return stepbox;
        }

        //returns discounting textbox

        public static HtmlEdit txtDiscount(BrowserWindow browser)
        {
            HtmlEdit discuont = new HtmlEdit(browser);
            discuont.SearchProperties.Add(HtmlEdit.PropertyNames.Class, "discount");
            return discuont;
        }

        //returns totalprocemonth

        public static HtmlCell totalPriceMonth(BrowserWindow browser)
        {
            HtmlCell tot = new HtmlCell(browser);
            tot.SearchProperties.Add(HtmlCell.PropertyNames.Class, "LineTotal");
            return tot;
        }

        //return "buy" button

        public static HtmlInputButton btnBuy(BrowserWindow browser)
        {
            HtmlInputButton buy = new HtmlInputButton(browser);
            buy.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0__ctl0_GoToConfigureButton_GoToConfigureButton");
            return buy;

        }

        //return language combobox
        public static HtmlComboBox comboLang(BrowserWindow browser)
        {
            HtmlComboBox lang=new HtmlComboBox(browser);
            lang.SearchProperties.Add(HtmlComboBox.PropertyNames.Id,"_ctl0__ctl0_SoDropDownListAutoId1_SoDropDownListAutoId1");
            return lang;

        }
        
        //return "Name" radio button
        public static HtmlRadioButton rdoName(BrowserWindow browser)
        {
            HtmlRadioButton radio = new HtmlRadioButton(browser);
            radio.SearchProperties.Add(HtmlRadioButton.PropertyNames.Id, "_ctl0__ctl0_createNew_createNew_actual");
            return radio;
        }

        //Mr/Ms
        public static HtmlEdit txtMrMs(BrowserWindow browser)
        {
            HtmlEdit mm = new HtmlEdit(browser);
            mm.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminMrMs_adminMrMs");
            return mm;
        }

        //first name
        public static HtmlEdit txtfname(BrowserWindow browser)
        {
            HtmlEdit fn = new HtmlEdit(browser);
            fn.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminFirstname_adminFirstname");
            return fn;
        }
        
        //middle name
        public static HtmlEdit txtmname(BrowserWindow browser)
        {
            HtmlEdit mn = new HtmlEdit(browser);
            mn.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminMiddlename_adminMiddlename");
            return mn;
        }

        //last name
        public static HtmlEdit txtlname(BrowserWindow browser)
        {
            HtmlEdit ln = new HtmlEdit(browser);
            ln.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminLastname_adminLastname");
            return ln;
        }

        //login name/email
        public static HtmlEdit txtemail(BrowserWindow browser)
        {

            HtmlEdit email = new HtmlEdit(browser);
            email.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminEmail_adminEmail");
            return email;
        }
        
        //userId
        public static HtmlEdit txtuserId(BrowserWindow browser)
        {

            HtmlEdit id = new HtmlEdit(browser);
            id.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_adminInitials_adminInitials");
            return id;
        }

        //input button next
        public static HtmlInputButton btnNext(BrowserWindow browser)
        {
            HtmlInputButton next = new HtmlInputButton(browser);
            next.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0__ctl0_GoToConfirmButton_GoToConfirmButton");
            return next;
        }

        //return total price
        public static HtmlCell totalPrice(BrowserWindow browser)
        {
            HtmlCell tot = new HtmlCell(browser);
            tot.SearchProperties.Add(HtmlCell.PropertyNames.Class, "LineTotal");
            return tot;
        }

        //return total including VAT

         public static HtmlCell totinclVat(BrowserWindow browser)
         {
            HtmlCell tvat = new HtmlCell(browser);
            tvat.SearchProperties.Add(HtmlCell.PropertyNames.Class, "Total");
            return tvat;
        }

        //return PO 
         public static HtmlEdit txtPO(BrowserWindow browser)
        {
            HtmlEdit po=new HtmlEdit(browser);
            po.SearchProperties.Add(HtmlEdit.PropertyNames.Id,"_ctl0__ctl0_poNumberText_poNumberText");
            return po;

        }

        //return comment
         public static HtmlTextArea txtComment(BrowserWindow browser)
         {
             HtmlTextArea com = new HtmlTextArea(browser);
             com.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, "_ctl0__ctl0_invoiceMessageText_invoiceMessageText");
             return com;
         }

        //email address accounting "add email" link click
         public static HtmlCustom lnkAddEmail(BrowserWindow browser)
         {
             HtmlCustom lnkAddEmai = new HtmlCustom(browser);
             lnkAddEmai.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "_ctl0__ctl0_accountPayableEmailRecipientList_accountPayableEmailRecipientList_addMore");
             lnkAddEmai.TechnologyName = "Web";
             return lnkAddEmai;
         }

        //return accounting email address field

        public static HtmlEdit txtaccountingEmail(BrowserWindow browser)
        {
            HtmlEdit txtaccountingEmai = new HtmlEdit(browser);
            txtaccountingEmai.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_txtAddAccountPayableAdditionalRecipients_txtAddAccountPayableAdditionalRecipients");
            return txtaccountingEmai;
         }

        //return OK button for accounting email

        public static HtmlInputButton btnaccOK(BrowserWindow browser)
        {
            HtmlInputButton btnaccO = new HtmlInputButton(browser);
            btnaccO.SearchProperties.Add(HtmlButton.PropertyNames.Id, "_ctl0__ctl0_btnAddAddAccountPayableAdditionalRecipients_btnAddAddAccountPayableAdditionalRecipients");
            return btnaccO;
        }


        //return email address for send documents
        public static HtmlCustom lnkAddadditionalEmail(BrowserWindow browser)
        {

            HtmlCustom lnkAddadditionalEmai = new HtmlCustom(browser);
           lnkAddadditionalEmai.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, "_ctl0__ctl0_emailRecipientList_emailRecipientList_addMore");
           lnkAddadditionalEmai.TechnologyName = "Web";
           return lnkAddadditionalEmai;
         }

        //retun additional email textbox

        public static HtmlEdit txtsendDocEmail(BrowserWindow browser)
        {
            HtmlEdit txtsendDocEmai = new HtmlEdit(browser);
           txtsendDocEmai.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "_ctl0__ctl0_txtAdditionalRecipients_txtAdditionalRecipients");
           return txtsendDocEmai;
    }

        //return OK button for additional email

        public static HtmlInputButton btnSendDocOK(BrowserWindow browser)
        {
            HtmlInputButton btnSendDocO = new HtmlInputButton(browser);
           btnSendDocO.SearchProperties.Add(HtmlButton.PropertyNames.Id, "_ctl0__ctl0_btnAddAdditionalRecipients_btnAddAdditionalRecipients");
           return btnSendDocO;
         }


        // return "Confirm" checkbox

        public static HtmlHyperlink chkConfirm(BrowserWindow browser)

        {
            HtmlHyperlink chkConfir = new HtmlHyperlink(browser);
           chkConfir.SearchProperties.Add(HtmlHyperlink.PropertyNames.Class, "styledCheckbox unchecked");
           return chkConfir;
         }


        //return confirm button

        public static HtmlInputButton btnconfirm(BrowserWindow browser)

        {
            HtmlInputButton btnconfir = new HtmlInputButton(browser);
           btnconfir.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, "_ctl0__ctl0_GoToNextButton_Confirm_GoToNextButton_Confirm");
           return btnconfir;
    }

        //assert successful order confirmation

        public static string lblSuccess= "The order confirmation has been sent to the customer and a copy has been stored in SuperOffice.";

        public static HtmlDiv divSuccess(BrowserWindow browser)
        {
            HtmlDiv success = new HtmlDiv(browser);
            success.SearchProperties.Add(HtmlDiv.PropertyNames.Id, "_ctl0__ctl0_SoGenericLabelAutoId5__label");
            return success;
        }

        // return company name in SM to be used in assert

        public static HtmlSpan spncompanyname(BrowserWindow browser)
        {
            HtmlSpan com = new HtmlSpan(browser);
            com.SearchProperties.Add(HtmlSpan.PropertyNames.Id, "_ctl0__ctl0_companyName__label");
            return com;

        }

                
    }
}
