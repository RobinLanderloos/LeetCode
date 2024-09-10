namespace _136_SingleNumber;

public static class SingleNumberFinder
{
	public static int SingleNumber(int[] nums)
	{
		var xor = 0;

		foreach (var num in nums)
		{
			xor ^= num;
		}

		return xor;
	}
}