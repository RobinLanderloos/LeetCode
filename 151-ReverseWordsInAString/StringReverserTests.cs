using FluentAssertions;

namespace _151_ReverseWordsInAString;

public class StringReverserTests
{
	[TestCase("the sky is blue", "blue is sky the")]
	[TestCase("  hello world  ", "world hello")]
	[TestCase("a good  example", "example good a")]
	public void Should_ReverseWords_InString(string input, string expectedOutput)
	{
		var reversed = StringReverser.ReverseWords(input);

		reversed.Should().Be(expectedOutput);
	}
}