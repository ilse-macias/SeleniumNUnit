﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnit
{
    public class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
          
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open the URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //EnterText(element, value, type)

            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "Mr. Shofo", "Name");


            Console.WriteLine("The value form my title is: " + SeleniumGetMethods.GetText(driver, "TitleId", "Id"));
            Console.WriteLine("The value form my Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }

}
