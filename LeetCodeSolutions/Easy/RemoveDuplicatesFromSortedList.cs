using LeetCodeSolutions.DataStructures;

namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_83
	/// </summary>
	public class RemoveDuplicatesFromSortedList
	{
		/// <summary>
		/// 於 linked list 中刪除重複的項目
		/// </summary>
		/// <param name="head"></param>
		/// <returns></returns>
		public ListNode DeleteDuplicates(ListNode head)
		{
			var current = head;
			
			while (current != null && current.next !=null)
			{
				if(current.val == current.next.val)
				{
					current.next = current.next.next;
				}
				else
				{
					current = current.next;
				}
			}

			return head;
		}
	}
}
