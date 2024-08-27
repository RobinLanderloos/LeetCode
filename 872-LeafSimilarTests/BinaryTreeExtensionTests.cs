using FluentAssertions;

namespace _872_LeafSimilarTests;

public class BinaryTreeExtensionTests
{
	[TestCaseSource(nameof(ShouldReturnExpectedResultOnLeafSimilarTestData))]
	public void ShouldReturnExpectedResultOnLeafSimilar(TreeNode root1,
		TreeNode root2,
		bool expectedResult)
	{
		var leafSimilar = root1.LeafSimilar(root2);

		leafSimilar.Should().Be(expectedResult);
	}

	public static IEnumerable<TestCaseData> ShouldReturnExpectedResultOnLeafSimilarTestData()
	{
		yield return new TestCaseData(new TreeNode(3,
				new TreeNode(5, new TreeNode(6), new TreeNode(2, new TreeNode(7), new TreeNode(4))),
				new TreeNode(1, new TreeNode(9), new TreeNode(8))),
			new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(7)),
				new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8))))
			, true);
		yield return new TestCaseData(new TreeNode(1, new TreeNode(2), new TreeNode(3)),
			new TreeNode(1, new TreeNode(3), new TreeNode(2)), false);
	}
}

public static class BinaryTreeExtensions
{
	public static bool LeafSimilar(this TreeNode root1,
		TreeNode root2)
	{
		var root1Leafs = new List<int>();
		var root2Leafs = new List<int>();

		root1.Traverse(root1Leafs);
		root2.Traverse(root2Leafs);

		if (root1Leafs.Count != root2Leafs.Count)
		{
			return false;
		}

		for (var i = 0; i < root1Leafs.Count; i++)
		{
			if (root1Leafs[i] != root2Leafs[i])
			{
				return false;
			}
		}

		return true;
	}

	private static void Traverse(this TreeNode node,
		List<int> leafValues)
	{
		if (node.right == null && node.left == null) // Found a leaf node
		{
			leafValues.Add(node.val);
		}

		if (node.left != null)
		{
			Traverse(node.left, leafValues);
		}

		if (node.right != null)
		{
			Traverse(node.right, leafValues);
		}
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
}