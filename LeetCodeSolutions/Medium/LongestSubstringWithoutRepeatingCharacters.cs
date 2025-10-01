namespace LeetCodeSolutions.Medium
{
	public class LongestSubstringWithoutRepeatingCharacters
	{
		/// <summary>
		/// 找出不含重複字元的最長子字串的長度。
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public int LengthOfLongestSubstring(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				return 0;
			}

			var length = 0;
			int left = 0, right = 0;
			HashSet<char> temp = new HashSet<char>();

			while (right < s.Length)
			{
				if (!temp.Contains(s[right]))
				{
					temp.Add(s[right]);
					right++;

					if((right - left) > length)
					{
						length = right - left;
					}
				}
				else
				{
					temp.Remove(s[left]);
					left++;
				}
			}

			return length;
		}
	}
}
