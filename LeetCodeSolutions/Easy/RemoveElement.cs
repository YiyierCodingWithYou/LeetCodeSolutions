namespace LeetCodeSolutions.Easy
{
	public class RemoveElement
	{
		/// <summary>
		/// 從陣列中移除指定數字
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public int RemoveElementFromArray(int[] nums, int val)
		{
			if(nums.Length <= 0)
			{
				return 0;
			}

			int amount = 0;

			for(int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != val)
				{
					nums[amount] = nums[i];
					amount++;
				}
			}

			return amount;
		}
	}
}