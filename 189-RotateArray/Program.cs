// See https://aka.ms/new-console-template for more information

using DebugHelpers;

Console.WriteLine("189 - Rotate Array");

Rotate([1, 2, 3, 4, 5, 6, 7], 3);
Rotate([-1, -100, 3, 99], 2);

return;

void Rotate(int[] nums,
	int k)
{
	var newNums = new int[nums.Length];

	for (var i = 0; i < nums.Length; i++)
	{
		var index = (i + k) % nums.Length;
		newNums[index] = nums[i];
	}

	nums = newNums;

	nums.Print();
}