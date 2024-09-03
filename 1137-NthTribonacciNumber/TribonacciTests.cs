using FluentAssertions;

namespace _1137_NthTribonacciNumber;

public class TribonacciTests
{
	[TestCase(4, 4)]
	[TestCase(25, 1389537)]
	public void ShouldReturnNthValue(int n,
		int expectedNumber)
	{
		var number = Tribonacci.Nth(n);

		number.Should().Be(expectedNumber);
	}
}

public static class Tribonacci
{
	public static int Nth(int n)
	{
		switch (n)
		{
			case 0:
				return 0;
			case 1:
			case 2:
				return 1;
			case 3:
				return 2;
		}

		var numbers = new List<int>()
		{
			0, 1, 1, 2
		};

		var currentNum = 0;

		for (var i = 4; i <= n; i++)
		{
			currentNum = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
			numbers.Add(currentNum);
		}

		return currentNum;
	}
}