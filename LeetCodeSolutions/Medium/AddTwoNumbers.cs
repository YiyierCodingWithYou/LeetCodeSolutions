using LeetCodeSolutions.DataStructures;

namespace LeetCodeSolutions.Medium
{
	public class AddTwoNumbers
	{
		public ListNode AddTwoNumbersA(ListNode l1, ListNode l2)
		{
			// 建立第一個節點
			var result = new ListNode(0);
			var current = result;

			// 將每個節點各自相加，避免溢位
			// 需進位的部分先以變數接起來帶到下一位數

			int carry = 0;

			while (l1 != null || l2 != null || carry != 0)
			{
				int val1 = (l1 != null) ? l1.val : 0;
				int val2 = (l2 != null) ? l2.val : 0;

				int sum = val1 + val2 + carry;

				// 因題目要求一個節點只能放一位數，故把總和除以10，留下個位數
				// 並把進位的部分儲存於carry
				current.next = new ListNode(sum % 10);
				carry = sum / 10;

				// 移動到下一個節點
				if (l1 != null) l1 = l1.next;
				if (l2 != null) l2 = l2.next;
				current = current.next;

			}

			// 因第一個節點是自己賦予的0，因此返回next才是答案需要的節點的頭
			return result.next;
		}
	}
}
