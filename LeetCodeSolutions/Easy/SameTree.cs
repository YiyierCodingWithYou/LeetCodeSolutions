using LeetCodeSolutions.DataStructures;

namespace LeetCodeSolutions.Easy
{
	/// <summary>
	/// LeetCode_100
	/// </summary>
	public class SameTree
	{
		/// <summary>
		/// 檢查傳入的兩個二元樹是否相同
		/// </summary>
		/// <param name="p"></param>
		/// <param name="q"></param>
		/// <returns></returns>
		public bool IsSameTree(TreeNode p, TreeNode q)
		{
			bool result = Traverse(p, q);
			return result;
		}

		private bool Traverse(TreeNode p, TreeNode q)
		{

			if (p == null && q == null)
			{
				return true;
			}

			if (p == null || q == null)
			{
				return false;
			}

			if (p.val != q.val)
			{
				return false;
			}

			return Traverse(p.left, q.left) && Traverse(p.right, q.right); ;
		}
	}
}
