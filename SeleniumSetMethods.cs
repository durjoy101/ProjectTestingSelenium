using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumDemo
{
     class SeleniumSetMethods
    {

        //Enter Text
        internal static void EnterText(IWebDriver driver, string element, string value, string elementtype)

        {
            try
            {

                if (elementtype == "Id")
                    driver.FindElement(By.Id(element)).SendKeys(value);
                if (elementtype == "Name")
                    driver.FindElement(By.Name(element)).SendKeys(value);
            }
            catch (Exception e)
            {

                
            }

        }

        //Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByValue(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == "Class")
                new SelectElement(driver.FindElement(By.ClassName(element))).SelectByText(value);

        }
    }
}

