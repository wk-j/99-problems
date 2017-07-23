
IEnumerable<IEnumerable<T>> group<T>(IEnumerable<T> input, Func<T, Object> k) =>
    input.GroupBy(k).Select( x => x.AsEnumerable());

var data = "aaaabccaadeeee".ToCharArray();
//var data = new [] { 1,1,1,2, 3,3,4, 4};
var result = group(data, x => x);

Console.WriteLine(result.Count());

Console.WriteLine(string.Join(",", result.Select(k => string.Join("", k))));