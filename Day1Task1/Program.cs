IEnumerable<string> Reads()
{
    while (true)
        yield return Console.ReadLine();
}

Console.WriteLine(
    Reads()
        .TakeWhile(s => !s.Equals(string.Empty))
        .Select(s => int.Parse(s))
        .Aggregate(
            (prev: int.MaxValue, num: 0),
            (acc, curr) =>
            {
                acc.num += curr > acc.prev ? 1 : 0;
                acc.prev = curr;
                return acc;
            })
        .num
);