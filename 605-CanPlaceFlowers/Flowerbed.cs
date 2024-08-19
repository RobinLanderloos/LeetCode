using DebugHelpers;

namespace _605_CanPlaceFlowers;

public static class Flowerbed
{
	public static bool CanPlaceFlowers(int[] flowerbed,
		int n)
	{
		var planted = 0;

		for (var i = 0; i < flowerbed.Length; i++)
		{
			if (!CanPlant(flowerbed, i)) continue;

			// Currently we modify the array, but we could also store the planted indices into a hashmap and check against that
			planted++;
			flowerbed[i] = 1;
		}

		return planted >= n;
	}

	private static bool CanPlant(int[] flowerBed,
		int index)
	{
		if (flowerBed[index] == 1)
		{
			return false;
		}

		var leftNotPlanted = index - 1 < 0 || flowerBed[index - 1] == 0;
		var rightNotPlanted = index + 1 >= flowerBed.Length || flowerBed[index + 1] == 0;

		return leftNotPlanted && rightNotPlanted;
	}
}