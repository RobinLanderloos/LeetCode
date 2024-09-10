using FluentAssertions;

namespace _338_CountingBits;

public class BinaryRepresentationCounterTests
{
	[TestCase(2, new[] { 0, 1, 1 })]
	[TestCase(5, new[] { 0, 1, 1, 2, 1, 2 })]
	public void ShouldCountOnesInBinaryRepresentation(int n,
		int[] expectedCount)
	{
		var counter = new BinaryRepresentationCounter();

		var result = counter.CountBits(n);

		result.Should().BeEquivalentTo(expectedCount);
	}
}