using ca.i5i.c.calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ca.i5i.c.xe;

namespace ca.i5i.c.calculator.impl
{
	public class Calculator : ICalculator
	{
		private IExchangeRateFeed _feed;
		public Calculator(IExchangeRateFeed feed)
		{
			this._feed = feed;
		}
		#region ICalculator Members
		public int Add(int param1, int param2)
		{
			throw new NotImplementedException();
		}
		public int Subtract(int param1, int param2)
		{
			throw new NotImplementedException();
		}
		public int Multipy(int param1, int param2)
		{
			throw new NotImplementedException();
		}
		public int Divide(int param1, int param2)
		{
			return param1 / param2;
		}
		public int ConvertUSDtoCLP(int unit)
		{
			return unit * this._feed.GetActualUSDValue();
		}
		#endregion
	}
}