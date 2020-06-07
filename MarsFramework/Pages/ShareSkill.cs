using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using MarsFramework.Global;
using System.Threading;
using System.Collections.Generic;
using System;
using AutoIt;
using NUnit.Framework;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        [System.Obsolete]
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }

        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }

        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }
        
        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        [Obsolete]
        internal void EnterShareSkill()
        {
            //Extension custom method
            //Click on Share skill Tab
            ShareSkillButton.Clicks();
            Title.EnterText("SeleniumQA");

            Description.EnterText("Would you like to provide Testing Training");

            //Select dropbox
            CategoryDropDown.SelectFromDDL("Programming & Tech");
            SubCategoryDropDown.SelectFromDDL("QA");

            //Enter value in tag 
            Tags.EnterText("Tag11");
            //Enter Key
            Tags.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            //check Tag entered
            Assert.IsNotNull(Tags, "Test fail- Tag Empty");

            //Enter Service Type
             GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='serviceType'][@type='radio'][@value='1']")).Clicks();
            //Enter Location Type
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='locationType'][@value='0']")).Clicks();

            //Enter Start date
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='startDate']")).EnterText("01072020");

            //Enter End Date
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='endDate']")).EnterText("19072020");


            //select the days and time
            GlobalDefinitions.driver.FindElement(By.XPath("//inpu" +
                "t[@tabindex='0'][@index='0'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[1]")).EnterText("08:30AM");
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[1]")).EnterText("04:30PM");

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='1'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[2]")).EnterText("08:30AM");
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[2]")).EnterText("04:30PM");

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='2'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[3]")).EnterText("08:30AM");
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[3]")).EnterText("04:30PM");

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='3'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[4]")).EnterText("08:30AM");
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[4]")).EnterText("04:30PM");

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='4'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[5]")).EnterText("08:30AM");
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[5]")).EnterText("04:30PM");

            //GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='5'][@name='Available']")).Clicks();
            //GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[6]")).EnterText("08:30AM");
            //GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[6]")).EnterText("04:30PM");

            //GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='6'][@name='Available']")).Clicks();
            //GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[7]")).EnterText("08:30AM");
            //GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[7]")).EnterText("04:30PM");





            //Enter Skill Trade
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='skillTrades'][@tabindex='0'][@value='false']")).Clicks();
            // Screenshot
          

            //hidden credit
            //GlobalDefinitions.driver.FindElement(By.XPath("GlobalDefinitions.driver.FindElement(By.XPath")).EnterText("9");



            //Work Smaple using SenkKey
            IWebElement ws = GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            ws.Clicks();
            //using AutoIT upload file
            AutoItX.WinWaitActive("Open");
            AutoItX.Send(@"C:\Project Mars\languageAddValid.txt");
            AutoItX.Sleep(5);
            AutoItX.Send("{ENTER}");
            
            
            try
            {
                IWebElement file = GlobalDefinitions.driver.FindElement(By.XPath("//span[@class='tooltiptext']"));
                Assert.That(file.Text != null, "File uploaded Fail");
            }
            catch (NoSuchElementException)
            {
                Assert.Fail("File uploaded fail");
            }


            //Click Hiddden Bullet
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='isActive'][@value='false']")).Clicks();
            Thread.Sleep(2000);
            //Save Button
            Save.Clicks();
                       

        }

        [Obsolete]
        internal void EditShareSkill(string title,string desc,string cat, string subCat,string tag,string serviceType,
            string locType,string Sdate,string Edate,string StartTime,string EndTime, string Skilltrade,
            string SkillExchangeTag,string credit,string active)
        {


            
            Title.EnterText(title);

            Description.EnterText(desc);

            //Select dropbox
            CategoryDropDown.SelectFromDDL(cat);
            SubCategoryDropDown.SelectFromDDL(subCat);

            //Enter value in tag 
            Tags.EnterText(tag);
            //Enter Key
            Tags.SendKeys(Keys.Enter);

            //check Tag entered
            Assert.IsNotNull(Tags, "Test fail- Tag Emplty");

            //Enter Service Type
            if (serviceType == "Hourly basis service")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//label[contains(.,'Hourly basis service')]")).Clicks();
            }
            else if (serviceType == "One-off service")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='serviceType'][@type='radio'][@value='1']")).Clicks();
            }

            //Enter Location Type
            if (locType == "On-site")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='locationType'][@value='0']")).Clicks();
            }
            else if (locType == "Online")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@name,'locationType')])[1]")).Clicks();
            }
            //Enter Start date
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='startDate']")).EnterText(Sdate);

            //Enter End Date
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='endDate']")).EnterText(Edate);


            //select the days and time
            GlobalDefinitions.driver.FindElement(By.XPath("//inpu" +
                "t[@tabindex='0'][@index='0'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[1]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[1]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='1'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[2]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[2]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='2'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[3]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[3]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='3'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[4]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[4]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='4'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[5]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[5]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='5'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[6]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[6]")).EnterText(EndTime);

            GlobalDefinitions.driver.FindElement(By.XPath("//input[@tabindex='0'][@index='6'][@name='Available']")).Clicks();
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='StartTime'])[7]")).EnterText(StartTime);
            GlobalDefinitions.driver.FindElement(By.XPath("(//input[@name='EndTime'])[7]")).EnterText(EndTime);

            //Enter Skill Trade
            if (Skilltrade == "Skill-Exchange")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//label[contains(.,'Skill-exchange')]")).Clicks();
            }
            else if (Skilltrade == "Credit")
            {
                GlobalDefinitions.driver.FindElement(By.XPath("//label[contains(.,'Credit')]")).Clicks();
            }

            //Enter Skill Exchage Tag
            SkillExchange.EnterText(SkillExchangeTag);
            SkillExchange.SendKeys(Keys.Enter);

            //Check Tag entered
             Assert.IsNotNull(SkillExchange, "Test fail- SkillExchange Tag is Emplty");



            //hidden credit
            //GlobalDefinitions.driver.FindElement(By.XPath("GlobalDefinitions.driver.FindElement(By.XPath")).EnterText("9");


            //Work Smaple using SenkKey
            IWebElement ws =GlobalDefinitions.driver.FindElement(By.XPath("//i[@class='huge plus circle icon padding-25']"));
            ws.Clicks();
            //using AutoIT upload file
            AutoItX.WinWaitActive("Open");
            AutoItX.Send(@"C:\Project Mars\languageAddValid.txt");
            AutoItX.Sleep(5);
            AutoItX.Send("{ENTER}");

            //check file is upload or not

            //IWebElement file = GlobalDefinitions.driver.FindElement(By.XPath("//span[@class='tooltiptext']"));
            //Assert.That(file.Text != null, "File uploaded Fail");
            try
            {
               IWebElement file =GlobalDefinitions.driver.FindElement(By.XPath("//span[@class='tooltiptext']"));
               Assert.That(file.Text != null, "File uploaded Fail");
            }
            catch(NoSuchElementException)
            {
                Assert.Fail("File Uploaded Fail");
            }                 
                
                       

            //Click Hiddden Bullet
            if (active == "Active")
                GlobalDefinitions.driver.FindElement(By.XPath("//input[@name='isActive'][@value='false']")).Clicks();
            else
                GlobalDefinitions.driver.FindElement(By.XPath("(//input[contains(@name,'isActive')])[2]")).Clicks();

            //Save Button
            Save.Clicks();
            Thread.Sleep(3000);

                       

        }
    }
}
