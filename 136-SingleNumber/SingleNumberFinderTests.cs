using FluentAssertions;

namespace _136_SingleNumber;

public class SingleNumberFinderTests
{
	[TestCase(new[] { 2, 2, 1 }, 1)]
	[TestCase(new[] { 4, 1, 2, 1, 2 }, 4)]
	[TestCase(new[] { 1 }, 1)]
	public void ShouldReturnOnlySingleNumber(int[] nums,
		int expectedOutput)
	{
		var result = SingleNumberFinder.SingleNumber(nums);

		result.Should().Be(expectedOutput);
	}
}