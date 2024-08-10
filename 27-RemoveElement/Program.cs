// See https://aka.ms/new-console-template for more information

using DebugHelpers;

RemoveElement([3, 2, 2, 3], 3).Print("Case 1");
RemoveElement([0, 1, 2, 2, 3, 0, 4, 2], 2).Print("Case 2");
return;

int RemoveElement(int[] nums, int val)
{
	var lastInvalidPointer = nums.Length - 1;
	var invalidCounter = 0;
	for (var position = nums.Length - 1; position >= 0; position--)
	{
		if (nums[position] != val) continue;

		(nums[lastInvalidPointer], nums[position]) = (nums[position], nums[lastInvalidPointer]);
		lastInvalidPointer--;
		invalidCounter++;
	}

	nums.Print();
	return nums.Length - invalidCounter;
}