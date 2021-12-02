IEnumerable<string> Reads()
{
    while (true)
        yield return Console.ReadLine();
}


var pos = Reads()
    .TakeWhile(s => !s.Equals(string.Empty))
    .Select(s => (d: s[0], c: int.Parse(s.Split(" ")[1])))
    .Aggregate(
        (x: 0, y: 0),
        (pos, curr) =>
            curr.d == 'u' ? (pos.x, pos.y - curr.c) :
            curr.d == 'd' ? (pos.x, pos.y + curr.c) :
            (pos.x + curr.c, pos.y)
    );

Console.WriteLine(pos.x * pos.y);