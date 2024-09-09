using FluentAssertions;

namespace _746_MinCostClimbingStairs;

public class StairTests
{
	[TestCase(new[] { 10, 15, 20 }, 15)]
	[TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
	public void ShouldGiveMinimumCost(int[] cost,
		int expectedCost)
	{
		var stair = new Stair(cost);

		var minCost = stair.MinimumCostToClimb();

		minCost.Should().Be(expectedCost);
	}
}