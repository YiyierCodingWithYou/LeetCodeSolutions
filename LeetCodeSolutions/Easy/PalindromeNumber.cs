namespace LeetCodeSolutions.Easy
{
	public class PalindromeNumber
	{
		/// <summary>
		/// 判斷輸入的數字是否為迴文
		/// 迴文：正著念和反著念都相同的句子
		/// 例：12321
		/// 解法1：將字串反轉再做比較
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public bool IsPalindromeA(int x)
		{
			var inputNumToString = x.ToString();
			var inputNumToStringLength = inputNumToString.Length;
			var stringArray = new string[inputNumToStringLength];
			var reverseStringArray = new string[inputNumToStringLength];

			for (int i = 0; i < inputNumToStringLength; i++)
			{
				var splitedNum = inputNumToString.Substring(i, 1);
				stringArray[i] = splitedNum;
				reverseStringArray[inputNumToStringLength - i - 1] = splitedNum;
			}

			if (stringArray.SequenceEqual(reverseStringArray))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// 判斷輸入的數字是否為迴文
		/// 迴文：正著念和反著念都相同的句子
		/// 例：12321
		/// 解法2：試著降低Runtime，只比較一半的數字
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public bool IsPalindromeB(int x)
		{
			var xString = x.ToString();
			var xLength = xString.Length;
			var halfLength = xLength / 2;
			for(int i = 0; i < halfLength; i++)
			{
				if (xString[i] != xString[xLength - i - 1])
				{
					return false;
				}
			}
			return true;
		}

	}
}
