IEnumerable<T> insertAt<T>(IEnumerable<T> input, T x, int n) {
    var h = input.Take(n - 1);
    var t = input.Skip(n - 1);
    return h.Concat(new [] { x} ).Concat(t);
}

var input = new [] { "a", "b", "c", "d" };
var ans = insertAt(input, "ALFA", 2).Aggregate((a, x) => a + $" {x}");
Console.WriteLine(ans);
