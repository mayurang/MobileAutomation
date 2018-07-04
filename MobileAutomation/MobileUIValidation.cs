using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace MobileAutomationFramework
{
    [TestClass]
    public class MobileUIValidation
    {
        AppiumDriver<IWebElement> driver;

        [TestMethod]
        public void TestMethod1()
        {

            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("deviceName", "Android");
            cap.SetCapability("platformVersion", "6.0");
            cap.SetCapability("platformName", "Android");


            cap.SetCapability("app", "C:\\MobileApp\\MobileTest.apk");

            // cap.SetCapability("app", "C:\\Temp\\Tutto Office 365_v2.6_apkpure.com.apk");



            // driver.CloseApp();
            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
            driver.CloseApp();
            driver.FindElementByAccessibilityId("Apps").Click();
            driver.FindElementByAccessibilityId("Guru99").Click();
            //driver.FindElementByAccessibilityId("Courses").Click();
            driver.FindElementByClassName("android.widget.TextView").SendKeys(Keys.Return);
            //driver.FindElementById("com.vector.guru99:id/lblListHeader").Click();
            //IList<IWebElement> els = driver.FindElementsByClassName("android.widget.TextView");
            //var loc1 = els[7].Location;
            //IWebElement target = els[1];
            //var loc2 = target.Location;
            //driver.Swipe(loc1.X, loc1.Y, loc2.X, loc2.Y, 800);

            //driver.FindElementByAccessibilityId("Outlook").Click();
            //driver.FindElementById("com.microsoft.office.outlook:id/btn_splash_start").Click();

            //driver.FindElementById("com.microsoft.office.outlook:id/edit_text_email").SendKeys("SujahSivasubramaniam@quickenloans.com");

            //driver.FindElementById("com.microsoft.office.outlook:id/btn_continue").Click();
            //System.Threading.Thread.Sleep(5000);
            ////driver.FindElementByClassName("EditText").SendKeys("SujahSivasubramaniam@quickenloans.com");

            ////driver.Keyboard.SendKeys(Keys.Tab);
            //driver.Keyboard.SendKeys("Nila700nee");
            //driver.FindElementByAccessibilityId("Sign in").Click();
            //System.Threading.Thread.Sleep(1000);

            //driver.FindElementByClassName("android.widget.Button").Click();
            //System.Threading.Thread.Sleep(2000);
            //driver.FindElementById("header").Click();
            //System.Threading.Thread.Sleep(2000);

            //IList<IWebElement> els = driver.FindElementsByClassName("android.widget.TextView");
            //var loc1 = els[4].Location;
            //IWebElement target = els[1];
            //var loc2 = target.Location;
            //driver.Swipe(loc1.X, loc1.Y, loc2.X, loc2.Y, 800);
            //driver.FindElementByAccessibilityId("Workspace").Click();
            //System.Threading.Thread.Sleep(2000);
            //driver.FindElementByAccessibilityId("Outlook").Click();
            // driver.FindElementById("com.microsoft.office.outlook:id/btn_splash_start").Click();

            //driver.FindElementById("com.microsoft.office.outlook:id/edit_text_email").SendKeys("SujahSivasubramaniam@quickenloans.com");

            // driver.FindElementById("com.microsoft.office.outlook:id/btn_continue").Click();
            // System.Threading.Thread.Sleep(5000);


            // driver.Keyboard.SendKeys("Nila700nee");

            //driver.HideKeyboard();
            //System.Threading.Thread.Sleep(1000);
            //driver.FindElementById("submitButton").Click();

            //System.Threading.Thread.Sleep(3000);
            ////driver.FindElementById("passcode").Click();
            ////System.Threading.Thread.Sleep(1000);
            ////driver.FindElementByClassName("android.widget.EditText").SendKeys("458701228");
            ////System.Threading.Thread.Sleep(1000);
            ////driver.HideKeyboard();
            //driver.FindElementByClassName("android.widget.Button").Click();
            //System.Threading.Thread.Sleep(1000);

        }
    }

}
