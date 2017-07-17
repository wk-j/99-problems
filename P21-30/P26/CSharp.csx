
IEnumerable<Tuple<int,int,int>> combinations(IEnumerable<int> input, int n) {
    var rs = 
        from x in input 
        from y in input
        from z in input
        where (x != y && y != z && z != x)
        select new { x, y, z }; 
    return rs.Select(x => new Tuple<int,int,int>(x.x, x.y, x.z));
}

var rs = combinations(new [] { 1,2,3,4,5 }, 3).Select(x => $"({x.Item1},{x.Item2},{x.Item3})");
Console.WriteLine(string.Join(",", rs));