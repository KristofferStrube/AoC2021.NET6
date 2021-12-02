using static Helpers.Helpers;

Reads()
    .Select(s => int.Parse(s))
    .Aggregate(
        (prev: int.MaxValue, num: 0),
        (acc, curr) =>
            {
                acc.num += curr > acc.prev ? 1 : 0;
                acc.prev = curr;
                return acc;
            })
    .Then(acc => acc.num)
    .Then(Console.WriteLine);