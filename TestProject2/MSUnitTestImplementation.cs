using JenkinsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace MsUnitTest
{
	[TestClass]
	public class MSUnitTestImplementation
	{
		private const string expected = "Hello World!";

		[TestMethod]
		public void HelloWorldTestMethod()
		{
			using (var stringWriter = new StringWriter())
			{
				Console.SetOut(stringWriter);
				Program.Main();

				var result = stringWriter.ToString().Trim();
				Assert.AreEqual(expected, result);
			}
		}
	}
}
