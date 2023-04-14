using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using ca.i5i.c.calculator.impl;
using ca.i5i.c.calculator;
using ca.i5i.c.xe;

namespace prj25cNUnitMoq
{
	// Step 5. Add the attribute annotating the class as a tester
	[TestFixture]
	public class CalculatorTest
	{
		[Test(Description = "Test500Direct")]
		public void Test500Direct()
		{
			var mock = new Mock<IExchangeRateFeed>();
			mock.Setup(e => e.GetActualUSDValue()).Returns(500);
			int actualResult = mock.Object.GetActualUSDValue();
			int expectedResult = 5050;
			Assert.AreEqual(expectedResult, actualResult);
		}

		private IExchangeRateFeed GetMockExchangeRateFeed()
		{
			Mock<IExchangeRateFeed> mockObject = new Mock<IExchangeRateFeed>();
			mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
			return mockObject.Object;
		}


		[Test(Description = "Convert 1 USD to CLP. Expected result is 300.")]
		public void Test300ConvertUSDtoCLP()
		{
			IExchangeRateFeed feed = this.GetMockExchangeRateFeed();
			ICalculator calculator = new Calculator(feed);
			int actualResult = calculator.ConvertUSDtoCLP(1);
			int expectedResult = 500;
			Assert.AreEqual(expectedResult, actualResult);
		}


		[Test(Description = "Divide 9 by 3. Expected result is 3.")]
		public void TestDivide9By3()
		{
			IExchangeRateFeed feed = this.GetMockExchangeRateFeed();
			ICalculator calculator = new Calculator(feed);
			int actualResult = calculator.Divide(9, 3);
			int expectedResult = 3;
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}