
List<int> rev(List<int> ls) {
    return ls.Aggregate(new List<int>(), (a,x) => {
        a.Insert(0, x);
        return a;
    });
}

T id<T>(T t) => t;

void q(List<int> expected, List<int> ls) {
    var rv = rev(ls);
    var ok = expected.Select( (x, i) => x == rv[i]).All(id);
    Console.WriteLine(ok);
}

var list = new List<int> { 1,2,3,4 };

q (new List<int> { 4,3,2,1 }, list);




