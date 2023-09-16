﻿namespace LeetCodeSolutions.Easy
{
	public class LeetCode1
	{
		public int[] TwoSum(int[] nums, int target)
		{
			int[] result = new int[2];
			for (int i = 0; i <= nums.Length - 1; i++)
			{
				for (int j = i + 1; j <= nums.Length - 1; j++)
					if ((nums[i] + nums[j]) == target)
					{
						result[0] = i;
						result[1] = j;
						break;
					}
			}
			return result;
		}
	}
}
