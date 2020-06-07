using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class ProfileTest
    {
        [TestFixture]
        [Parallelizable]
        [Category("Sprint1")]
        class ProfileEditTest : Global.Base
        {
            [Test]
            [Obsolete]
            public void ValidateProfileButtonTest()
            {
                Profile P = new Profile();
                P.ProfileButton();
                Assert.AreEqual(Global.GlobalDefinitions.driver.Title, "Profile");

            }
            [Test]
            [Obsolete]
            public void ChangePasswordTest()
            {
                Profile p= new Profile();
                p.ChangePassword("234567","123456");
                

            }

            [Test]
            [Obsolete]
            public void ValidateProfileEditTest()
            {
                Profile P = new Profile();
                string result = P.EditProfileTest("0", "1", "1");
                Assert.IsTrue("Pass" == result, "Test Fail");

            }
        }

        [TestFixture]
        [Parallelizable]
        [Category("Sprint2")]
        class LanguageTest : Global.Base
        {
            [Test]
            [Obsolete]
            public void AddAndValidateLanguageTest()
            {
                Profile p = new Profile();
                p.AddLanguage("English", "Basic");
                string result = p.ValidateLanguage("English", "Basic");
                Console.WriteLine(result);
                Assert.IsTrue("Success" == result, "Test Fail");
            }
            

            [Test]
            [Obsolete]
            public void DeleteAndValidateLanguageTest()
            {
                Profile p = new Profile();
                string s1 = p.DeleteLanguge("English", "Basic");
                //string s1=p.DeleteLanguge("Hindi", "Fluent");
                Assert.IsTrue(s1.Equals("Success"), "Test fail");
                string result = p.ValidateLanguage("English", "Basic");
                Console.WriteLine(result);
                Assert.IsTrue("Record not found" == result, "Test Fail");
            }
            
            [Test]
            [Obsolete]
            public void EditAndValidateLanguageTest()
            {
                Profile p = new Profile();
                string s1 = p.EditLanguge("English", "Basic", "Hindi", "Fluent");
                Assert.IsTrue(s1.Equals("Success"), "Test fail");
                string result = p.ValidateEditLanguge("English", "Basic", "Hindi", "Fluent");
                Assert.IsTrue(result.Equals("Success"), "Test fail");
            }
            
        }
        [TestFixture]
        [Category("Sprint3")]
        class SkillsTest : Global.Base
        {


            [Test]
            [Obsolete]
            public void AddAndValidateAddedSkillTest()
            {
                Profile p = new Profile();
                string s1 = p.AddSkills("QA", "Intermediate");
                Console.WriteLine(s1);
                string result = p.ValidateSkill("QA", "Intermediate");
                Console.WriteLine(result);
                Assert.IsTrue("Success" == result, "Test Fail");
            }

            [Test]
            [Obsolete]
            public void DeletedAndValidateDeletedSkillTest()
            {
                Profile p = new Profile();
                string s1 = p.DeleteSkill("QA", "Intermediate");
                Console.WriteLine(s1);
                string result = p.ValidateSkill("QA", "Intermediate");
                Console.WriteLine(result);
                Assert.IsTrue("Record not found" == result, "Test Fail");
            }
            [Test]
            [Obsolete]
            public void EditAndValidateEditedSkillTest()
            {
                Profile p = new Profile();
                string s1 = p.EditSkills("QA", "Intermediate", "Java", "Beginner");
                Console.WriteLine(s1);
                string result = p.ValidateEditskill("QA", "Intermediate", "Java", "Beginner");
                Assert.IsTrue(result.Equals("Success"), "Test fail");
            }

        }
        [TestFixture]
        [Category("Sprint4")]
        class EducationTest : Global.Base
        {


            [Test]
            [Obsolete]
            public void AddandValidateAddedEducationTest()
            {
                Profile p = new Profile();
                p.AddEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005");
                //Console.WriteLine(s1);
                string result = p.ValidateEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005");
                Console.WriteLine(result);
                Assert.IsTrue("Success" == result, "Test Fail");
            }
            [Test]
            [Obsolete]
            public void DeleteandValidatedeletededEducationTest()
            {
                Profile p = new Profile();
                p.DeleteEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005");
                //Console.WriteLine(s1);
                string result = p.ValidateEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005");
                Console.WriteLine(result);
                Assert.IsTrue("Record not found" == result, "Test Fail");
            }
            [Test]
            [Obsolete]
            public void EditAndValidateEditedEducationTest()
            {
                Profile p = new Profile();
                string s1 = p.EditEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005",
                    "Waikato Univercity", "India", "BFA", "Diploma", "2007");
                Console.WriteLine(s1);
                string result = p.ValidateEditEducation("Auckland Univercity", "New Zealand", "B.Tech", "Bachlor", "2005",
                    "Waikato Univercity", "India", "BFA", "Diploma", "2007");
                Assert.IsTrue(result.Equals("Success"), "Test fail");
            }
        }
        [TestFixture]
        [Category("Sprint5")]
        class CertificationTest : Global.Base
        {


            [Test]
            [Obsolete]
            public void AddandValidateAddedCertificationTest()
            {
                Profile p = new Profile();
                p.AddCertification("IC", "New Zealand", "2009");
                //Console.WriteLine(s1);
                string result = p.ValidateCertificate("IC", "New Zealand", "2009");
                Console.WriteLine(result);
                Assert.IsTrue("Success" == result, "Test Fail");
            }
            [Test]
            [Obsolete]
            public void DeleteandValidatedeletededCertificateTest()
            {
                Profile p = new Profile();
                p.DeleteCertificate("IC", "New Zealand", "2009");
                //Console.WriteLine(s1);
                string result = p.ValidateCertificate("IC", "New Zealand", "2009");
                Console.WriteLine(result);
                Assert.IsTrue("Record not found" == result, "Test Fail");
            }
            [Test]
            [Obsolete]
            public void EditAndValidateEditedCertificationTest()
            {
                Profile p = new Profile();
                string s1 = p.EditCertificate("IC", "New Zealand", "2009","Unitec","UK","2007");
                Console.WriteLine(s1);
                string result = p.ValidateEditCertificate("IC", "New Zealand", "2009", "Unitec", "UK", "2007");
                Assert.IsTrue(result.Equals("Success"), "Test fail");
            }
        }
    }
}