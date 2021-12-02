using static Helpers.Helpers;

Reads()
    .Select(s => (d: s[0], c: int.Parse(s.Split(" ")[1])))
    .Aggregate(
        (x: 0, y: 0),
        (pos, curr) =>
            curr.d == 'u' ? (pos.x, pos.y - curr.c) :
            curr.d == 'd' ? (pos.x, pos.y + curr.c) :
            (pos.x + curr.c, pos.y)
    )
    .Then(acc => acc.x * acc.y)
    .Then(Console.WriteLine);