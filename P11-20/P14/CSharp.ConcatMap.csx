
IEnumerable<T> concatMap<T>(IEnumerable<T> input, Func<T, IEnumerable<T>> func) {
    T1 id<T1,X>(T1 t, X x) =>  t;
    var rs = input.Select(func);
    return rs.SelectMany(id);
}

var input = new [] { 1,2,3 };
var ans = concatMap(input, (x) => new [] { x, x });
ans.ToList().ForEach(Console.WriteLine);
