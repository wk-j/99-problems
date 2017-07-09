
IEnumerable<T> go<T>(IEnumerable<T> input) {
    T1 id<T1,X>(T1 t, X x) => t;
    IEnumerable<T> dup(T t) => new [] { t, t};

    var ans = input.Select(dup).SelectMany(id);
    return ans;
}

void print<T>(IEnumerable<T> input) {
    input.ToList<T>().ForEach(x => Console.Write(x.ToString()));
    Console.WriteLine();
}

print(go(new [] { 1,2,3}));
print(go(new [] { "A", "B", "C" }));

