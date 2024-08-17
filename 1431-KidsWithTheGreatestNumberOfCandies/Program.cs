using DebugHelpers;

Console.WriteLine("1431 - Kids With the Greatest Number of Candies");

KidsWithCandies([2, 3, 5, 1, 3], 3).ToArray().Print();
KidsWithCandies([4,2,1,1,2], 1).ToArray().Print();
KidsWithCandies([12, 1, 12], 10).ToArray().Print();

IList<bool> KidsWithCandies(int[] candies,
	int extraCandies)
{
	var largest = candies.Max();

	var result = new bool[candies.Length];
	for (var i = 0; i < candies.Length; i++)
	{
		if (candies[i] + extraCandies >= largest)
		{
			result[i] = true;
		}
	}

	return result;
}