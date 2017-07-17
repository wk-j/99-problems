
IEnumerable<Tuple<T,T,T>> combinations<T>(IEnumerable<T> input, int n) {
    var rs = 
        from x in input 
        from y in input
        from z in input
        where (!x.Equals(y) && !y.Equals(z) && !z.Equals(x))
        select new { x, y, z }; 
    return rs.Select(x => new Tuple<T,T,T>(x.x, x.y, x.z));
}

var rs = combinations(new [] { "a","b","c","d","e", "f" }, 3).Select(x => $"{x.Item1}{x.Item2}{x.Item3}");
Console.WriteLine(string.Join(",", rs));

var rs2 = combinations(Enumerable.Range(1, 12), 3).Count();
Console.WriteLine(rs2);

// wrong