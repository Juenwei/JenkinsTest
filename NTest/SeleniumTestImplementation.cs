using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace NTest
{
	public class SeleniumTest
	{
		private IWebDriver driver = new ChromeDriver();

		[SetUp]
		public void Initialize()
		{
			//navigate to URL
			driver.Navigate().GoToUrl("https://www.facebook.com/");
			//Maximize the browser window
			driver.Manage().Window.Maximize();
			Thread.Sleep(2000);
		}

		[Test]
		public void ExecuteTest()
		{
			//identify the username text box
			IWebElement ele = driver.FindElement(By.Id("email"));
			//enter the username value
			ele.SendKeys("xyz11@gmail.com");
			Thread.Sleep(2000);
			Console.Write("username value is entered \n");
			//identify the password text box
			IWebElement ele1 = driver.FindElement(By.Name("pass"));
			//enter the password value
			ele1.SendKeys("########");

			//click on the Login button
			IWebElement ele2 = driver.FindElement(By.Name("login"));
			ele2.Click();
			Thread.Sleep(5000);
			Console.Write("login button is clicked \n");
		}

		[TearDown]
		public void EndTest()
		{
			//close the browser
			driver.Close();
		}
	}
}
