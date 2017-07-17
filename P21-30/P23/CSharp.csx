
IEnumerable<int> randSelect(IEnumerable<int> input, int n) {
    var l = new List<int>();
    while(l.Count() < n) {
        var r = new Random().Next(input.Count());
        var rs = input.ElementAt(r);
        if (!l.Contains(rs)) l.Add(rs);
    }
    return l;
}

var input = new [] { 1,2,3,4,5 };
var rs = randSelect(input, 3);
Console.WriteLine(string.Join(",", rs));