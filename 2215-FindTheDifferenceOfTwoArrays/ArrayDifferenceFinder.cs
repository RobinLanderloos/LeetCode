namespace _2215_FindTheDifferenceOfTwoArrays;

internal static class ArrayDifferenceFinder
{
	public static IList<IList<int>> FindDifference(int[] nums1,
		int[] nums2)
	{
		var nums1Distinct = new List<int>();
		var nums2Distinct = new List<int>();
		var nums1HashSet = nums1.ToHashSet();
		var nums2HashSet = nums2.ToHashSet();

		foreach (var num1 in nums1HashSet)
		{
			if (!nums2HashSet.Contains(num1))
			{
				nums1Distinct.Add(num1);
			}
		}

		foreach (var num2 in nums2HashSet)
		{
			if (!nums1HashSet.Contains(num2))
			{
				nums2Distinct.Add(num2);
			}
		}

		return new List<IList<int>>() { nums1Distinct, nums2Distinct };
	}
}