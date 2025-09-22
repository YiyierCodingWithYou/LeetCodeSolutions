namespace LeetCodeSolutions.Easy
{
	public class ValidParentheses
	{
		/// <summary>
		/// 判斷傳入字串是否為正確型別、順序的一對或多對括號
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public bool IsValid(string s)
		{
			Stack<char> stack = new Stack<char>();

			foreach (char c in s)
			{
				// 如果是開括號就 Push 進 stack
				if (c == '(' || c == '{' || c == '[')
				{
					stack.Push(c);
				}
				else
				{
					// 如果是閉括號就先檢查 stack 是否為空
					// 是 → 回傳 false
					if (stack.Count == 0)
					{
						return false;
					}
					else
					{
						// 否 → 接著檢查 stack 內的頂端元素是否為對應的開括號
						//		是 → 把頂端元素移除
						//		否 → 回傳 false
						stack.TryPeek(out char temp);

						if ((c == ')' && temp == '(') ||
							(c == '}' && temp == '{') ||
							(c == ']' && temp == '['))
						{
							stack.Pop();
						}
						else
						{
							return false;
						}
					}
				}
			}

			// stack 全部配對完才正確
			return stack.Count == 0;
		}
	}
}
