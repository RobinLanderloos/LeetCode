using FluentAssertions;

namespace _206_ReverseLinkedList;

public class LinkedListExtensionsTests
{
	[TestCaseSource(nameof(TestCaseSourceData))]
	public void ShouldReverseLinkedList(ListNode head,
		ListNode expectedReversed)
	{
		var reversed = head.Reverse();

		reversed.Should().BeEquivalentTo(expectedReversed);
	}

	internal static IEnumerable<TestCaseData> TestCaseSourceData()
	{
		yield return new TestCaseData(
			new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))),
			new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))))
		);
		yield return new TestCaseData(
			new ListNode(1, new ListNode(2)), new ListNode(2, new ListNode(1))
		);
		yield return new TestCaseData();
	}
}

public static class ListNodeExtensions
{
	// https://www.geeksforgeeks.org/reverse-a-linked-list/
	public static ListNode Reverse(this ListNode head)
	{
		ListNode? previous = null;
		var current = head;
		ListNode? next;

		while (current != null)
		{
			next = current.next;
			current.next = previous;
			previous = current;
			current = next;
		}

		return previous;
	}
}

public class ListNode
{
	public int val;
	public ListNode? next;

	public ListNode(int val = 0,
		ListNode? next = null)
	{
		this.val = val;
		this.next = next;
	}
}