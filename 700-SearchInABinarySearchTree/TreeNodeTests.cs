using FluentAssertions;

namespace _700_SearchInABinarySearchTree;

public class TreeNodeTests
{
	[TestCaseSource(nameof(TestCaseData))]
	public void ShouldReturnRootNodeWithValue(TreeNode root,
		int val,
		TreeNode? expectedNode)
	{
		TreeNode? foundNode = TreeNode.SearchBST(root, val);

		foundNode.Should().BeEquivalentTo(expectedNode);
	}

	private static IEnumerable<TestCaseData> TestCaseData()
	{
		yield return new TestCaseData(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7)),
			2,
			new TreeNode(2, new TreeNode(1), new TreeNode(3)));
		yield return new TestCaseData(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7)),
			5,
			null);
		yield return new TestCaseData(new TreeNode(18, new TreeNode(2), new TreeNode(22, null, new TreeNode(63, null, new TreeNode(84)))),
			63,
			new TreeNode(63, null, new TreeNode(84)));
	}
}

public class TreeNode
{
	public int val;
	public TreeNode? left;
	public TreeNode? right;

	public TreeNode(int val = 0,
		TreeNode? left = null,
		TreeNode? right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}

	public static TreeNode? SearchBST(TreeNode root,
		int val)
	{
		if (root.val == val)
		{
			return root;
		}


		if (root.left != null)
		{
			var treeNode = SearchBST(root.left, val);
			if (treeNode != null)
			{
				return treeNode;
			}
		}

		if (root.right != null)
		{
			var treeNode = SearchBST(root.right, val);
			if (treeNode != null)
			{
				return treeNode;
			}
		}

		return null;
	}
}