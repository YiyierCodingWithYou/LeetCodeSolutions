using System.Security.AccessControl;

namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_15
	/// </summary>
	public class ThreeSum
	{
		/// <summary>
		/// 給定一個整數陣列 nums，找出所有「不重複」且和為 0 的三個數組合。
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public IList<IList<int>> FindThreeSumCombination(int[] nums)
		{
			Array.Sort(nums);
			var result = new List<IList<int>>();

			for (int i = 0; i < nums.Length - 1; i++)
			{
				int left = i + 1, right = nums.Length - 1;

				if (i != 0 && nums[i] == nums[i - 1])
				{
					continue;
				}

				while (left < right)
				{
					var sum = nums[i] + nums[left] + nums[right];
					if (sum == 0)
					{
						result.Add(new int[] { nums[i], nums[left], nums[right] });

						while (left < right && nums[left] == nums[left + 1])
						{
							left++;
						}

						while (left < right && nums[right] == nums[right - 1])
						{
							right--;
						}

						left++;
						right--;

					}
					else if (sum < 0)
					{
						left++;
					}
					else
					{
						right--;
					}
				}
			}

			return result;
		}
	}
}
