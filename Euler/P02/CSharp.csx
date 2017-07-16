IEnumerable<Result> unfold<T,Result>(T start, Func<T,Tuple<Result,T>> func) {
    var result = func(start);
    yield return result.Item1;
    foreach(var x in unfold<T,Result>(result.Item2, func)) yield return x;
}

public class T {
    public T(int f, int s) {
        F = f;
        S = s;
    }
    public int F { set;get;}
    public int S { set;get;}
}

var y2 = 
    unfold(new T(1,1), x => new Tuple<int,T>(x.S, new T(x.S, x.F + x.S)))
    .Where(x => x % 2 == 0)
    .TakeWhile(x => x <= 1000000);
Console.WriteLine(y2.Sum());