using JenkinsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestProject2
{
	[TestClass]
	public class MSUnitTestImplementation
	{
		private const string expected = "Hello World!";

		[TestMethod]
		public void JenkinsTestMethod()
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
