// See https://aka.ms/new-console-template for more information

using DebugHelpers;

Console.WriteLine("169 - Majority Element");

MajorityElement([3, 2, 3]).Print();
MajorityElement([2, 2, 1, 1, 1, 2, 2]).Print();
MajorityElement([1]).Print();

return;

int MajorityElement(int[] nums)
{
	var majorityCount = new Dictionary<int, int>();

	foreach (var num in nums)
	{
		if (!majorityCount.TryAdd(num, 1))
		{
			majorityCount[num]++;
		}

		if (majorityCount[num] > nums.Length / 2)
		{
			return num;
		}
	}

	return -1;
}