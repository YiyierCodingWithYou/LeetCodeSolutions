namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_88
	/// </summary>
	public class MergeSortedArray
	{
		/// <summary>
		/// 將 nums2 陣列合併至 nums1 陣列中，並按照由小到大的順序排列
		/// </summary>
		/// <param name="nums1"></param>
		/// <param name="m"></param>
		/// <param name="nums2"></param>
		/// <param name="n"></param>
		public void Merge(int[] nums1, int m, int[] nums2, int n)
		{
			if (m == 0)
			{
				Array.Copy(nums2, nums1, n);
				return;
			}

			for (int i = m; i < m + n; i++)
			{
				nums1[i] = nums2[i - m];
			}

			Array.Sort(nums1);
		}
	}
}
