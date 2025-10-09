namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_58
	/// </summary>
	public class LengthOfLastWord
	{
		/// <summary>
		/// 回傳字串中最後一個單字的長度。
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public int FindLengthOfLastWord(string s)
		{
			var strArray = s.Trim().Split(' ');
			return strArray[strArray.Length - 1].Length;
		}
	}
}
