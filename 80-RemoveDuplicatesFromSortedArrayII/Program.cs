// See https://aka.ms/new-console-template for more information

using DebugHelpers;

RemoveDuplicates([1,1,1,2,2,3]).Print();
RemoveDuplicates([0,0,1,1,1,1,2,3,3]).Print();
return;

int RemoveDuplicates(int[] nums)
{
	var dict = new Dictionary<int, int>
	{
		{nums[0], 1}
	};
	var validCounter = 1;
	for (var index = 1; index < nums.Length; index++) // Skip the first, it's always unique
	{

		if (!dict.ContainsKey(nums[index]))
		{
			dict.Add(nums[index], 1);
			nums[validCounter] = nums[index];
			validCounter++;
		}
		else if (dict[nums[index]] < 2)
		{
			dict[nums[index]]++;
			nums[validCounter] = nums[index];
			validCounter++;
		}
	}

	nums.Print();
	return validCounter;
}
