using FluentAssertions;

namespace _345_ReverseVowelsOfAString;

public class VowelReverserTests
{
	[TestCase("hello", "holle")]
	[TestCase("leetcode", "leotcede")]
	[TestCase("Euston saw I was not Sue.", "euston saw I was not SuE.")]
	public void ShouldReturnReversedVowels(string input,
		string result)
	{
		var vowelReverser = new VowelReverser();

		var reversed = vowelReverser.ReverseVowels(input);

		reversed.Should().Be(result);
	}
}