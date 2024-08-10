// See https://aka.ms/new-console-template for more information

using DebugHelpers;

Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
Merge([1], 1, [], 0);
Merge([0], 0, [1], 1);

void Merge(int[] nums1,
	int m,
	int[] nums2,
	int n)
{
	var nums1Pointer = m - 1;
	var nums2Pointer = n - 1;
	for (var position = m + n - 1; position >= 0; position--)
	{
		if (nums1Pointer < 0)
		{
			nums1[position] = nums2[nums2Pointer];
			nums2Pointer--;
			continue;
		}

		if (nums2Pointer < 0)
		{
			nums1[position] = nums1[nums1Pointer];
			nums1Pointer--;
			continue;
		}

		if (nums1[nums1Pointer] < nums2[nums2Pointer])
		{
			nums1[position] = nums2[nums2Pointer];
			nums2Pointer--;
		}
		else
		{
			nums1[position] = nums1[nums1Pointer];
			nums1Pointer--;
		}
	}

	nums1.Print();
}