// https://www.geeksforgeeks.org/program-to-find-greatest-common-divisor-gcd-of-n-strings/
using System.Text;
using DebugHelpers;

Console.WriteLine("1071 - Greatest common divisor of strings");

GcdOfStrings("ABCABC", "ABC").Print();
GcdOfStrings("ABCABC", "ABCDEF").Print();
GcdOfStrings("ABABAB", "ABAB").Print();
GcdOfStrings("LEET", "CODE").Print();
GcdOfStrings("AAAAAAAAA", "AAACCC").Print();


string GcdOfStrings(string str1, string str2)
{
	if (str1.Length < str2.Length)
	{
		return GcdOfStrings(str2, str1);
	}

	if (!str1.StartsWith(str2))
	{
		return "";
	}

	if (str2 == "")
	{
		return str1;
	}

	return GcdOfStrings(str1.Substring(str2.Length), str2);
}
