namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_69
	/// </summary>
	public class Sqrt_x_
	{
		/// <summary>
		/// 找出平方根的最小整數
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public int MySqrt(int x)
		{
			if (x == 0 || x == 1)
			{
				return x;
			}

			var result = 0;
			var start = 0;
			var end = x;

			while (start <= end)
			{
				int mid = (start + end) / 2;

				// 避免溢位
				if ((long)mid * mid <= x)
				{
					result = mid;
					start = mid + 1;
				}
				else
				{
					end = mid - 1;
				}
			}

			return result;
		}
	}
}
