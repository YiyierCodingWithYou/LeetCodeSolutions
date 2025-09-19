using Microsoft.JSInterop;

namespace LeetCodeSolutions.Easy
{
	public class RomanToInteger
	{
		/// <summary>
		/// 將羅馬數字轉為整數
		/// 規則：
		/// I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000.
		/// I can be placed before V (5) and X (10) to make 4 and 9. 
		/// X can be placed before L (50) and C (100) to make 40 and 90. 
		/// C can be placed before D (500) and M (1000) to make 400 and 900.
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public int RomanToInt(string s)
		{
			var comparisonTable = new Dictionary<char, int>
			{
				{ 'I', 1 },
				{ 'V', 5 },
				{ 'X', 10 },
				{ 'L', 50 },
				{ 'C', 100 },
				{ 'D', 500 },
				{ 'M', 1000 }
			};

			var result = 0;
			var lastInteger = 0;

			for (int i = s.Length - 1; i >= 0; i--)
			{
				comparisonTable.TryGetValue(s[i], out int nowInteger);

				if(nowInteger >= lastInteger)
				{
					result += nowInteger;
				}
				else
				{
					result -= nowInteger;
				}

				lastInteger = nowInteger;
			}

			return result;
		}

	}
}
