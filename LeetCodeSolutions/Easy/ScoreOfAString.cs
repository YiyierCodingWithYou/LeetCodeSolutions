namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_3110
	/// </summary>
	public class ScoreOfAString
	{
		/// <summary>
		/// 求出相鄰字元的ASCII值差的絕對值總和。
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public int ScoreOfString(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			var sum = 0;

			for (int i = 0; i < s.Length - 1; i++)
			{
				sum += Math.Abs((int)s[i] - (int)s[i + 1]);
			}

			return sum;
		}
	}
}
