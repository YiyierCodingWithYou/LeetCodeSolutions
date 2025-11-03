namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_1929
	/// </summary>
	public class ConcatenationOfArray
	{
		/// <summary>
		/// 將整數陣列與自身串接後回傳新陣列。
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public int[] GetConcatenation(int[] nums)
		{
			var result = new int[nums.Length * 2];

			for (int i = 0; i <= result.Length - 1; i++)
			{
				result[i] = i >= nums.Length ? nums[i - nums.Length] : nums[i];
			}

			return result;
		}
	}
}
