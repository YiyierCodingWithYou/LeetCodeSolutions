namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_66
	/// </summary>
	public class PlusOne
	{
		/// <summary>
		/// 給定一個由陣列表示的大整數，將其加一並回傳結果陣列
		/// </summary>
		/// <param name="digits"></param>
		/// <returns></returns>
		public int[] IncreaseByOne(int[] digits)
		{
			var carry = 1;
			var temp = new List<int>();

			for (int i = digits.Length - 1; i >= 0; i--)
			{
				int sum = 0;

				sum = digits[i] + carry;
				temp.Insert(0, sum % 10);
				carry = sum / 10;
			}

			if (carry != 0)
			{
				temp.Insert(0, carry);
			}

			return temp.ToArray();
		}

	}
}
