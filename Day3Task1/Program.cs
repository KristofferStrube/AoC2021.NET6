using static Helpers.Helpers;

var reads = Reads().ToList();

Enumerable
    .Range(0, reads[0].Length)
    .Aggregate((gamma: "", epsilon: ""),
    (res, i) =>
        Enumerable
            .Range(0, reads.Count)
            .Count(j => reads[j][i] == '0')
            >
            reads.Count / 2
            ?
            (res.gamma + '0', res.epsilon + '1')
            :
            (res.gamma + '1', res.epsilon + '0'))
    .Then(res => Convert.ToInt32(res.gamma, 2) * Convert.ToInt32(res.epsilon, 2))
    .Then(Console.WriteLine);