﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AutomatedTestingCohort.Support
{
    [Binding]
    public class Hooks1
    {

        public static IWebDriver driver;
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
             
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}