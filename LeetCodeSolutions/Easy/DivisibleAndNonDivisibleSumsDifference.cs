namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_2894
	/// </summary>
	public class DivisibleAndNonDivisibleSumsDifference
	{
		/// <summary>
		/// 計算區間 [1, n] 中，所有不能被 m 整除的數字總和與能被 m 整除的數字總和之差。
		/// </summary>
		/// <param name="n"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		public int DifferenceOfSums(int n, int m)
		{
			int num1 = 0, num2 = 0;
			
			for(int i = 1; i <= n; i++)
			{
				if(i % m == 0)
				{
					num2 += i;
				}
				else
				{
					num1 += i;
				}
			}

			return num1 - num2;
		}
	}
}
