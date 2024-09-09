namespace _746_MinCostClimbingStairs;

public class Stair(int[] cost)
{
	// ReSharper disable once InconsistentNaming


	public int MinimumCostToClimb()
	{
		var dp = new int[cost.Length + 1];

		dp[0] = cost[0];
		dp[1] = cost[1];

		for (var i = 2; i <= cost.Length; i++)
		{
			var current = i == cost.Length ? 0 : cost[i];
			dp[i] = current + Math.Min(dp[i - 1], dp[i - 2]);
		}

		return dp[cost.Length];
	}
}