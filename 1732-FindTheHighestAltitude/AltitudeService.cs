namespace _1732_FindTheHighestAltitude;

public class AltitudeService
{
	public int LargestAltitude(int[] points)
	{
		var highest = 0;
		var currentHeight = 0;

		foreach (var point in points)
		{
			currentHeight += point;

			if (currentHeight > highest)
			{
				highest = currentHeight;
			}
		}

		return highest;
	}
}