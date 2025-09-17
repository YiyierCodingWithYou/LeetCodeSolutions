using System.Collections;

namespace LeetCodeSolutions.Easy
{
	public class TwoSum
	{
		/// <summary>
		/// 雙重迴圈的解法
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int[] TwoSumA(int[] nums, int target)
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

		/// <summary>
		/// 只需要一次迴圈的解法
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int[] TwoSumB(int[] nums, int target)
		{

			Dictionary<int,int> storedNum = new Dictionary<int,int>();
			for (int i = 0; i < nums.Length; i++)
			{
				var neededNum = target - nums[i];

				if (storedNum.TryGetValue(neededNum,out int index))
				{
					return new int[] { index, i };
				}
				else
				{
					if (!storedNum.ContainsKey(nums[i]))
					{
						storedNum.Add(nums[i], i);
					}
				}
			}

			return Array.Empty<int>();
		}

	}
}
