namespace LeetCodeSolutions.Easy
{
	public class RemoveDuplicatesFromSortedArray
	{
		/// <summary>
		/// 移除陣列中重複的數字，並回傳不重複數字的個數
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public int RemoveDuplicates(int[] nums)
		{
			if (nums.Length <= 0)
			{
				return 0;
			}

			int amount = 1;

			for (int i = 1; i < nums.Length; i++)
			{
				if (nums[i] != nums[i - 1])
				{
					nums[amount] = nums[i];
					amount++;
				}
			}

			return amount;
		}
	}
}
