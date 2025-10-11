using System.Text;

namespace LeetCodeSolutions.Medium
{
	/// <summary>
	/// LeetCode_6
	/// </summary>
	public class ZigzagConversion
	{
		/// <summary>
		/// 將字串以指定的行數按照「Z字形（zigzag pattern）」排列
		/// </summary>
		/// <param name="s"></param>
		/// <param name="numRows"></param>
		/// <returns></returns>
		public string Convert(string s, int numRows)
		{
			if(numRows == 1)
			{
				return s;
			}
			
			var temp = new string[numRows];
			var currentRow = 0;
			bool isDown = true;

			for (int i = 0; i < s.Length; i++)
			{
				temp[currentRow] += s[i];

				if (currentRow == 0 )
				{
					isDown = true;
				}
				else if (currentRow == numRows - 1)
				{
					isDown = false;
				}

					currentRow = isDown ? currentRow + 1 : currentRow - 1;
			}

			return string.Concat(temp);
		}
	}
}
