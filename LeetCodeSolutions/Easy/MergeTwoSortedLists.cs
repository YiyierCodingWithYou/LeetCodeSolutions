using LeetCodeSolutions.DataStructures;

namespace LeetCodeSolutions.Easy
{
	public class MergeTwoSortedLists
	{
		/// <summary>
		/// 合併兩個已排序的ListNode並回傳新的排序後ListNode
		/// </summary>
		/// <param name="list1"></param>
		/// <param name="list2"></param>
		/// <returns></returns>
		public ListNode MergeTwoListsA(ListNode list1, ListNode list2)
		{
			var result = new ListNode(0);
			var current = result;
			var intList = new List<int>();

			while (list1 != null || list2 != null)
			{
				if (list1 != null)
				{
					intList.Add(list1.val);
					list1 = list1.next;
				}

				if (list2 != null)
				{
					intList.Add(list2.val);
					list2 = list2.next;
				}
			}

			intList.Sort();

			if(intList.Count > 0)
			{
				for(int i = 0; i < intList.Count; i++)
				{
					current.next = new ListNode(intList[i]);
					current = current.next;
				}
			}

			return result.next;
		}

		public ListNode MergeTwoListsB(ListNode list1, ListNode list2)
		{
			var result = new ListNode(0);
			var current = result;

			while (list1 != null && list2 != null)
			{
				if (list2.val >= list1.val)
				{
					current.next = new ListNode(list1.val);
					list1 = list1.next;
				}
				else
				{
					current.next = new ListNode(list2.val);
					list2 = list2.next;
				}

				current = current.next;
			}

			if(list1 != null && list2 == null)
			{
				current.next = list1;
			}

			if(list1 == null && list2 != null)
			{
				current.next = list2;
			}

			return result.next;
		}
	}
}
