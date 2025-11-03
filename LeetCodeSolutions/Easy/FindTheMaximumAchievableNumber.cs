namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_2769
	/// </summary>
	public class FindTheMaximumAchievableNumber
	{
		/// <summary>
		/// 計算在最多 t 次操作後，x 可達成的最大值。
		/// 每次操作可將 x 與 num 分別加一或減一。
		/// </summary>
		/// <param name="num"></param>
		/// <param name="t"></param>
		/// <returns></returns>
		public int TheMaximumAchievableX(int num, int t)
		{
			return num + 2 * t;
		}
	}
}
