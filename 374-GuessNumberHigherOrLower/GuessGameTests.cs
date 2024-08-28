using FluentAssertions;

namespace _374_GuessNumberHigherOrLower;

public class GuessGameTests
{
	[TestCase(6, -1)]
	[TestCase(4, 1)]
	[TestCase(5, 0)]
	public void GuessShouldReturnExpectedResult(int guess,
		int expectedResult)
	{
		var game = new GuessGame(5);

		var guessResult = game.guess(guess);

		guessResult.Should().Be(expectedResult);
	}

	[TestCase(10, 6)]
	[TestCase(1, 1)]
	[TestCase(2, 1)]
	[TestCase(1000, 50)]
	public void GuessNumberShouldFindPickedNumber(int n,
		int pickedNumber)
	{
		var game = new GuessGame(pickedNumber);

		var result = game.GuessNumber(n);

		result.Should().Be(pickedNumber);
	}
}

public class GuessGame
{
	private readonly int _number;

	public GuessGame(int number)
	{
		_number = number;
	}

	public int guess(int num)
	{
		if (num > _number)
		{
			return -1;
		}

		if (num < _number)
		{
			return 1;
		}

		return 0;
	}

	/// <summary>
	/// Returns the initially picked number
	/// </summary>
	/// <param name="n"></param>
	/// <returns></returns>
	public int GuessNumber(int n)
	{
		var middle = 0;
		var least = 1;
		var highest = n;

		while (least <= highest)
		{
			middle = least + (highest - least) / 2;

			var curr = guess(middle);

			switch (curr)
			{
				case 0:
					return middle;
				case 1:
					least = middle + 1;
					continue;
				case -1:
					highest = middle - 1;
					break;
			}
		}

		return middle;
	}
}