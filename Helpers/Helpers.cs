namespace Helpers;
public static class Helpers
{
    //read input
    private static IEnumerable<string> Lines()
    {
        while (true)
            yield return Console.ReadLine();
    }
    public static IEnumerable<string> Reads() => Lines()
        .TakeWhile(s => !s.Equals(string.Empty));

    //pipe-forward extension methods
    public static U Then<T, U>(this T input, Func<T, U> fun) => fun(input);
    public static void Then<T>(this T input, Action<T> fun) => fun(input);
}