namespace _338_CountingBits;

public class BinaryRepresentationCounter
{
	/// <summary>
	/// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
	/// </summary>
	public int[] CountBits(int n)
	{
		var ans = new int[n + 1];

		for (int i = 0; i <= n; i++)
		{
			var binary = Convert.ToString(i, 2);

			foreach (var binaryDigit in binary)
			{
				if (binaryDigit == '1')
				{
					ans[i]++;
				}
			}
		}

		return ans;
	}
}