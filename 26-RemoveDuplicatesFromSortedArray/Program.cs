// See https://aka.ms/new-console-template for more information

using DebugHelpers;

RemoveDuplicates([1, 1, 2]).Print();
RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]).Print();
return;

int RemoveDuplicates(int[] nums)
{
	var hashSet = new HashSet<int>
	{
		nums[0]
	};
	var validCounter = 1;
	for (var index = 1; index < nums.Length; index++) // Skip the first, it's always unique
	{
		if (!hashSet.Add(nums[index])) continue;

		nums[validCounter] = nums[index];
		validCounter++;
	}

	nums.Print();
	return validCounter;
}