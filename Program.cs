using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumDemo;
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate the Chrome browser
        IWebDriver driver = new ChromeDriver();

        // Navigate to a webpage
        driver.Navigate().GoToUrl("http://localhost/contracts");

        // Find an element on the page
        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        
        // Pause execution for 10 seconds
        Thread.Sleep(40000);

        // Find the dropdown wrap and click on it to open the dropdown
        IWebElement dropdownAccountType = driver.FindElement(By.CssSelector("#ddlAccountType .k-dropdown-wrap"));
        dropdownAccountType.Click();

        // Pause execution for 10 seconds again
        Thread.Sleep(1000);

        // Find the option and click on it
        IWebElement optionAccountType = driver.FindElement(By.XPath("//li[contains(text(), 'C-Store – Chain HQ')]"));
        optionAccountType.Click();
        //SeleniumSetMethods.EnterText(driver, "pckAccountNumber", "54810", "Id");

        IWebElement inputFieldAccountNumber = driver.FindElement(By.CssSelector("kendo-textbox#pckAccountNumber input.k-input"));

        // Clear any existing value
        inputFieldAccountNumber.Clear();

        // Set the new value
        inputFieldAccountNumber.SendKeys("12371");

        //SeleniumSetMethods.EnterText(driver, "calStartDate", "05-16", "Id"); 

        IWebElement selectStartDate = driver.FindElement(By.XPath("//input[@id='calStartDate']"));

        selectStartDate.Click();
        selectStartDate.SendKeys("05");
        selectStartDate.SendKeys("16");
        selectStartDate.SendKeys("22023");

        SeleniumSetMethods.EnterText(driver, "calEndDate", "05/15/2024", "Id");
        Thread.Sleep(1000);

        selectStartDate.Click();
        selectStartDate.SendKeys("05");
        selectStartDate.SendKeys("16");

        // Find the input field
        IWebElement inputFieldCashPayment = driver.FindElement(By.CssSelector("input[formcontrolname='CashPaymentAmount']"));
        // Clear any existing value
        inputFieldCashPayment.Clear();
        // Set the new value
        inputFieldCashPayment.SendKeys("1050");

        // Find the checkbox
        IWebElement checkboxCMF = driver.FindElement(By.Id("chkCMF"));
        // Check the checkbox if it's not already checked
        if (!checkboxCMF.Selected)
        {
            Thread.Sleep(2000);
            checkboxCMF.Click();
        }

        // Find the dropdown list and click to open the options
        IWebElement dropdownRollingPaper = driver.FindElement(By.Id("ddlRollingPaper"));
        dropdownRollingPaper.Click();
        // Wait until the options are visible
        Thread.Sleep(2000); 
        // Click on the option with the desired text
        IWebElement optionRollingPaper = driver.FindElement(By.XPath("//li[contains(text(), '6-7 SKU = $3.00/box')]"));
        optionRollingPaper.Click();

        // Find the dropdown list and click to open the options
        IWebElement dropdownConeRebateSKU = driver.FindElement(By.Id("ddlConeRebateSKU"));
        dropdownConeRebateSKU.Click();

        // Wait until the options are visible
        Thread.Sleep(2000); // You may need to adjust the sleep duration

        // Click on the option with the desired text
        IWebElement optionConeRebateSKU = driver.FindElement(By.XPath("//li[contains(text(), '3 SKU = $0.50/box')]"));
        optionConeRebateSKU.Click();

        // Find the button on the page
        IWebElement buttonSearchProducts = driver.FindElement(By.XPath("//button[text()='Search Products']"));

        // Click the button
        buttonSearchProducts.Click();

        Thread.Sleep(10000); //for load the product grid
        
        // Find the checkbox on the page
        IWebElement checkboxBrandsGAM = driver.FindElement(By.CssSelector("input[type='checkbox'][value='GAM']"));

        // Check the checkbox if not already checked
        if (!checkboxBrandsGAM.Selected)
        {
            checkboxBrandsGAM.Click();
        }
        Thread.Sleep(1000);
        // Find the button on the page
        IWebElement buttonInsertFilters = driver.FindElement(By.XPath("//button[contains(text(), 'Insert all filters')]"));
        //IWebElement buttonInsertFilters = driver.FindElement(By.XPath("//div[contains(@class, 'top-button')]/button[contains(text(), 'Insert all filters')]"));

        // Click the button
        buttonInsertFilters.Click();

        Thread.Sleep(5000);
        SeleniumSetMethods.Click(driver, "btnSave", "Id");

        // Wait for a while
        Thread.Sleep(20000);

        // Find the Ok button within the modal
        //IWebElement okButton = driver.find_element_by_id("btnOK")
        SeleniumSetMethods.Click(driver, "btnOK", "Id");

        // Click the Ok button
        //okButton.Click();

        Thread.Sleep(5000);
        SeleniumSetMethods.Click(driver, "btnSubmit", "Id");

        //// Find the button with the name 'Ok' and click on it
        //IWebElement okButton = driver.FindElement(By.XPath("//button[text()='Ok']"));
        //okButton.Click();


        // Close the browser
        //driver.Quit();
    }
}