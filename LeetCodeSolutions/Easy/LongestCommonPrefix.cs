namespace LeetCodeSolutions.Easy
{
	public class LongestCommonPrefix
	{
		/// <summary>
		/// 從傳入的字串陣列中找出最長的前綴詞
		/// </summary>
		/// <param name="strs"></param>
		/// <returns></returns>
		public string FindLongestCommonPrefixA(string[] strs)
		{
			var result = "";

			if (strs == null || strs.Length == 0)
			{
				return result;
			}

			// 先找出最短單字的字數
			var shortestStrLength = strs.Min(x => x.Length);

			for (int i = 0; i < shortestStrLength; i++)
			{
				char baseChar = strs[0][i];

				for (int j = 0; j < strs.Length; j++)
				{
					if (strs[j][i] != baseChar)
					{
						return result;
					}
				}

				result += baseChar;
			}

			return result;
		}

		public string FindLongestCommonPrefixB(string[] strs)
		{

			if (strs == null || strs.Length == 0)
			{
				return "";
			}

			// 直接使用第一個字串作為基準
			var prefix = strs[0];
			for (int i = 1; i < strs.Length; i++)
			{
				// 當字串與基準不吻合時，就縮短基準的一個字母
				while (!strs[i].StartsWith(prefix))
				{
					prefix = prefix.Substring(0,prefix.Length - 1);

					if (prefix == "")
					{
						return "";
					}
				}
			}

			return prefix;
		}
	}
}
