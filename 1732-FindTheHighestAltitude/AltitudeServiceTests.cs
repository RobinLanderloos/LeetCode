using FluentAssertions;

namespace _1732_FindTheHighestAltitude;

public class AltitudeServiceTests
{
	[TestCase(new[] { -5, 1, 5, 0, -7 }, 1)]
	[TestCase(new[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
	public void ShouldReturnHighestAltitude(int[] points,
		int expectedAltitude)
	{
		var altitudeService = new AltitudeService();

		int highestAltitude = altitudeService.LargestAltitude(points);

		highestAltitude.Should().Be(expectedAltitude);
	}
}