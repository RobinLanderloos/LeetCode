using FluentAssertions;

namespace _605_CanPlaceFlowers;

public class FlowerbedTests
{
	[TestCase(new[] { 1, 0, 0, 0, 1 }, 1, true)]
	[TestCase(new[] { 1, 0, 0, 0, 1 }, 2, false)]
	public void CanPlantSpecifiedAmount(int[] flowerbed,
		int amount,
		bool result)
	{
		Flowerbed.CanPlaceFlowers(flowerbed, amount).Should().Be(result);
	}
}