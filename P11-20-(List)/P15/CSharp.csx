
IEnumerable<T> dup<T>(IEnumerable<T> input, int count) =>
    input.Select(x => Enumerable.Repeat(x, count)).SelectMany(x => x);

var input = new [] { 1, 2, 3 };
var ins = dup(input, 3);
ins.ToList().ForEach(Console.Write);
Console.WriteLine();
