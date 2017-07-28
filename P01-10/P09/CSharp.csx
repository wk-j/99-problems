IEnumerable<IEnumerable<T>> pack<T>(IEnumerable<T> input, Func<T, Object> k) =>
    input.GroupBy(k).Select( x => x.AsEnumerable());

var data = "aaaabccaadeeee".ToCharArray();
var result = pack(data, x => x);

Console.WriteLine(result.Count());

Console.WriteLine(string.Join(",", result.Select(k => string.Join("", k))));