class C {
    public string E { set;get; }
}
class Single: C { 
    public Single(string e) => E = e;
}
class Multiple: C {
    public Multiple(string e, int n) { E = e; N = n; }
    public int N { set;get;}
}

var list = new [] { "a", "a", "a", "a", "b", "c", "c", "a", "a", "d", "e", "e", "e", "e" };
var empty = Enumerable.Empty<C>().ToList();

var ans = list.Aggregate(empty, (a, x) => {
    var last = a.LastOrDefault();
    switch (last) {
        case Single s when (s.E == x) : 
            last = new Multiple(x, 2);
            break;
        case Single s:
            a.Add(new Single(x));
            break;
        case Multiple m when (last.E == x) :
            m.N ++;
            break;
        case Multiple m:
            a.Add(new Single(x));
            break;
        default: 
            a.Add(new Single(x));
            break;
    }
    return a;
});

Console.WriteLine("Hello");

