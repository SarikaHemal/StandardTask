using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {
        [System.Obsolete]
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Availability Edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[1]")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour Edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[2]")]
        private IWebElement AvailabilityHoursEdit { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.CssSelector, Using = "select.ui.right.labeled.dropdown")]
        private IWebElement AvailabilityHoursOpt { get; set; }


        //Click on salary
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement Salary { get; set; }

        //Click on EarnTarget Edit button
        [FindsBy(How = How.XPath, Using = "(//i[@class='right floated outline small write icon'])[3]")]
        private IWebElement EarnTargetEdit { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }


        //Language tab 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        private IWebElement LangTab { get; set; }

        //Click on Add new to button in language
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '][contains(.,'Add New')])[1]")]
        private IWebElement AddNewLangBtn { get; set; }

        //Enter the Language on text box
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Add Language')]")]
        private IWebElement AddLangText { get; set; }

        //Select the Language level from dropbox
        [FindsBy(How = How.XPath, Using = "//select[@class='ui dropdown']")]
        private IWebElement ChooseLangLevel { get; set; }

        //click on add button language
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement AddLangButton { get; set; }

        //Skill tab 
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        private IWebElement SkillsTab { get; set; }


        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "(//div[contains(@class,'ui teal button')])[2]")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Add Skill')]")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//select[contains(@class,'ui fluid dropdown')]")]
        private IWebElement ChooseSkill { get; set; }

        //Add button Skill
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement AddSkillButton { get; set; }

        //Educaiton Tab
        [FindsBy(How = How.XPath, Using = "//a[contains(@data-tab,'third')]")]
        private IWebElement EducationTab { get; set; }

        //Click on Add new button in Educaiton
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '][contains(.,'Add New')])[2]")]
        private IWebElement AddNewEducationButton { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'country')]")]
        private IWebElement ChooseCountry { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'title')]")]
        private IWebElement ChooseEducationTitle { get; set; }


        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement DegreeYear { get; set; }


        //Click on Add
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement AddEduButton { get; set; }

        //Skill tab 
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Certifications')]")]
        private IWebElement CertificationTab { get; set; }

        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "(//div[@class='ui teal button '][contains(.,'Add New')])[3]")]
        private IWebElement AddNewCertiButton { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Certificate or Award')]")]
        private IWebElement EnterCerti { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement CertiFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//select[@class='ui fluid dropdown']")]
        private IWebElement CertiYear { get; set; }
        
        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Add')]")]
        private IWebElement AddCerti { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        //Profile username for change password
         [FindsBy(How = How.CssSelector, Using = "span.item.ui.dropdown.link")]
        private IWebElement  UserName{ get; set; }



        #endregion
        [Obsolete]
        public void ProfileButton()
        {
            //to navigate profile page
            Thread.Sleep(2000);
            GlobalDefinitions.driver.FindElement(By.XPath("//section//div//a[@class='item'][@href='/Account/Profile']")).Click();


        }

        public string EditProfileTest(string TimeValue, string HourValue, string EarnTargetValue)
        {

            //Click on Edit sign in Availability Time
            AvailabilityTimeEdit.Clicks();
            Thread.Sleep(3000);
            //select time
            SelectElement SelectAvailableTime = new SelectElement(AvailabilityTime);
            SelectAvailableTime.SelectByValue(TimeValue);
            Thread.Sleep(2000);
            //Select Availability hours
            AvailabilityHoursEdit.Clicks();
            Thread.Sleep(3000);
            SelectElement SelectAvailableHour = new SelectElement(AvailabilityHoursOpt);
            SelectAvailableHour.SelectByValue(HourValue);
            //select Earn Target
            Thread.Sleep(2000);
            EarnTargetEdit.Clicks();
            SelectElement SelectEarnTarget = new SelectElement(Salary);
            SelectEarnTarget.SelectByValue(EarnTargetValue);

            return "Pass";

        }

        //to navigate profile page

        [Obsolete]
        public void AddLanguage(string language, string level)
        {
            //to navigate Profile
            ProfileButton();

            //click on language Tab
            LangTab.Clicks();
            Thread.Sleep(2000);
            AddNewLangBtn.Clicks();
            Thread.Sleep(2000);
            AddLangText.EnterText(language);

            ChooseLangLevel.SelectFromDDL(level);
            Thread.Sleep(2000);
            //add new button
            AddLangButton.Clicks();

        }



        // DeleteLanguage() deletes a language skill from Languages table in user's profile page
        [Obsolete]
        public string DeleteLanguge(string language, string level)
        {
            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='remove icon'])[" + column + "]")).Click();
                Console.WriteLine("language deleted");
            }
            return "Success";
        }
        [Obsolete]
        public string EditLanguge(string language, string level, string newLanguage, string newLevel)
        {

            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='outline write icon'])[" + column + "]")).Click();
                IWebElement languageTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
                languageTextbox.Clear();
                languageTextbox.EnterText(newLanguage);
                IWebElement languageDropbox = GlobalDefinitions.driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
                languageDropbox.SelectFromDDL(newLevel);
                GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();
                Console.WriteLine("language edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditLanguge(string language, string level, string newLanguage, string newLevel)
        {
            int oldColumn = SearchLanguageTableData(language, level);
            int newColumn = SearchLanguageTableData(newLanguage, newLevel);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Language Updated");
                return "Success";

            }
            else
            {
                Console.WriteLine("Language not Updated");
                return "UnSuccess";
            }
        }
        [Obsolete]
        public int SearchLanguageTableData(string language, string level)
        {
            //to navigate Profile
            ProfileButton();
            //click on language Tab
            LangTab.Clicks();
            // Gets languages table
            IWebElement table = GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[2]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == language) && (columns[1].Text == level))
                    {

                        return count;

                    }

                }
            }

            return -1;

        }


        [Obsolete]
        public string ValidateLanguage(string language, string level)
        {
            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


            //string ActualLanguage=GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(.,'"+language+"')]")).Text;
            //string ActualLevel= GlobalDefinitions.driver.FindElement(By.XPath("//td[contains(.,'" + level + "')]")).Text;
            //Console.WriteLine("added laguage  " + ActualLanguage);
            //Console.WriteLine("added level  " + ActualLevel);
            //if (language == ActualLanguage && level== ActualLevel)
            //    return "Pass";
            //else
            //    return "Fail";


        }

        [Obsolete]
        public string AddSkills(string skill, string level)
        {
            //to navigate Profile
            ProfileButton();
            Thread.Sleep(2000);
            //click on language Tab
            SkillsTab.Clicks();
            Thread.Sleep(2000);
            AddNewSkillBtn.Clicks();
            Thread.Sleep(2000);
            AddSkillText.EnterText(skill);
            ChooseSkill.SelectFromDDL(level);
            Thread.Sleep(2000);
            //add new button
            AddSkillButton.Clicks();
            Thread.Sleep(2000);
            return "Add skill Successfully";
        }

        [Obsolete]
        public string ValidateSkill(string Skill, string level)
        {
            int column = SearchSkillTableData(Skill, level);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


        }

        [Obsolete]
        public int SearchSkillTableData(string skill, string level)
        {
            ProfileButton();
            SkillsTab.Clicks();
            // Gets languages table
            IWebElement table = GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[3]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == skill) && (columns[1].Text == level))
                    {
                        Console.WriteLine("Skills Found");
                        return count;

                    }

                }
            }

            return -1;

        }
        [Obsolete]
        public string DeleteSkill(string skill, string level)
        {
            int column = SearchSkillTableData(skill, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            GlobalDefinitions.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active " +
                "> div > div.twelve.wide.column.scrollTable >" +
                " div > table > tbody:nth-child(" + column + ") > tr > td.right.aligned > span:nth-child(2) > i"));
            //GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/" +
            //        "div[3]/form/div[3]/div/div[2]/div/table/tbody[" + column + "]/tr/td[3]/span[2]/i")).Clicks();
            Console.WriteLine("language deleted");

            return "Success";
        }
        [Obsolete]
        public string EditSkills(string skill, string level, string newSkill, string newLevel)
        {

            int column = SearchSkillTableData(skill, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account - profile - section']" +
                    "/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]" +
                    "/div/table/tbody[" + column + "]/tr/td[3]/span[1]/i")).Clicks();
                Thread.Sleep(1000);
                IWebElement SkillTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
                SkillTextbox.Clear();
                SkillTextbox.EnterText(newSkill);
                Thread.Sleep(1000);
                IWebElement skillDropbox = GlobalDefinitions.driver.FindElement(By.CssSelector("select.ui.fluid.dropdown"));
                skillDropbox.SelectFromDDL(newLevel);
                Thread.Sleep(3000);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > " +
                    "tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button")).Clicks();
                Console.WriteLine("skill edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditskill(string skill, string level, string newSkill, string newLevel)
        {
            int oldColumn = SearchSkillTableData(skill, level);
            int newColumn = SearchSkillTableData(newSkill, newLevel);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Skill Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New skill not updated");
                return "Unsuccess";
            }
            

        }

        [Obsolete]
        public void AddEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            //to navigate Profile
            ProfileButton();
            //click on language Tab
            EducationTab.Clicks();
            AddNewEducationButton.Clicks();
            EnterUniversity.EnterText(collegeName);
            ChooseCountry.SelectFromDDL(country);
            ChooseEducationTitle.SelectFromDDL(title);
            Degree.EnterText(degree);
            DegreeYear.SelectFromDDL(yearOfFinish);
            AddEduButton.Clicks();
            Thread.Sleep(1000);
        }

        [Obsolete]
        public string ValidateEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            int column = SearchEducationTableData(collegeName,country,title,degree,yearOfFinish);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }
        }

        [Obsolete]
        public int SearchEducationTableData(string collegeName, string country,string title, string degree,string yearOfFinish)  
        {
            ProfileButton();
            EducationTab.Clicks();
            // Gets languages table
            IWebElement table = GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[4]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == country) && (columns[1].Text == collegeName)&&(columns[2].Text==title)&&
                        (columns[3].Text==degree)&&(columns[4].Text==yearOfFinish))
                    {
                        Console.WriteLine("Education Found");
                        return count;

                    }

                }
            }

            return -1;

        }

        [Obsolete]
        public string DeleteEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            int column = SearchEducationTableData(collegeName,country,title,degree,yearOfFinish);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            Thread.Sleep(2000);
            GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='remove icon'])[3]")).Clicks();
            //GlobalDefinitions.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) >" +
            //    " div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active >" +
            //    " div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child("+column+1+") > tr > td.right.aligned > span:nth-child(2) > i")).Clicks();
            //Console.WriteLine("education deleted");

            return "Success";
        }
        [Obsolete]
        public string EditEducation(string collegeName, string country, string title, string degree, string yearOfFinish, 
            string newCollegeName, string newCountry, string newTitle, string NewDegree, string NewYearOfFinish)
        {

            int column = SearchEducationTableData(collegeName, country, title, degree, yearOfFinish);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='outline write icon'])[4]")).Clicks();
                Thread.Sleep(1000);
                IWebElement collegeTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
                collegeTextbox.Clear();
                collegeTextbox.EnterText(newCollegeName);
                
                IWebElement countryDropbox = GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'country')]"));
                countryDropbox.SelectFromDDL(newCountry);
                Thread.Sleep(1000);

                IWebElement titleDropbox = GlobalDefinitions.driver.FindElement(By.XPath("//select[contains(@name,'title')]"));
                titleDropbox.SelectFromDDL(newTitle);
                Thread.Sleep(1000);

                IWebElement degreeTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                degreeTextbox.Clear();
                degreeTextbox.EnterText(NewDegree);

                IWebElement yearDropbox = GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                yearDropbox.SelectFromDDL(NewYearOfFinish);
                Thread.Sleep(1000);

                GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();
                Console.WriteLine("Education edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditEducation(string collegeName, string country, string title, string degree, string yearOfFinish,
            string newCollegeName, string newCountry, string newTitle, string NewDegree, string NewYearOfFinish)
        {
            int oldColumn = SearchEducationTableData(collegeName,country,title,degree,yearOfFinish);
            int newColumn = SearchEducationTableData(newCollegeName,newCountry,newTitle,NewDegree,NewYearOfFinish);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Education Record Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New Education not updated");
                return "Unsuccess";
            }

        }

        [Obsolete]
        public void AddCertification(string certificate, string from, string year)
        {
            //to navigate Profile
            ProfileButton();
            Thread.Sleep(2000);
            //click on skill Tab
            CertificationTab.Clicks();
            AddNewCertiButton.Clicks();
            EnterCerti.EnterText(certificate);
            CertiFrom.EnterText(from);
            CertiYear.SelectFromDDL(year);
            Thread.Sleep(2000);
            AddCerti.Clicks();
            
            Thread.Sleep(2000);
            Console.WriteLine(" Add skill Successfully");
        }

        [Obsolete]
        public int SearchCertificateTableData(string certificateName, string from,string year )
        {
            ProfileButton();
            CertificationTab.Clicks();
            // Gets languages table
            IWebElement table = GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[5]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == certificateName) && (columns[1].Text == from)&&(columns[2].Text==year))
                    {
                        Console.WriteLine("Certificate Found");
                        return count;

                    }

                }
            }
            return 0;
        }

        [Obsolete]
        public string ValidateCertificate(string certificateName, string from, string year)
        {
            int column = SearchCertificateTableData(certificateName,from,year);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


        }
        [Obsolete]
        public string DeleteCertificate(string certificateName, string from, string year)
        {
            int column = SearchCertificateTableData(certificateName,from,year);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            column = column + 1;
            Thread.Sleep(2000);
            // GlobalDefinitions.driver.FindElement(By.XPath("(//i[@class='remove icon'])[3]")).Clicks();
            GlobalDefinitions.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > " +
                "div > table > tbody:nth-child(" + column + ") > tr > td.right.aligned > span:nth-child(2) > i")).Click();
            //GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/" +
              //  "div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + column + "]/tr/td[4]/span[2]/i")).Clicks();

            return "Success";
        }
        [Obsolete]
        public string EditCertificate(string certificateName, string from, string year, string newCertificateName, string newFrom, string newYear)
        {

            int column = SearchCertificateTableData(certificateName,from,year);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                column = column + 1;
                Thread.Sleep(2000);
                GlobalDefinitions.driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > " +
                "div > table > tbody:nth-child(" + column + ") > tr > td.right.aligned > span:nth-child(1) > i")).Click(); ;
                Thread.Sleep(1000);
                IWebElement certificateTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
                certificateTextbox.Clear();
                certificateTextbox.EnterText(newCertificateName);

                IWebElement fromTextbox = GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
                fromTextbox.Clear();
                fromTextbox.EnterText(newFrom);

                IWebElement yearDropbox = GlobalDefinitions.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
                yearDropbox.SelectFromDDL(newYear);

                GlobalDefinitions.driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();

                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditCertificate(string certificateName, string from, string year, string newCertificateName, string newFrom, string newYear)
        {
            int oldColumn = SearchCertificateTableData(certificateName,from,year);
            int newColumn = SearchCertificateTableData(newCertificateName, newFrom, newYear);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Record Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New record not updated");
                return "Unsuccess";
            }
            

        }
        [Obsolete]
        public void ChangePassword(string CurrentPassword,string NewPassword)
        {
            Actions action = new Actions(GlobalDefinitions.driver);
            action.MoveToElement(UserName).Build().Perform();
            Thread.Sleep(2000);
            GlobalDefinitions.driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Change Password')]")).Clicks();
            //Populate the Excel sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");
            //Enter the password 
            //IWebElement CurrentPassword = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));
            //CurrentPassword.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));
            IWebElement Password = GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));
            Password.SendKeys(CurrentPassword);
            GlobalDefinitions.Wait(10);
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='New Password']")).EnterText(NewPassword);
            GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']")).EnterText(NewPassword);
            GlobalDefinitions.driver.FindElement(By.XPath("//button[@type='button'][contains(.,'Save')]")).Clicks();
            GlobalDefinitions.driver.Navigate().Back();
         
          }

    }



}