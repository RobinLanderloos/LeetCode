namespace DebugHelpers;

public static class ObjectExtensions
{
	public static void Print<T>(this T obj, string? name = null)
	{
		Console.WriteLine($"{name}: {obj}");
	}
}