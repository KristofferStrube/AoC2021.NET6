using static Helpers.Helpers;

Reads()
    .Select(s => int.Parse(s))
    .Aggregate(
        (rd: int.MaxValue, nd: int.MaxValue, st: int.MaxValue, num: 0),
        (acc, curr) =>
        {
            acc.num += acc.nd + acc.st + curr > acc.rd + acc.nd + acc.st ? 1 : 0;
            (acc.rd, acc.nd, acc.st) = (acc.nd, acc.st, curr);
            return acc;
        })
    .Then(acc => acc.num - 1)
    .Then(Console.WriteLine);