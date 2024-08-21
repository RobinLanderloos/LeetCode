namespace _345_ReverseVowelsOfAString;

public class VowelReverser
{
	private static readonly HashSet<char> Vowels =
	[
		'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
	];

	public string ReverseVowels(string s)
	{
		return ReverseVowelsTwoPointer(s);
	}

	private string ReverseVowelsTwoPointer(string s)
	{
		var chars = s.ToCharArray();
		var left = 0;
		var right = s.Length - 1;
		var leftVowel = -1;
		var rightVowel = -1;

		while (left < right)
		{
			if (Vowels.Contains(s[left]))
			{
				leftVowel = left;
			}
			else
			{
				left++;
			}

			if (Vowels.Contains(s[right]))
			{
				rightVowel = right;
			}
			else
			{
				right--;
			}

			if (leftVowel <= -1 || rightVowel <= -1) continue;

			var temp = s[leftVowel];
			chars[leftVowel] = s[rightVowel];
			chars[rightVowel] = temp;

			// Reset
			leftVowel = -1;
			rightVowel = -1;

			left++;
			right--;
		}

		return new string(chars);
	}
}