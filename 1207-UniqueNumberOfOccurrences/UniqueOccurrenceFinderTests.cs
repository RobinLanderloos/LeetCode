using FluentAssertions;

namespace _1207_UniqueNumberOfOccurrences;

public class UniqueOccurrenceFinderTests
{
	[TestCase(new[] { 1, 2, 2, 1, 1, 3 }, true)]
	[TestCase(new[] { 1, 2 }, false)]
	[TestCase(new[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 }, true)]
	public void ShouldReturnExpectedResultForOccurrences(int[] arr,
		bool expectedResult)
	{
		bool result = arr.HasUniqueOccurrences();

		result.Should().Be(expectedResult);
	}
}

public static class UniqueOccurrenceFinder
{
	/// <summary>
	/// Returns `true` if the number of occurrences for every number in the array is true
	/// </summary>
	/// <param name="arr"></param>
	/// <returns></returns>
	public static bool HasUniqueOccurrences(this int[] arr)
	{
		var occurrences = new Dictionary<int, int>();

		foreach (var element in arr)
		{
			if (!occurrences.TryAdd(element, 1))
			{
				occurrences[element]++;
			}
		}

		var uniqueOccurrences = new HashSet<int>();
		foreach (var occurrence in occurrences)
		{
			if (uniqueOccurrences.Add(occurrence.Value))
			{
				continue;
			}

			return false; // Found non-unique occurrence
		}

		return true;
	}
}