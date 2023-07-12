using JenkinsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest2
{
	[TestClass]
	public class MSUnitTestImplementation
	{
		private Calculator calculator = new Calculator();;

		[TestMethod]
		[TestCategory("Basic")]
		public void SubtractionCalculationTest()
		{
			// Arrange
			int a = 8;
			int b = 7;

			// Act
			int result = calculator.Subtract(a, b);

			// Assert
			Assert.AreEqual(1, result);
		}

		[TestMethod]
		[TestCategory("Advance")]
		public void ModulusCalculationTest()
		{
			// Arrange
			int a = 17;
			int b = 4;

			// Act
			int result = calculator.Modulus(a, b);

			// Assert
			Assert.AreEqual(1, result);
		}
	}
}
