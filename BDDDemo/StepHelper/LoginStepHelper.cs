using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDDemo.StepHelper
{
    public class LoginStepHelper
    {
        IWebDriver driver;
        public LoginStepHelper()
        {
            this.driver = driver;
        }


        //Locators

        IWebElement myacbtn => driver.FindElement(By.XPath("//span[contains(text(),'My Account')]"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
        IWebElement emailbox => driver.FindElement(By.Id("input-email"));
        IWebElement passwordbox=> driver.FindElement(By.Id("input-password"));
        IWebElement Loginbtn => driver.FindElement(By.XPath("//*[@type='submit']"));







        public void LuanchBrowser()
        {
            driver= new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        public void OpenUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        //https://demo.opencart.com/

        public void NavigatetoMyAccount()
        {
            myacbtn.Click();
        }

        public void ClickOnLogin()
        {
            loginbtn.Click();
        }

        public void EnterUserCredentials(string p0,String p1)
        {
            emailbox.SendKeys(p0);
            passwordbox.SendKeys(p1);
        }
        public void LoginUser()
        {
            Loginbtn.Click();
        }

        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
