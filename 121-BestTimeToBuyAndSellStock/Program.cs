// See https://aka.ms/new-console-template for more information

using DebugHelpers;

Console.WriteLine("121 - Best Time to Buy and Sell Stock");

MaxProfit([7, 1, 5, 3, 6, 4]).Print();
MaxProfit([7, 6, 4, 3, 1]).Print();

return;

int MaxProfit(int[] prices)
{
	var maxProfit = 0;
	var lowestPrice = int.MaxValue;

	foreach (var currentPrice in prices)
	{
		if (currentPrice < lowestPrice)
		{
			lowestPrice = currentPrice;
			continue;
		}
		if(currentPrice - lowestPrice > maxProfit)
		{
			maxProfit = currentPrice - lowestPrice;
		}
	}

	return maxProfit;
}