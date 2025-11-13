namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_7
	/// </summary>
	public class ReverseInteger
	{
		public class Solution
		{
			/// <summary>
			/// 給定一個整數 x，請回傳其數字反轉後的結果。
			/// </summary>
			/// <param name="x"></param>
			/// <returns></returns>
			public int ReverseA(int x)
			{
				if (x == int.MinValue)
				{
					return 0;
				}

				var temp = new System.Text.StringBuilder();

				if (x < 0)
				{
					temp.Append("-");
				}

				x = Math.Abs(x);

				while (x >= 10)
				{
					temp.Append(x % 10);
					x = x / 10;
				}

				temp.Append(x);

				var inRange = int.TryParse(temp.ToString(), out int result);

				return inRange == true ? result : 0;

			}
		}


		/// <summary>
		/// 給定一個整數 x，請回傳其數字反轉後的結果。
		/// 試著用純數學運算來解題
		/// </summary>
		/// <param name="x"></param>
		/// <returns></returns>
		public int ReverseB(int x)
		{
			int sum = 0;

			while (x != 0)
			{
				int digit = x % 10;
				x = x / 10;

				if (sum > int.MaxValue / 10 || (sum == int.MaxValue / 10 && digit > 7))
				{
					return 0;
				}

				if (sum < int.MinValue / 10 || (sum == int.MinValue / 10 && digit < -8))
				{
					return 0;
				}

				sum = sum * 10 + digit;
			}

			return sum;
		}

	}
}
