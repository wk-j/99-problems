#r "../../packages/System.ValueTuple/lib/portable-net40+sl4+win8+wp8/System.ValueTuple.dll"

Tuple<IEnumerable<T>, IEnumerable<T>> split<T>(IEnumerable<T> input, int n) {
    if(input.Count() > n) {
        var head = input.Take(n);
        var tail = input.Skip(n);
        return Tuple.Create(head, tail);
    }else {
        return Tuple.Create(input, Enumerable.Empty<T>());
    }
}

var input = "abcdefghik".ToCharArray();
var ans = split(input, 3);

ans.Item1.ToList().ForEach(Console.Write);
Console.WriteLine();
ans.Item2.ToList().ForEach(Console.Write);
