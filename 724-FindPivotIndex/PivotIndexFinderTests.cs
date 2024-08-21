using FluentAssertions;

namespace _724_FindPivotIndex;

public class PivotIndexFinderTests
{
	[TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
	[TestCase(new[] { 1, 2, 3 }, -1)]
	[TestCase(new[] { 2, 1, -1 }, 0)]
	[TestCase(new[] { -1, -1, 0, 1, 1, 0 }, 5)]
	public void ShouldReturnPivotIndex(int[] nums,
		int expectedIndex)
	{
		var pivotIndex = PivotIndexFinder.PivotIndex(nums);

		pivotIndex.Should().Be(expectedIndex);
	}
}

public static class PivotIndexFinder
{
	public static int PivotIndex(int[] nums)
	{
		var left = 0;
		var right = nums.Sum();

		if (left == right - nums[0])
		{
			// Left is equal to everything except the current index
			return 0;
		}

		right -= nums[0];

		for (var i = 1; i < nums.Length; i++)
		{
			left += nums[i - 1];
			right -= nums[i];

			if (left == right)
			{
				return i;
			}
		}

		return -1;
	}
}