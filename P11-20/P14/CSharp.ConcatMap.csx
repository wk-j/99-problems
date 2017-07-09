
IEnumerable<T> concatMap<T>(IEnumerable<T> input, Func<T, IEnumerable<T>> func) {
    T1 cons<T1,X>(T1 t, X x) =>  t;
    return input.Select(func).SelectMany(cons);
}

var input = new [] { 1,2,3 };
var ans = concatMap(input, (x) => new [] { x, x });
ans.ToList().ForEach(Console.WriteLine);
