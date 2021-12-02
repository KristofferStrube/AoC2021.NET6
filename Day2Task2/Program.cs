using static Helpers.Helpers;

Reads()
    .Select(s => (d: s[0], c: int.Parse(s.Split(" ")[1])))
    .Aggregate(
        (x: 0, y: 0, aim: 0),
        (prev, curr) =>
            curr.d == 'd' ? (prev.x, prev.y, prev.aim + curr.c) :
            curr.d == 'u' ? (prev.x, prev.y, prev.aim - curr.c) :
            (prev.x + curr.c, prev.y + prev.aim * curr.c, prev.aim)
    )
    .Then(pos => pos.x * pos.y)
    .Then(Console.WriteLine);