

Tuple<T, IEnumerable<T>> removeAt<T>(IEnumerable<T> input, int n) {
    var n1 = n - 1;
    var list = input.ToList();
    var value = input.ElementAt(n1);
    list.RemoveAt(n1);
    return Tuple.Create<T, IEnumerable<T>>(value, list);
}

var input = new List<string> { "a", "b", "c", "d" };
var ans = removeAt(input, 2);

Console.WriteLine(ans.Item1);
Console.WriteLine(string.Join("", ans.Item2));

var ans2 = input.Where((x, i) => i != 2 - 1);
Console.WriteLine(string.Join("", ans2));