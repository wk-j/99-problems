IEnumerable<Tuple<T,T,T>> combinations<T>(IEnumerable<T> input, int n) {
    var rs = 
        from x in input.Select((v, i) => new { v, i})
        from y in input.Skip(x.i + 1).Select((v, i) => new { v, i })
        from z in input.Skip(x.i + y.i + 2).Select((v,i) => new { v, i })
        select new { X = x.v, Y = y.v, Z = z.v }; 
    return rs.Select(x => new Tuple<T,T,T>(x.X, x.Y, x.Z));
}

var rs = combinations(new [] { "a","b","c","d","e", "f" }, 3).Select(x => $"{x.Item1}{x.Item2}{x.Item3}");
Console.WriteLine(string.Join(",", rs));
Console.WriteLine(rs.Count());

Console.WriteLine(combinations(Enumerable.Range(0, 12), 3).Count());

