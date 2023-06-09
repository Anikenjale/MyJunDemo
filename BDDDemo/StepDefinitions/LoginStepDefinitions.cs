using BDDDemo.StepHelper;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace BDDDemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions:LoginStepHelper
    {

        [Given(@"User Launch browser")]
        public void GivenUserLaunchBrowser()
        {
            LuanchBrowser();
            Debug.WriteLine("Luanches Chrome");
        }


        [Then(@"opens URL'([^']*)'")]
        public void GivenOpenURL(string Url)
        {
            OpenUrl(Url);
            Debug.WriteLine("Open demo site");
        }


        [When(@"User navigate to MyAccount menu")]
        public void WhenUserNavigateToMyAccountMenu()
        {
            NavigatetoMyAccount();
            Debug.WriteLine("navigates to MyAccount");
            
        }



        [When(@"click on Login")]
        public void WhenClickOnLogin()
        {
            ClickOnLogin();
            Debug.WriteLine("Login page opened");
            
        }

       
       
        [When(@"Email '([^']*)' and password '([^']*)'")]
        public void EnterEmailAndPassword(string p0, string p1)
        {
            EnterUserCredentials(p0, p1);
            Debug.WriteLine("Credentials are entered");
            
        }


        [When(@"Click on Login button")]
        public void WhenClickOnLoginButton()
        {
            LoginUser();
            Debug.WriteLine("Login Su");
        }



        [Then(@"User navigates to MyAccount Page")]
        public void ThenUserNavigatesToMyAccountPage()
        {
            Debug.WriteLine("User navigates to MyAccount Page");
                CloseBrowser();
        }


    }
}
