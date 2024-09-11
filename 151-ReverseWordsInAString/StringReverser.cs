using System.Text;

namespace _151_ReverseWordsInAString;

public static class StringReverser
{
	public static string ReverseWords(string s)
	{
		var words = new List<string>();

		var word = new StringBuilder();
		foreach (var character in s)
		{
			if (character != ' ')
			{
				word.Append(character);
			}
			else
			{
				if (word.Length > 0)
				{
					words.Add(word.ToString());
					word.Clear();
				}
			}
		}

		if (word.Length > 0)
		{
			words.Add(word.ToString());
		}

		var reversedBuilder = new StringBuilder();
		for (int i = words.Count - 1; i >= 0; i--)
		{
			reversedBuilder.Append(words[i]);
			if (i != 0)
			{
				reversedBuilder.Append(' ');
			}
		}

		return reversedBuilder.ToString();
	}
}