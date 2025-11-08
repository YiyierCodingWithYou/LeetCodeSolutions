using LeetCodeSolutions.Easy;

namespace TestProject.Easy
{
	[TestFixture]
	public class MergeSortedArrayTests
	{
		private MergeSortedArray _converter;

		[SetUp]
		public void Setup()
		{
			_converter = new MergeSortedArray();
		}

		[TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
		[TestCase(new int[] { 1 }, 1, new int[] { 0 }, 1, new int[] { 1 })]
		[TestCase(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]


		public void MergeSortedArray_ReturnsExpectedResult(int[] nums1, int m, int[] nums2, int n , int[] expected)
		{
			_converter.Merge(nums1, m , nums2, n);
			Assert.That(nums1, Is.EqualTo(expected));
		}
	}
}
