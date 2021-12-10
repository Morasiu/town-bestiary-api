namespace TownBestiaryApi.Extensions; 

public static class IEnumerableExtensions {
	public static T Random<T>(this IEnumerable<T> enumerable) {
		var random = new Random();
		var e = enumerable as T[] ?? enumerable.ToArray();
		var count = e.Count();
		var index = random.Next(0, count);
		return e.ElementAt(index);
	}
}