namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_70
	/// </summary>
	public class ClimbingStairs
	{
		/// <summary>
		/// 給定一個整數 n，代表樓梯的階數。每次可以爬 1 或 2 階，請回傳到達樓頂的不同走法總數。
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		public int ClimbStairs(int n)
		{
			if (n <= 2)
			{
				return n;
			}

			var result = 0;

			var firstStair = 1;
			var secondStairs = 2;

			for (int i = 3; i <= n; i++)
			{
				result = firstStair + secondStairs;
				firstStair = secondStairs;
				secondStairs = result;
			}

			return result;
		}
	}
}
