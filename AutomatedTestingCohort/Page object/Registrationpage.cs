using AutomatedTestingCohort.Support;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedTestingCohort.Page_object
{
    class Registrationpage
    {
        public Registrationpage()
        
        {
            driver = Hooks1.driver;


        
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));


        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));


        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));


        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));


        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
       
        public void ClickonSignUp()
        {
            SignUp.Click();
        }



        public void EnterUsername()
        {
            Username.SendKeys("learn");
        }

        public void EnterEmail() 
        {
            Email.SendKeys("learnpride@gmail.com");
        
        }


        public void EnterPassword()
        
        {
            Password.SendKeys("pride12");
        }



        public void ClickOnSignUpButton()
        
        {
            SignUpButton.Click();



        }

        public void NavigateToWebsite() 
        
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }






    }

}
