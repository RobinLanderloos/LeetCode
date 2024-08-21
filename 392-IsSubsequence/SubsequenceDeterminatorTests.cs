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