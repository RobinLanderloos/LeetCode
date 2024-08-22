using FluentAssertions;

namespace _933_NumberOfRecentCalls;

public class RecentCallsCounterTests
{
	[Test]
	[TestCaseSource(nameof(RequestTestData))]
	public void ShouldReturnAmountOfRequestInPast3000Ms(int[] requests,
		int[] expectedResults)
	{
		var recentCounter = new RecentCounter();

		for (var index = 0; index < requests.Length; index++)
		{
			var request = requests[index];
			var recentCount = recentCounter.Ping(request);

			recentCount.Should().Be(expectedResults[index]);
		}
	}

	internal static IEnumerable<TestCaseData> RequestTestData()
	{
		yield return new TestCaseData(new [] { 1, 100, 3001, 3002 }, new [] { 1, 2, 3, 3 });
	}
}

public class RecentCounter
{
	private readonly Queue<int> _requests = new();

	public int? Ping(int request)
	{
		_requests.Enqueue(request);
		var past = request - 3000;

		while (_requests.First() < past)
		{
			_requests.Dequeue();
		}

		return _requests.Count;
	}
}