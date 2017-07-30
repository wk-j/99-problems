
IEnumerable<int> randSelect(int n, int e) {
    var l = new List<int>();
    while(l.Count() < n) {
        var r = new Random().Next(e);
        if(!l.Contains(r)) l.Add(r);
    }
    return l;
}

var rs = randSelect(6, 49);
Console.WriteLine(string.Join(",", rs));