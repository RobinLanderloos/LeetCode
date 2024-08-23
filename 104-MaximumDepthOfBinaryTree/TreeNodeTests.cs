using System.Collections;
using FluentAssertions;

// ReSharper disable InconsistentNaming

namespace _104_MaximumDepthOfBinaryTree;

public class TreeNodeTests
{
	[TestCaseSource(nameof(BinaryTreeTestCaseData))]
	public void ShouldReturnMaximumDepth(TreeNode root,
		int expectedDepth)
	{
		var depth = TreeNode.MaxDepth(root);

		depth.Should().Be(expectedDepth);
	}

	internal static IEnumerable<TestCaseData> BinaryTreeTestCaseData()
	{
		yield return new TestCaseData(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7))), 3);
		yield return new TestCaseData(new TreeNode(1, null, new TreeNode(2)), 2);
		yield return new TestCaseData(new TreeNode(1), 1);
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

	// Would prefer this to be a non-static method, but is easier for pasting into LeetCode editor
	public static int MaxDepth(TreeNode? root)
	{
		if (root == null)
		{
			return 0;
		}

		return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
	}
}