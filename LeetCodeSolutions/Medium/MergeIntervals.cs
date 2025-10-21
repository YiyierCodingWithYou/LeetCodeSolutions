namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_56
	/// </summary>
	public class MergeIntervals
	{
		/// <summary>
		/// 給定一組可能重疊的區間，將所有重疊的部分合併後輸出不重疊的區間集合。
		/// </summary>
		/// <param name="intervals"></param>
		/// <returns></returns>
		public int[][] MergeA(int[][] intervals)
		{
			intervals = intervals.OrderBy(x => x[0]).ToArray();

			List<int[]> result = new List<int[]>() { intervals[0] };

			var start = intervals[0][0];
			var end = intervals[0][1];

			for (int i = 1; i < intervals.Length; i++)
			{
				if (intervals[i][0] > end)
				{
					result.Add(intervals[i]);
					start = intervals[i][0];
					end = intervals[i][1];
				}
				else if (intervals[i][0] <= end && intervals[i][1] > end)
				{
					result.Last()[1] = intervals[i][1];
					end = intervals[i][1];
				}
			}

			return result.ToArray();
		}

		/// <summary>
		/// 效能、程式碼優化
		/// </summary>
		/// <param name="intervals"></param>
		/// <returns></returns>
		public int[][] MergeB(int[][] intervals)
		{
			Array.Sort(intervals, (num1, num2) => num1[0].CompareTo(num2[0]));

			List<int[]> result = new List<int[]>();

			var current = intervals[0];

			for (int i = 1; i < intervals.Length; i++)
			{
				if (intervals[i][0] <= current[1])
				{
					current[1] = current[1] > intervals[i][1] ? current[1] : intervals[i][1];
				}
				else
				{
					result.Add(current);
					current = intervals[i];
				}
			}

			result.Add(current);

			return result.ToArray();
		}

	}
}
