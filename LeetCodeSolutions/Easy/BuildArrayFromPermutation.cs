namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_1920
	/// </summary>
	public class BuildArrayFromPermutation
	{
		/// <summary>
		/// 建立一個陣列，使每個位置的值等於原陣列中該位置值所指向位置的數字。
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public int[] BuildArray(int[] nums)
		{
			int[] result = new int[nums.Length];

			for(int i = 0; i < nums.Length; i++)
			{
				result[i] = nums[nums[i]];
			}

			return result;
		}
	}
}
