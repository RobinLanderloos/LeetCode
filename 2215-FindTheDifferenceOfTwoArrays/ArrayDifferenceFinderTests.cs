using System.Collections;
using FluentAssertions;

namespace _2215_FindTheDifferenceOfTwoArrays;

public class ArrayDifferenceFinderTests
{
	[TestCaseSource(nameof(ShouldReturnDistinctNumbersFromBothArraysTestCases))]
	public void ShouldReturnDistinctNumbersFromBothArrays(int[] nums1,
		int[] nums2,
		List<IList<int>> expectedOutput)
	{
		IList<IList<int>> result = ArrayDifferenceFinder.FindDifference(nums1, nums2);

		result.Should().BeEquivalentTo(result);
	}

	public static IEnumerable<TestCaseData> ShouldReturnDistinctNumbersFromBothArraysTestCases()
	{
		yield return new TestCaseData(new[] { 1, 2, 3 }, new[] { 2, 4, 6 }, new List<IList<int>> { new List<int>() { 1, 3 }, new List<int>() { 4, 6 } });
		yield return new TestCaseData(new[] { 1, 2, 3, 3 }, new[] { 1, 1, 2, 2 }, new List<IList<int>> { new List<int>() { 3 }, });
	}
}

public static class ArrayDifferenceFinder
{
	public static IList<IList<int>> FindDifference(int[] nums1,
		int[] nums2)
	{


	}
}