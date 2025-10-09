namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_35
	/// </summary>
	public class SearchInsertPosition
	{
		/// <summary>
		/// 找出目標值在陣列中的 index
		/// </summary>
		/// <param name="nums"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public int SearchInsert(int[] nums, int target)
		{
			var idx = -1;
			int high = nums.Length - 1, low = 0, mid = 0;

			while(low <= high && idx < 0)
			{
				// 找出頭尾範圍內的中心點
				mid = low + (high - low) / 2;

				// 移動頭尾的範圍
				if (nums[mid] < target)
				{
					low = mid + 1;
				}
				else if (nums[mid] > target)
				{
					high = mid - 1;
				}
				else 
				{
					idx = mid;
				}
			}

			if (nums[mid] != target)
			{
				return low;
			}

			return idx;
		}
	}
}
