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
            (rd: int.MaxValue, nd: int.MaxValue, st: int.MaxValue, num: 0),
            (acc, curr) =>
            {
                acc.num += acc.nd + acc.st + curr > acc.rd + acc.nd + acc.st ? 1 : 0;
                (acc.rd, acc.nd, acc.st) = (acc.nd, acc.st, curr);
                return acc;
            })
        .num - 1
);