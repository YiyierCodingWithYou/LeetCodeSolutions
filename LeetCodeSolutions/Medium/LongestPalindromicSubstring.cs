
namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_5
	/// </summary>
	public class LongestPalindromicSubstring
	{
		/// <summary>
		/// 找出最長的迴文子字串
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public string LongestPalindrome(string s)
		{
			var result = string.Empty;

			if (s.Length == 1)
			{
				return s;
			}

			int maxLength = 0;
			int currentLength;
			int startIndex = 0;

			// 遍歷每個字，往左右同時延伸並比較是否相同
			// 要同時考慮到奇數迴文和偶數迴文的情況
			// 找出兩種情況下各自最長的迴文
			for (int i = 0; i < s.Length - 1; i++)
			{
				// 若為奇數迴文，中心為 i
				var strLength1 = FindLongestPalindromeStringLength(s, i, i);

				// 若為偶數迴文，中心為 i 和 i + 1 之間
				var strLength2 = FindLongestPalindromeStringLength(s, i, i + 1);

				currentLength = strLength1 > strLength2 ? strLength1 : strLength2;
				if (currentLength > maxLength)
				{
					maxLength = currentLength;
					startIndex = currentLength % 2 == 1 ? i - currentLength / 2 : (i - currentLength / 2) + 1;
				}
			}

			result = s.Substring(startIndex, maxLength);
			return result;
		}

		/// <summary>
		/// 找出最長迴文子字串的長度
		/// </summary>
		/// <param name="s"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		private int FindLongestPalindromeStringLength(string s, int left, int right)
		{
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				left--;
				right++;
			}

			return right - left - 1;
		}
	}
}
