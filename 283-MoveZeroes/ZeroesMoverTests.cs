using FluentAssertions;

namespace _283_MoveZeroes;

public class ZeroesMoverTests
{
	[
		TestCase(new[] { 0, 1, 0, 3, 12 }, new[] { 1, 3, 12, 0, 0 }),
		TestCase(new[] { 0 }, new[] { 0 }),
	]
	public void MovesAllZeroesToEnd_AndMaintainsOrder(int[] input,
		int[] result)
	{
		var zeroesMover = new ZeroesMover();

		zeroesMover.MoveZeroes(input);

		input.Should().Equal(result);
	}
}