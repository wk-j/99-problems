IEnumerable<int> range(int s, int e) =>
    Enumerable.Range(s, e - s + 1);

var r = range(4, 9);
Console.WriteLine(string.Join(",", r));