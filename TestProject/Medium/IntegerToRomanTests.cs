using LeetCodeSolutions.Medium;

namespace TestProject.Medium
{
	[TestFixture]
	public class IntegerToRomanTests
	{
		private IntegerToRoman _converter;

		[SetUp]
		public void Setup()
		{
			_converter = new IntegerToRoman();
		}

		[TestCase(3749, "MMMDCCXLIX")]
		[TestCase(58, "LVIII")]
		[TestCase(1994, "MCMXCIV")]

		public void IntToRoman_ReturnsExpectedResult(int num, string expected)
		{
			var result = _converter.IntToRoman(num);
			Assert.That(result, Is.EqualTo(expected));
		}
	}
}
