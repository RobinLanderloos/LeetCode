using System.Text;

namespace DebugHelpers;

public static class ArrayExtensions
{
	public static void Print<T>(this T[] array, string? name = null) where T : notnull
	{
		StringBuilder arrayPrintBuilder = new();
		if (!string.IsNullOrWhiteSpace(name))
		{
			arrayPrintBuilder.Append(name);
			arrayPrintBuilder.Append("\r\n");
		}

		arrayPrintBuilder.Append('[');

		for (var i = 0; i < array.Length; i++)
		{
			arrayPrintBuilder.Append(array[i]);
			if(i < array.Length - 1)
			{
				arrayPrintBuilder.Append(", ");
			}
		}
		arrayPrintBuilder.Append(']');

		Console.WriteLine($"{arrayPrintBuilder}");
	}

	public static void SwapInPlace<T>(this T[] array,
		int firstIndex,
		int secondIndex)
	{
		(array[firstIndex], array[secondIndex]) = (array[secondIndex], array[firstIndex]);
	}
}