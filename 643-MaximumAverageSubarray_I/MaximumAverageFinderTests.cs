using FluentAssertions;

namespace _643_MaximumAverageSubarray_I;

public class MaximumAverageFinderTests
{
	[TestCase(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
	[TestCase(new[] { 5 }, 1, 5.00000)]
	public void ShouldReturnMaxAverage(int[] nums,
		int k,
		double output)
	{
		var finder = new MaximumAverageFinder();

		var result = finder.FindMaxAverage(nums, k);

		result.Should().Be(output);
	}
}

public class MaximumAverageFinder
{
	public double FindMaxAverage(int[] nums,
		int k)
	{
		var highestAverage = double.MinValue;

		for (var i = 0; i < nums.Length; i++)
		{
			if (i + k > nums.Length) // Can't be equal to k
			{
				break;
			}

			var currentSum = 0;
			for (var j = i; j < i + k; j++)
			{
				if (j >= nums.Length)
				{
					break;
				}

				currentSum += nums[j];
			}

			var average = (double)currentSum / k;

			if (average > highestAverage)
			{
				highestAverage = average;
			}
		}

		return highestAverage;
	}
}