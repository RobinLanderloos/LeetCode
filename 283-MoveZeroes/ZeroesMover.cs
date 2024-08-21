namespace _283_MoveZeroes;

public class ZeroesMover
{
	/// <summary>
	/// Moves zeroes inside of array in-place to the end while maintaining the order.
	/// </summary>
	/// <param name="nums"></param>
	public void MoveZeroes(int[] nums)
	{
		var zeroIndex = -1;

		var i = 0;
		while (i < nums.Length)
		{
			if (nums[i] == 0 && zeroIndex == -1)
			{
				zeroIndex = i;
				i++;
				continue;
			}

			if (zeroIndex <= -1 || nums[i] == 0)
			{
				i++;
				continue;
			}

			(nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
			i = zeroIndex;
			zeroIndex = -1;
		}
	}
}