// See https://aka.ms/new-console-template for more information

using System.Text;
using DebugHelpers;

Console.WriteLine("1768 - Merge Strings Alternately");

MergeAlternately("abc", "pqr").Print();
MergeAlternately("ab", "pqrs").Print();
MergeAlternately("abcd", "pq").Print();

string MergeAlternately(string word1,
	string word2)
{
	var longest = Math.Max(word1.Length, word2.Length);
	var stringBuilder = new StringBuilder();

	for (var i = 0; i <= longest; i++)
	{
		if (i > word1.Length)
		{
			stringBuilder.Append(word2[i..]);
			return stringBuilder.ToString();
		}

		if (i > word2.Length)
		{
			stringBuilder.Append(word1[i..]);
			return stringBuilder.ToString();
		}

		if (i < word1.Length)
		{
			stringBuilder.Append(word1[i]);
		}

		if (i < word2.Length)
		{
			stringBuilder.Append(word2[i]);
		}
	}

	return stringBuilder.ToString();
}