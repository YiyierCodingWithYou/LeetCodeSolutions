namespace LeetCodeSolutions.Easy
{
	public class FindTheIndexOfTheFirstOccurrenceInAString
	{
		/// <summary>
		/// 在 haystack 字串中尋找目標字串 needle，回傳第一次出現的位置索引，若不存在則回傳 -1。
		/// </summary>
		/// <param name="haystack"></param>
		/// <param name="needle"></param>
		/// <returns></returns>
		public int StrStr(string haystack, string needle)
		{
			for (int i = 0; i <= haystack.Length - needle.Length; i++)
			{
				if(haystack.Substring(i,needle.Length) == needle)
				{
					return i;
				}
			}

			return -1;
		}
	}
}
