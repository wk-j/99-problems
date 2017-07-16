
IEnumerable<Result> unfold2<T,Result>(T start, Func<T,Tuple<Result,T>> func) {
    var next = start;
    while(true) {
        var res = func(next);
        yield return res.Item1;
        next = res.Item2;
    }
}

public class T {
    public T(int f, int s) {
        F = f;
        S = s;
    }
    public int F { set;get;}
    public int S { set;get;}
}

var y2 = unfold2(new T(1,1), x => new Tuple<int,T>(x.S, new T(x.S, x.F + x.S))).Where(x => x % 2 == 0).TakeWhile(x => x <= 1000000);
Console.WriteLine(y2.Sum());