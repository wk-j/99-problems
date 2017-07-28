
IEnumerable<int> randPermu(IEnumerable<int> input) {
    var len = input.Count();
    var l = new List<int>();
    while (l.Count() < len) {
        var r = new Random().Next(len);
        if (!l.Contains(r)) l.Add(r);
    }
    return l;
}

var rs = randPermu(new [] { 1,2,3,4,5,6});
Console.WriteLine(string.Join(",", rs));
