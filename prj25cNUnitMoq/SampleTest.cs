namespace prj25cNUnitMoq
{
	public class SampleTest
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}

		[Test]
		public void Test2()
		{
			//Assert.Fail();
		}

		[Test]
		//[Repeat(3)]
		public void Test3()
		{
			Assert.That(1 == 1);
		}
	}
}