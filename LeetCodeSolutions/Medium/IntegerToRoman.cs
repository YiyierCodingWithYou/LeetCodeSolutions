using System.Text;

namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_12
	/// </summary>
	public class IntegerToRoman
	{
		/// <summary>
		/// 將整數轉為羅馬數字
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public string IntToRoman(int num)
		{
			int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
			string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

			var result = new StringBuilder();

			for(int i = 0; i < values.Length; i++)
			{
				while (num >= values[i])
				{
					num = num - values[i];
					result.Append(symbols[i]);
				}
			}

			return result.ToString();
		}
	}
}
