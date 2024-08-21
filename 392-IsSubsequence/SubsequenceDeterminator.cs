namespace _392_IsSubsequence;

internal class SubsequenceDeterminator
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