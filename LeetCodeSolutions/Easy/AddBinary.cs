using System.Text;

namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_67
	/// </summary>
	public class AddBinary
	{
		/// <summary>
		/// 給定兩個二進位字串 a 和 b，回傳它們相加後的二進位結果字串。
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		public string GetBinarySum(string a, string b)
		{
			var temp = new StringBuilder();
			var carry = 0;
			var aIdx = a.Length - 1;
			var bIdx = b.Length - 1;

			while (aIdx >= 0 || bIdx >= 0 || carry != 0)
			{
				var aNum = 0;
				var bNum = 0;

				if (aIdx >= 0)
				{
					aNum = a[aIdx] - '0';
				}

				if (bIdx >= 0)
				{
					bNum = b[bIdx] - '0';
				}

				var sum = aNum + bNum + carry;

				carry = sum / 2;

				temp.Append(sum % 2);

				aIdx--;
				bIdx--;
			}

			var result = temp.ToString().ToCharArray();
			Array.Reverse(result);

			return new string(result);
		}
	}
}
