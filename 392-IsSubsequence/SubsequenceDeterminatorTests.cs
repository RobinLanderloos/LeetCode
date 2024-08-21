using FluentAssertions;

namespace _392_IsSubsequence;

public class SubsequenceDeterminatorTests
{
	[TestCase("abc", "ahbgdc", true)]
	[TestCase("axc", "ahbgdc", false)]
	[TestCase("", "ahbgdc", true)]
	[TestCase("b", "abc", true)]
	public void CorrectlyDeterminesIfSubsequence(string s, string t, bool result)
	{
		var subsequenceDeterminator = new SubsequenceDeterminator();

		var isSubsequence = subsequenceDeterminator.Determine(s, t);

		isSubsequence.Should().Be(result);
	}
}

public class SubsequenceDeterminator
{
	public bool Determine(string s,
		string t)
	{
		var subsequenceIndex = 0;

		foreach (var currentChar in t)
		{
			if (subsequenceIndex > s.Length - 1)
			{
				break;
			}

			if (currentChar == s[subsequenceIndex])
			{
				subsequenceIndex++;
			}
		}

		return subsequenceIndex == s.Length;
	}
}